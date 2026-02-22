<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalSo2
 *
 * Stored procedure: asReCalSo2
 * Mục đích: Tính và cập nhật lại số liệu cho một phiếu xuất (sales delivery).
 * Procedure thực hiện ba công việc chính:
 * 1. Cập nhật số lượng hóa đơn (sl_hd, sl_hd_qd) cho từng dòng chi tiết phiếu xuất (soct2)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết hóa đơn (soct3).
 * 2. Cập nhật số lượng trả lại (sl_pn, sl_pn_qd) cho từng dòng chi tiết phiếu xuất (soct2)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết phiếu nhập trả lại (soct4) với điều kiện stt_rec_hd = '' (chưa có hóa đơn?).
 * 3. Kiểm tra và cập nhật trạng thái phiếu xuất (soPh2, soCt):
 *    - Nếu tất cả các dòng chi tiết có số lượng (so_luong) <= (sl_hd + sl_pn)
 *      (tổng số lượng đã lập hóa đơn và đã trả lại) thì cập nhật trạng thái thành '2' (hoàn thành).
 *    - Ngược lại, cập nhật trạng thái thành '1' (đang thực hiện).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec_px (string, bắt buộc): Số thứ tự bản ghi của phiếu xuất (stt_rec_px).
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên các bảng soct2, soPh2, soCt.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalSo2::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec_px' => 'PX001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng các bảng: soct2 (chi tiết phiếu xuất), soct3 (chi tiết hóa đơn), soct4 (chi tiết phiếu nhập trả lại), soPh2 (header phiếu xuất), soCt (bảng tổng hợp?).
 * - Trạng thái:
 *   + '1': Đang thực hiện (dang thuc hien)
 *   + '2': Hoàn thành (hoan thanh)
 * - Cột sl_hd (số lượng hóa đơn) và sl_hd_qd (số lượng quy đổi hóa đơn) được tính từ tổng so_luong, so_luong_qd trong soct3.
 * - Cột sl_pn (số lượng trả lại) và sl_pn_qd (số lượng quy đổi trả lại) được tính từ tổng so_luong, so_luong_qd trong soct4 với điều kiện stt_rec_hd = '' (có lẽ là phiếu nhập trả lại chưa có hóa đơn).
 * - Điều kiện nhóm: stt_rec0_px, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Bán hàng (SO) và phiếu xuất (SO2).
 */
class AsReCalSo2
{
    /**
     * Gọi stored procedure asReCalSo2
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalSo2', $params);
    }
}