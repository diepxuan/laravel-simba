<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:05:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsReCalPO84Relate.
 *
 * Stored procedure: asReCalPO84Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới PO8 (hóa đơn).
 * Procedure thực hiện hai công việc chính:
 * 1. Duyệt qua các phiếu nhập (stt_rec_pn) liên kết với một hóa đơn PO8 cụ thể (stt_rec)
 *    và gọi asReCalPO2 để tính lại số liệu cho từng phiếu nhập đó.
 * 2. Tính lại số dư tức thời (công nợ) của khách hàng liên quan đến hóa đơn này
 *    bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header hóa đơn (poph8).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của hóa đơn (PO8) cần cập nhật liên quan.
 *
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalPO2 và asArRecalCustBalance.
 *
 * Ví dụ gọi:
 * ```php
 * AsReCalPO84Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'HD008',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure sử dụng cursor stt_rec_pn: duyệt qua các stt_rec_pn từ bảng poct8 với điều kiện:
 *   ma_cty = @pMa_cty, stt_rec = @pStt_rec.
 * - Mỗi stt_rec_pn tìm được sẽ gọi asReCalPO2(@pMa_cty, @stt_rec_pn) để tính lại số liệu cho phiếu nhập.
 * - Sau đó, lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng poph8 (header hóa đơn PO8)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - PO8 có lẽ là một loại hóa đơn khác trong module Mua hàng (PO) hoặc Bán hàng (SO).
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và công nợ khách hàng (AR).
 */
class AsReCalPO84Relate
{
    /**
     * Gọi stored procedure asReCalPO84Relate.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalPO84Relate', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pma_cty'  => $params['pma_cty'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asReCalPO84Relate with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pma_cty'  => $ma_cty,
        ];

        return self::call($params);
    }
}
