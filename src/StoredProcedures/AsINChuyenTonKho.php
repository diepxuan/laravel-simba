<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:05:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsINChuyenTonKho.
 *
 * Stored procedure: asINChuyenTonKho
 * Mục đích: Chuyển tồn kho sang năm sau.
 * Procedure thực hiện chuyển tồn kho cuối kỳ sang năm tài chính tiếp theo.
 * Xóa dữ liệu tồn kho năm tiếp theo trước khi chèn mới.
 * Kiểm tra ngày kế sách, nếu ngày đầu năm sau nhỏ hơn hoặc bằng ngày kế sách thì báo lỗi 50012.
 *
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pngay_cnt (string/datetime, bắt buộc): Ngày cuối năm trước (small datetime). Format: 'YYYY-MM-DD HH:mm:ss'.
 * - @pma_kho (string, tùy chọn, mặc định ''): Mã kho (8 ký tự). Nếu rỗng sẽ chuyển tồn kho của tất cả các kho.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsINChuyenTonKho::call([
 *     'pma_cty' => '001',
 *     'pngay_cnt' => '2024-12-31 23:59:59',
 *     'pma_kho' => 'KHO01',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Chuyển tồn kho thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure xóa dữ liệu từ bảng incdvt (tồn kho chi tiết) cho năm tiếp theo, với điều kiện mã kho khớp với @pma_kho (LIKE @pma_kho + '%').
 * - Chèn dữ liệu tồn kho bằng cách gọi hàm afGetTonCuoiVtAll để lấy tồn kho cuối kỳ của tất cả vật tư, kho, vị trí, lô.
 * - Nếu ngày đầu năm sau <= ngày kế sách (ngay_ks trong sisetup) thì trả về lỗi 50012 (không cho phép chuyển).
 * - Hàm afNamTC được sử dụng để lấy năm tài chính tương ứng với ngày cuối năm.
 */
class AsINChuyenTonKho
{
    /**
     * Gọi stored procedure asINChuyenTonKho.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINChuyenTonKho', [
            'pma_cty'   => $params['pma_cty'] ?? null,
            'pngay_cnt' => $params['pngay_cnt'] ?? null,
            'pma_kho'   => $params['pma_kho'] ?? null,
            'pRet'      => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asINChuyenTonKho with named parameters.
     */
    public static function callWithParams(?string $ma_cty = null, ?string $ngay_cnt = null, ?string $ma_kho = null, ?int $Ret = null): Collection
    {
        $params = [
            'pma_cty'   => $ma_cty,
            'pngay_cnt' => $ngay_cnt,
            'pma_kho'   => $ma_kho,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
