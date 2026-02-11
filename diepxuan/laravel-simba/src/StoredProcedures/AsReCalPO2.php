<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO2
 *
 * Stored procedure: asReCalPO2
 * Mục đích: Tính và cập nhật lại số liệu cho một phiếu nhập (purchase receipt).
 * Procedure thực hiện ba công việc chính:
 * 1. Cập nhật số lượng đã lập hóa đơn (sl_hd, sl_hd_qd) cho từng dòng chi tiết phiếu nhập (poct2)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết hợp đồng/hóa đơn (poct3).
 * 2. Cập nhật số lượng đã trả lại (sl_px, sl_px_qd) cho từng dòng chi tiết phiếu nhập (poct2)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết phiếu xuất trả lại (poct5) với điều kiện stt_rec_hd = '' (chưa có hóa đơn?).
 * 3. Kiểm tra và cập nhật trạng thái phiếu nhập (poPh2, poCt):
 *    - Nếu tất cả các dòng chi tiết có số lượng (so_luong) <= (sl_hd + sl_px) 
 *      (tổng số lượng đã lập hóa đơn và đã trả lại) thì cập nhật trạng thái thành '2' (hoàn thành).
 *    - Ngược lại, cập nhật trạng thái thành '1' (đang thực hiện).
 *    Trường hợp phiếu nhập đã tất toán nhưng người dùng xóa một hóa đơn thì sẽ được chuyển lại về trạng thái thực hiện.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec_pn (string, bắt buộc): Số thứ tự bản ghi của phiếu nhập (stt_rec_pn).
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên các bảng poct2, poPh2, poCt.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO2::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec_pn' => 'PN001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng các bảng: poct2 (chi tiết phiếu nhập), poct3 (chi tiết hợp đồng/hóa đơn), poct5 (chi tiết phiếu xuất trả lại), poPh2 (header phiếu nhập), poCt (bảng tổng hợp?).
 * - Trạng thái:
 *   + '1': Đang thực hiện (thực hiện)
 *   + '2': Hoàn thành (hoan thanh)
 * - Cột sl_hd (số lượng đã lập hóa đơn) và sl_hd_qd (số lượng quy đổi đã lập hóa đơn) được tính từ tổng so_luong, so_luong_qd trong poct3.
 * - Cột sl_px (số lượng đã trả lại) và sl_px_qd (số lượng quy đổi đã trả lại) được tính từ tổng so_luong, so_luong_qd trong poct5 với điều kiện stt_rec_hd = '' (có lẽ là phiếu xuất chưa có hóa đơn).
 * - Điều kiện nhóm: stt_rec0_pn, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và phiếu nhập (PO2).
 */
class AsReCalPO2
{
    /**
     * Gọi stored procedure asReCalPO2
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO2', $params);
    }
}