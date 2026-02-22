<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO64Relate
 *
 * Stored procedure: asReCalPO64Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới PO6 (hóa đơn dịch vụ).
 * Procedure thực hiện tính lại số dư tức thời (công nợ) của khách hàng liên quan đến hóa đơn dịch vụ PO6
 * bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header hóa đơn dịch vụ (poph6).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của hóa đơn dịch vụ (PO6) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asArRecalCustBalance.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO64Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'HDDV001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng poph6 (header hóa đơn dịch vụ)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - PO6 có lẽ là hóa đơn dịch vụ (Service Invoice) trong module Mua hàng (PO) hoặc Bán hàng (SO).
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và công nợ khách hàng (AR).
 */
class AsReCalPO64Relate
{
    /**
     * Gọi stored procedure asReCalPO64Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO64Relate', $params);
    }
}