<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO0
 *
 * Stored procedure: asReCalPO0
 * Mục đích: Tính và cập nhật lại số liệu cho một phiếu đề nghị (purchase order request).
 * Procedure thực hiện hai công việc chính:
 * 1. Cập nhật số lượng đã lập đơn hàng (sl_dh, sl_dh_qd) cho từng dòng chi tiết phiếu đề nghị (poct0)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết đơn hàng (poct1).
 * 2. Kiểm tra và cập nhật trạng thái phiếu đề nghị (poPh0, poCt):
 *    - Nếu tất cả các dòng chi tiết có số lượng (so_luong) <= số lượng đã lập đơn hàng (sl_dh) 
 *      thì cập nhật trạng thái thành '2' (hoàn thành).
 *    - Ngược lại, cập nhật trạng thái thành '1' (đang thực hiện).
 *    Trường hợp phiếu đề nghị đã tất toán nhưng người dùng xóa đơn hàng thì sẽ được chuyển lại về trạng thái thực hiện.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pstt_rec_pdn (string, bắt buộc): Số thứ tự bản ghi của phiếu đề nghị (stt_rec_pdn).
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên các bảng poct0, poPh0, poCt.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO0::call([
 *     'pMa_cty' => '901',
 *     'pstt_rec_pdn' => 'PDN001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng các bảng: poct0 (chi tiết phiếu đề nghị), poct1 (chi tiết đơn hàng), poPh0 (phần header phiếu đề nghị), poCt (bảng tổng hợp?).
 * - Trạng thái:
 *   + '1': Đang thực hiện (thực hiện)
 *   + '2': Hoàn thành (hoan thanh)
 * - Cột sl_dh (số lượng đã lập đơn hàng) và sl_dh_qd (số lượng quy đổi đã lập đơn hàng) được tính từ tổng so_luong, so_luong_qd trong poct1.
 * - Điều kiện nhóm: stt_rec0_pdn, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO).
 */
class AsReCalPO0
{
    /**
     * Gọi stored procedure asReCalPO0
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO0', $params);
    }
}