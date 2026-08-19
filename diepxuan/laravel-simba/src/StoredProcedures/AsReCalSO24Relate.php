<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalSO24Relate
 *
 * Stored procedure: asReCalSO24Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới SO2 (phiếu xuất).
 * Procedure thực hiện duyệt qua các đơn hàng (stt_rec_dh) liên kết với một phiếu xuất cụ thể (stt_rec)
 * và gọi asReCalSo1 để tính lại số liệu cho từng đơn hàng đó.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của phiếu xuất (SO2) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalSo1 cho từng đơn hàng liên quan.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalSO24Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'PX001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt qua các stt_rec_dh từ bảng soct2 với điều kiện:
 *   ma_cty = @pMa_cty, stt_rec = @pStt_rec.
 * - Mỗi stt_rec_dh tìm được sẽ gọi asReCalSo1(@pMa_cty, @stt_rec_dh) để tính lại số liệu cho đơn hàng.
 * - Bảng soct2 là chi tiết phiếu xuất, có lẽ chứa khóa ngoại stt_rec_dh liên kết đến đơn hàng.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Bán hàng (SO) và phiếu xuất (SO2).
 */
class AsReCalSO24Relate
{
    /**
     * Gọi stored procedure asReCalSO24Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalSO24Relate', $params);
    }
}