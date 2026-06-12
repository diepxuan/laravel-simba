<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPoGetCa4Po
 *
 * Stored procedure: asPOGetCA4PO
 * Mục đích: Lấy thông tin chứng từ thanh toán (Chi/Báo nợ) từ phân hệ mua hàng.
 * Procedure truy vấn thông tin chứng từ thanh toán liên quan đến hóa đơn mua hàng.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (3 ký tự) - tuy nhiên trong điều kiện hiện tại bị comment.
 * - @pStt_rec_hd (string, bắt buộc): Số tham chiếu của hóa đơn (stt_rec_hd).
 * 
 * Giá trị trả về:
 * - Resultset gồm các cột: stt_rec, ma_ct, ngay_ct, so_ct, ma_nt, ty_gia, ma_kh, dia_chi, nguoi_gd, dien_giai, tk_co, tk, ps_no, ps_no_nt, ma_hd, ma_bp, ma_phi, ma_spct, ma_lo.
 * - Dữ liệu từ hai bảng CAPH2 và CaCt2 join với điều kiện mã công ty và số tham chiếu hóa đơn.
 * 
 * Ví dụ gọi:
 * ```php
 * $results = AsPoGetCa4Po::call([
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'PO',
 *     'pStt_rec_hd' => 'HD202500001',
 * ]);
 * foreach ($results as $row) {
 *     // Xử lý từng dòng
 * }
 * ```
 * 
 * Lưu ý:
 * - Điều kiện `a.ma_ct = @pMa_ct` hiện đang bị comment trong procedure, có thể sử dụng sau.
 * - Procedure chỉ lấy các chứng từ thanh toán liên quan đến hóa đơn mua hàng cụ thể.
 */
class AsPoGetCa4Po
{
    /**
     * Gọi stored procedure asPOGetCA4PO
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các đối tượng stdClass).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asPOGetCA4PO', $params);
    }
}