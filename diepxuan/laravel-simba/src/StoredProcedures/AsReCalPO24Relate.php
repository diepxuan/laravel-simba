<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO24Relate
 *
 * Stored procedure: asReCalPO24Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới PO2 (phiếu nhập).
 * Procedure thực hiện hai công việc chính:
 * 1. Duyệt qua các đơn hàng (stt_rec_dh) liên kết với một phiếu nhập cụ thể (stt_rec)
 *    và gọi asReCalPO1 để tính lại số liệu cho từng đơn hàng đó.
 * 2. Tính lại số dư tức thời (công nợ) của khách hàng liên quan đến phiếu nhập này
 *    bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header phiếu nhập (poph2).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của phiếu nhập (PO2) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalPO1 và asArRecalCustBalance.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO24Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'PN001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt qua các stt_rec_dh từ bảng poct2 với điều kiện:
 *   ma_cty = @pMa_cty, stt_rec = @pStt_rec, stt_rec_dh <> '' (đơn hàng không rỗng).
 * - Mỗi stt_rec_dh tìm được sẽ gọi asReCalPO1(@pMa_cty, @stt_rec_dh) để tính lại số liệu cho đơn hàng.
 * - Sau đó, lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng poph2 (header phiếu nhập)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - Bảng poct2 là chi tiết phiếu nhập, có lẽ chứa khóa ngoại stt_rec_dh liên kết đến đơn hàng.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và phiếu nhập (PO2), đồng thời ảnh hưởng đến công nợ khách hàng (AR).
 */
class AsReCalPO24Relate
{
    /**
     * Gọi stored procedure asReCalPO24Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO24Relate', $params);
    }
}