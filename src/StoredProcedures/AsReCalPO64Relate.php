<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:05:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsReCalPO64Relate.
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
     * Gọi stored procedure asReCalPO64Relate.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalPO64Relate', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asReCalPO64Relate with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
        ];

        return self::call($params);
    }
}
