<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsReCalPO44Relate
 *
 * Stored procedure: asReCalPO44Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới PO4 (có lẽ là phiếu chi).
 * Procedure thực hiện hai công việc chính:
 * 1. Gọi asAPUpdTt_SoDuPo4 để cập nhật số dư trong bảng aptt (công nợ phải trả) liên quan đến phiếu chi PO4.
 * 2. Tính lại số dư tức thời (công nợ) của khách hàng liên quan đến phiếu chi này
 *    bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header phiếu chi (poph4).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của phiếu chi (PO4) cần cập nhật liên quan.
 * 
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asAPUpdTt_SoDuPo4 và asArRecalCustBalance.
 * 
 * Ví dụ gọi:
 * ```php
 * AsReCalPO44Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'PC001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure gọi asAPUpdTt_SoDuPo4(@pMa_cty, @pStt_rec) để cập nhật số dư công nợ phải trả (AP) liên quan đến phiếu chi PO4.
 * - Sau đó, lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng poph4 (header phiếu chi)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - PO4 có lẽ là phiếu chi (Payment Voucher) trong module Mua hàng (PO) hoặc Kế toán chi phí (CA).
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và công nợ phải trả (AP), đồng thời ảnh hưởng đến công nợ khách hàng (AR).
 */
class AsReCalPO44Relate
{
    /**
     * Gọi stored procedure asReCalPO44Relate
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asReCalPO44Relate', $params);
    }
}