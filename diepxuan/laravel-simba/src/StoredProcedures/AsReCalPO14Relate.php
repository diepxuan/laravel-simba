<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO14Relate
 *
 * Stored procedure: asReCalPO14Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới PO2 (phiếu nhập).
 * Procedure thực hiện duyệt qua các phiếu đề nghị (stt_rec_pdn) liên kết với một phiếu nhập cụ thể (stt_rec)
 * và gọi asReCalPO0 để tính lại số liệu cho từng phiếu đề nghị đó.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của phiếu nhập (PO2) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalPO0 cho từng phiếu đề nghị liên quan.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO14Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'PN001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt qua các stt_rec_pdn từ bảng poct1 với điều kiện ma_cty = @pMa_cty và stt_rec = @pStt_rec.
 * - Mỗi stt_rec_pdn tìm được sẽ gọi asReCalPO0(@pMa_cty, @stt_rec_pdn) để tính lại số liệu cho phiếu đề nghị.
 * - Bảng poct1 là chi tiết đơn hàng, có lẽ chứa khóa ngoại stt_rec_pdn liên kết đến phiếu đề nghị.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và cụ thể là phiếu nhập (PO2).
 */
class AsReCalPO14Relate
{
    /**
     * Gọi stored procedure asReCalPO14Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO14Relate', $params);
    }
}