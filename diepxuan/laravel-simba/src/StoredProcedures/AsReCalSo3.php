<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalSo3
 *
 * Stored procedure: asReCalSo3
 * Mục đích: Tính và cập nhật lại số liệu cho một hóa đơn bán (sales invoice).
 * Procedure thực hiện cập nhật số lượng trả lại (sl_pn, sl_pn_qd) cho từng dòng chi tiết hóa đơn (soct3)
 * dựa trên tổng hợp dữ liệu từ bảng chi tiết phiếu nhập trả lại (soct4).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec_hd (string, bắt buộc): Số thứ tự bản ghi của hóa đơn (stt_rec_hd).
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên bảng soct3.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalSo3::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec_hd' => 'HD001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng các bảng: soct3 (chi tiết hóa đơn), soct4 (chi tiết phiếu nhập trả lại).
 * - Cột sl_pn (số lượng trả lại) và sl_pn_qd (số lượng quy đổi trả lại) được tính từ tổng so_luong, so_luong_qd trong soct4.
 * - Điều kiện nhóm: stt_rec0_hd, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Bán hàng (SO) và hóa đơn (SO3).
 */
class AsReCalSo3
{
    /**
     * Gọi stored procedure asReCalSo3
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalSo3', $params);
    }
}