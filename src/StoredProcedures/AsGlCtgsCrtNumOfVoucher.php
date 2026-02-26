<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:56:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGlCtgsCrtNumOfVoucher.
 *
 * Stored procedure: asGlCtgsCrtNumOfVoucher
 * Mục đích: Tạo chứng từ ghi sổ (sổ cái) cho các bút toán trong khoảng thời gian, theo tài khoản hoặc mã chứng từ.
 * Procedure này thực hiện việc đánh số chứng từ ghi sổ (so_lo) cho các bút toán thỏa điều kiện, đồng thời ghi lại thông tin chứng từ ghi sổ vào bảng glctgs.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)). Không có giá trị mặc định.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (nvarchar(3)). Không có giá trị mặc định.
 * - @pTk (string, tùy chọn): Tài khoản (nvarchar(20)).
 *   Giá trị mặc định: không có, nhưng trong logic xử lý, nếu @pTk = '#' thì sẽ cập nhật tất cả các tài khoản không nằm trong danh mục ghi sổ (gldmctgs). Nếu @pTk = '' (rỗng) thì chỉ đánh số theo mã chứng từ. Nếu @pTk khác rỗng và khác '#' thì đánh số cho các tài khoản có prefix trùng.
 * - @pTen_ct_gs (string, bắt buộc): Tên chứng từ ghi sổ (nvarchar(50)). Không có giá trị mặc định.
 * - @pSo_hieu (string, bắt buộc): Số hiệu chứng từ ghi sổ (nvarchar(3)). Không có giá trị mặc định.
 * - @pNgay_lo (datetime, bắt buộc): Ngày lô (ngày ghi sổ) (smalldatetime). Không có giá trị mặc định.
 * - @pNgay1 (datetime, bắt buộc): Ngày bắt đầu khoảng thời gian (smalldatetime). Không có giá trị mặc định.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Không có output parameter.
 * - Tác động: cập nhật các bút toán trong bảng glct (cột Ngay_lo, so_lo) và chèn bản ghi vào bảng glctgs.
 *
 * Logic chi tiết:
 * 1. Xóa các chứng từ ghi sổ cũ có cùng mã công ty, mã chứng từ, ngày lô và tài khoản.
 * 2. Xác định số chứng từ tiếp theo dựa trên số hiệu và ngày lô gần nhất.
 * 3. Cập nhật ngày lô và số lô cho các bút toán trong bảng glct tùy theo giá trị @pTk:
 *    - Nếu @pTk = '#': cập nhật tất cả các tài khoản không có trong danh mục ghi sổ (gldmctgs).
 *    - Nếu @pTk <> '' và <> '#': cập nhật các tài khoản có prefix trùng và các tài khoản đối ứng (tk_du) có prefix trùng.
 *    - Nếu @pTk = '': chỉ cập nhật theo mã chứng từ (không quan tâm tài khoản).
 * 4. Nếu có ít nhất một bút toán được cập nhật, chèn một bản ghi vào bảng glctgs để ghi nhận chứng từ ghi sổ.
 *
 * Ví dụ gọi:
 * ```php
 * // Đánh số chứng từ ghi sổ cho tài khoản '511' trong tháng 01/2023
 * AsGlCtgsCrtNumOfVoucher::call([
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'GL',
 *     'pTk' => '511',
 *     'pTen_ct_gs' => 'Kết chuyển doanh thu',
 *     'pSo_hieu' => 'KC',
 *     'pNgay_lo' => '2023-01-31',
 *     'pNgay1' => '2023-01-01',
 * ]);
 * // Đánh số chứng từ ghi sổ cho tất cả tài khoản không nằm trong danh mục ghi sổ
 * AsGlCtgsCrtNumOfVoucher::call([
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'GL',
 *     'pTk' => '#',
 *     'pTen_ct_gs' => 'Ghi sổ các tài khoản không thuộc danh mục',
 *     'pSo_hieu' => 'GS',
 *     'pNgay_lo' => '2023-01-31',
 *     'pNgay1' => '2023-01-01',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure này chỉ thực hiện đánh số chứng từ ghi sổ, không kiểm tra tính hợp lệ của dữ liệu bút toán.
 * - Số chứng tự được sinh ra có định dạng: [Số hiệu].[số thứ tự 9 ký tự] (ví dụ: KC.000000001).
 * - Cần đảm bảo rằng các bút toán trong khoảng thời gian đã được hạch toán đúng trước khi ghi sổ.
 * - Bảng glctgs lưu thông tin tổng hợp về chứng từ ghi sổ, giúp tra cứu sau này.
 */
class AsGlCtgsCrtNumOfVoucher
{
    /**
     * Gọi stored procedure asGlCtgsCrtNumOfVoucher.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGlCtgsCrtNumOfVoucher', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pMa_ct'     => $params['pMa_ct'] ?? null,
            'pTk'        => $params['pTk'] ?? null,
            'pTen_ct_gs' => $params['pTen_ct_gs'] ?? null,
            'pSo_hieu'   => $params['pSo_hieu'] ?? null,
            'pNgay_lo'   => $params['pNgay_lo'] ?? null,
            'pNgay1'     => $params['pNgay1'] ?? null,
            'pma_ct'     => $params['pma_ct'] ?? null,
            'prevLen'    => $params['prevLen'] ?? null,
            'pMa_Ct'     => $params['pMa_Ct'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asGlCtgsCrtNumOfVoucher with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_ct = null, ?string $Tk = null, ?string $Ten_ct_gs = null, ?string $So_hieu = null, ?string $Ngay_lo = null, ?string $Ngay1 = null, mixed $ma_ct = null, ?int $revLen = null, mixed $Ma_Ct = null): Collection
    {
        $params = [
            'pMa_cty'    => $Ma_cty,
            'pMa_ct'     => $Ma_ct,
            'pTk'        => $Tk,
            'pTen_ct_gs' => $Ten_ct_gs,
            'pSo_hieu'   => $So_hieu,
            'pNgay_lo'   => $Ngay_lo,
            'pNgay1'     => $Ngay1,
            'pma_ct'     => $ma_ct,
            'prevLen'    => $revLen,
            'pMa_Ct'     => $Ma_Ct,
        ];

        return self::call($params);
    }
}
