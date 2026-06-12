<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO34Relate
 *
 * Stored procedure: asReCalPO34Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới PO3 (hóa đơn).
 * Procedure thực hiện ba công việc chính:
 * 1. Duyệt qua các phiếu nhập (stt_rec_pn) liên kết với một hóa đơn cụ thể (stt_rec)
 *    và gọi asReCalPO2 để tính lại số liệu cho từng phiếu nhập đó.
 * 2. Duyệt qua các đơn hàng (stt_rec_dh) liên kết với cùng hóa đơn
 *    và gọi asReCalPO1 để tính lại số liệu cho từng đơn hàng đó.
 * 3. Tính lại số dư tức thời (công nợ) của khách hàng liên quan đến hóa đơn này
 *    bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header hóa đơn (poph3).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của hóa đơn (PO3) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalPO2, asReCalPO1 và asArRecalCustBalance.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO34Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'HD001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng hai cursor:
 *   + Cursor stt_rec_pn: duyệt qua các stt_rec_pn từ bảng poct3 với điều kiện:
 *     ma_cty = @pMa_cty, stt_rec = @pStt_rec, stt_rec_pn <> '' (phiếu nhập không rỗng).
 *   + Cursor stt_rec_dh: duyệt qua các stt_rec_dh từ bảng poct3 với điều kiện:
 *     ma_cty = @pMa_cty, stt_rec = @pStt_rec, stt_rec_dh <> '' (đơn hàng không rỗng).
 * - Mỗi stt_rec_pn tìm được sẽ gọi asReCalPO2(@pMa_cty, @stt_rec_pn) để tính lại số liệu cho phiếu nhập.
 * - Mỗi stt_rec_dh tìm được sẽ gọi asReCalPO1(@pMa_cty, @stt_rec_dh) để tính lại số liệu cho đơn hàng.
 * - Sau đó, lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng poph3 (header hóa đơn)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - Bảng poct3 là chi tiết hóa đơn, có lẽ chứa khóa ngoại stt_rec_pn liên kết đến phiếu nhập và stt_rec_dh liên kết đến đơn hàng.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và hóa đơn (PO3), đồng thời ảnh hưởng đến công nợ khách hàng (AR).
 */
class AsReCalPO34Relate
{
    /**
     * Gọi stored procedure asReCalPO34Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO34Relate', $params);
    }
}