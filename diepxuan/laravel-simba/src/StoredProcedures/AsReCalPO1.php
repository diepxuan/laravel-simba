<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO1
 *
 * Stored procedure: asReCalPO1
 * Mục đích: Tính và cập nhật lại số liệu cho một đơn hàng (purchase order).
 * Procedure thực hiện ba công việc chính:
 * 1. Cập nhật số lượng đã hợp đồng (sl_hd, sl_hd_qd) cho từng dòng chi tiết đơn hàng (poct1)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết hợp đồng (poct3).
 * 2. Cập nhật số lượng đã nhập (sl_nhap, sl_nhap_qd) cho từng dòng chi tiết đơn hàng (poct1)
 *    dựa trên tổng hợp dữ liệu từ:
 *    - Bảng chi tiết phiếu nhập (poct2)
 *    - Bảng chi tiết hợp đồng (poct3) kết hợp với header hợp đồng (poph3) khi có điều kiện:
 *      + poph3.ma_gd = '1' (Hóa đơn kiêm phiếu nhập)
 *      + stt_rec_pn = '' (chưa có phiếu nhập?)
 * 3. Kiểm tra và cập nhật trạng thái đơn hàng (poPh1, poCt):
 *    - Nếu tất cả các dòng chi tiết có số lượng (so_luong) <= số lượng đã nhập (sl_nhap)
 *      thì cập nhật trạng thái thành '2' (hoàn thành).
 *    - Ngược lại, cập nhật trạng thái thành '1' (đang thực hiện).
 *    Trường hợp đơn hàng đã tất toán nhưng người dùng xóa một phiếu nhập của đơn hàng thì sẽ được chuyển lại về trạng thái thực hiện.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec_dh (string, bắt buộc): Số thứ tự bản ghi của đơn hàng (stt_rec_dh).
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên các bảng poct1, poPh1, poCt.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO1::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec_dh' => 'DH001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng các bảng: poct1 (chi tiết đơn hàng), poct2 (chi tiết phiếu nhập), poct3 (chi tiết hợp đồng), poPh1 (header đơn hàng), poCt (bảng tổng hợp?), poph3 (header hợp đồng).
 * - Trạng thái:
 *   + '1': Đang thực hiện (thực hiện)
 *   + '2': Hoàn thành (hoan thanh)
 * - Cột sl_hd (số lượng đã hợp đồng) và sl_hd_qd (số lượng quy đổi đã hợp đồng) được tính từ tổng so_luong, so_luong_qd trong poct3.
 * - Cột sl_nhap (số lượng đã nhập) và sl_nhap_qd (số lượng quy đổi đã nhập) được tính từ tổng so_luong, so_luong_qd trong poct2 và poct3 (với điều kiện đặc biệt).
 * - Điều kiện nhóm: stt_rec0_dh, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO).
 */
class AsReCalPO1
{
    /**
     * Gọi stored procedure asReCalPO1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO1', $params);
    }
}