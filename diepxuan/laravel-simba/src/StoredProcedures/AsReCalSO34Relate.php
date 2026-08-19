<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalSO34Relate
 *
 * Stored procedure: asReCalSO34Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới SO3 (hóa đơn).
 * Procedure thực hiện ba công việc chính:
 * 1. Duyệt qua các phiếu xuất (stt_rec_px) liên kết với một hóa đơn SO3 cụ thể (stt_rec)
 *    và gọi asReCalSo2 để tính lại số liệu cho từng phiếu xuất đó.
 * 2. Duyệt qua các đơn hàng (stt_rec_dh) liên kết với cùng hóa đơn
 *    với điều kiện stt_rec_dh <> '' và stt_rec_px = '' (có lẽ là đơn hàng chưa xuất kho)
 *    và gọi asReCalSo1 để tính lại số liệu cho từng đơn hàng đó.
 * 3. Tính lại số dư tức thời (công nợ) của khách hàng liên quan đến hóa đơn này
 *    bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header hóa đơn (soph3).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của hóa đơn (SO3) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalSo2, asReCalSo1 và asArRecalCustBalance.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalSO34Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'HD003',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng hai cursor:
 *   + Cursor stt_rec_px: duyệt qua các stt_rec_px từ bảng soct3 với điều kiện:
 *     ma_cty = @pMa_cty, stt_rec = @pStt_rec.
 *   + Cursor stt_rec_dh: duyệt qua các stt_rec_dh từ bảng soct3 với điều kiện:
 *     ma_cty = @pMa_cty, stt_rec = @pStt_rec, stt_rec_dh <> '', stt_rec_px = ''.
 * - Mỗi stt_rec_px tìm được sẽ gọi asReCalSo2(@pMa_cty, @stt_rec_px) để tính lại số liệu cho phiếu xuất.
 * - Mỗi stt_rec_dh tìm được sẽ gọi asReCalSo1(@pMa_cty, @stt_rec_dh) để tính lại số liệu cho đơn hàng.
 * - Sau đó, lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng soph3 (header hóa đơn SO3)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - Bảng soct3 là chi tiết hóa đơn, có lẽ chứa khóa ngoại stt_rec_px liên kết đến phiếu xuất và stt_rec_dh liên kết đến đơn hàng.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Bán hàng (SO) và hóa đơn (SO3), đồng thời ảnh hưởng đến công nợ khách hàng (AR).
 */
class AsReCalSO34Relate
{
    /**
     * Gọi stored procedure asReCalSO34Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalSO34Relate', $params);
    }
}