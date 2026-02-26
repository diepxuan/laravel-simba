<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 12:20:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPostArPh3ArTt.
 *
 * Stored procedure: asPostArPh3_arTt
 * Mục đích: Post dữ liệu từ chứng từ thanh toán công nợ phải thu (ArPh3) và chi tiết thanh toán (ArCt3) vào bảng arTt (bảng thanh toán công nợ phải thu).
 * Procedure thực hiện các bước:
 * 1. Lấy ngày chứng từ (ngay_ct) từ bảng ArPh3 dựa trên mã công ty và số chứng từ.
 * 2. Tính năm tài chính (NamTC) và tháng tài chính (ThangTC) thông qua hàm afNamTC, afThangTC.
 * 3. Kiểm tra ngày khóa sổ: nếu ngày chứng từ nhỏ hơn hoặc bằng ngày khóa sổ (từ bảng siSetup) thì không thực hiện (RETURN).
 * 4. Xóa các bản ghi cũ trong arTt có cùng mã công ty và số chứng từ.
 * 5. Chèn dữ liệu mới từ join giữa ArPh3 và ArCt3 vào arTt, bao gồm các thông tin: mã công ty, số chứng từ, số chứng từ hóa đơn, loại thanh toán (cố định '2'), mã giao dịch (cố định '1'), mã chứng từ, mã khách hàng, mã hợp đồng, diễn giải, số chứng từ, ngày chứng từ, tháng tài chính, năm tài chính, mã ngoại tệ, tỷ giá, tổng tiền, tổng tiền ngoại tệ, tiền thanh toán, tiền thanh toán quy đổi, tiền thanh toán ngoại tệ, ngày tạo, người tạo, ngày sửa, người sửa.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pStt_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của chứng từ thanh toán công nợ phải thu (nvarchar(20)).
 *   Ví dụ: 'AR202500001'
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày chứng từ nằm trong kỳ đã khóa sổ, procedure sẽ return ngay (không thực hiện insert).
 * - Số bản ghi được insert vào arTt tương ứng với số dòng chi tiết thanh toán (ArCt3) của chứng từ.
 *
 * Logic chi tiết:
 * - Lấy ngay_ct từ ArPh3 WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - Gọi hàm dbo.afNamTC(@pMa_cty, @pNgay_ct) để lấy năm tài chính.
 * - Gọi hàm dbo.afThangTC(@pMa_cty, @pNgay_ct) để lấy tháng tài chính.
 * - Kiểm tra điều kiện khóa sổ: SELECT ngay_ks FROM siSetup WHERE ma_cty = @pMa_cty.
 *   Nếu @pNgay_ct <= ngay_ks thì RETURN.
 * - DELETE FROM arTt WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - INSERT INTO arTt SELECT ... từ ArPh3 p JOIN ArCt3 c ON p.ma_cty = c.Ma_cty AND p.Stt_rec = c.stt_rec.
 *   Các giá trị cố định: loai_tt = '2', ma_gd = '1'.
 *
 * Ví dụ gọi:
 * ```php
 * // Post chứng từ thanh toán công nợ phải thu
 * AsPostArPh3ArTt::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AR202500001',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ.
 * - Cần đảm bảo dữ liệu trong ArPh3 và ArCt3 đã tồn tại.
 * - Các hàm afNamTC và afThangTC phải được định nghĩa trong database.
 * - Bảng siSetup phải có bản ghi cho công ty tương ứng.
 */
class AsPostArPh3_arTt extends StoredProcedure
{
    public const NAME = 'asPostArPh3_arTt';

    /**
     * Gọi stored procedure asPostArPh3_arTt.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (thường là không có resultset)
     */
    public static function call(array $params): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pNamTC'   => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
        ], $params));
    }

    /**
     * Call stored procedure asPostArPh3_arTt with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, ?int $NamTC = null, ?int $ThangTC = null, ?string $Ngay_ct = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNamTC'   => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
        ];

        return self::call($params);
    }
}
