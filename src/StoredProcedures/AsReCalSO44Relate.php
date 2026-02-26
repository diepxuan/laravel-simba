<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:13:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsReCalSO44Relate.
 *
 * Stored procedure: asReCalSO44Relate
 * Mục đích: Cập nhật lại số liệu cho các đối tượng liên quan tới SO4 (phiếu thu).
 * Procedure thực hiện hai công việc chính:
 * 1. Duyệt qua các cặp phiếu xuất (stt_rec_px) và hóa đơn (stt_rec_hd) liên kết với một phiếu thu cụ thể (stt_rec)
 *    và gọi các procedure tương ứng để tính lại số liệu:
 *    - Nếu stt_rec_hd <> '': gọi asReCalSo3 (tính lại số liệu hóa đơn) và asArUpdTt_SoDuSo3 (cập nhật số dư công nợ cho hóa đơn).
 *    - Nếu stt_rec_px <> '': gọi asReCalSo2 (tính lại số liệu phiếu xuất).
 * 2. Tính lại số dư tức thời (công nợ) của khách hàng liên quan đến phiếu thu này
 *    bằng cách gọi asArRecalCustBalance với mã khách hàng và năm lấy từ header phiếu thu (soph4).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi của phiếu thu (SO4) cần cập nhật liên quan.
 *
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện gọi asReCalSo3, asArUpdTt_SoDuSo3, asReCalSo2 và asArRecalCustBalance.
 *
 * Ví dụ gọi:
 * ```php
 * AsReCalSO44Relate::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec' => 'PT001',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure sử dụng cursor recal duyệt qua các cặp (stt_rec_px, stt_rec_hd) từ bảng soct4 với điều kiện:
 *   ma_cty = @pMa_cty, stt_rec = @pStt_rec.
 * - Với mỗi bản ghi:
 *   + Nếu stt_rec_hd <> '': gọi asReCalSo3(@pMa_cty, @Stt_rec_hd) và asArUpdTt_SoDuSo3(@pMa_cty, @Stt_rec_hd).
 *   + Nếu stt_rec_px <> '': gọi asReCalSo2(@pMa_cty, @Stt_rec_px).
 * - Sau đó, lấy năm (year(ngay_ct)) và mã khách hàng (ma_kh) từ bảng soph4 (header phiếu thu)
 *   với cùng điều kiện ma_cty và stt_rec.
 * - Gọi asArRecalCustBalance(@pMa_cty, @ma_kh, @nam) để tính lại số dư công nợ của khách hàng trong năm đó.
 * - Bảng soct4 là chi tiết phiếu thu, có lẽ chứa khóa ngoại stt_rec_px liên kết đến phiếu xuất và stt_rec_hd liên kết đến hóa đơn.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Bán hàng (SO) và phiếu thu (SO4), đồng thời ảnh hưởng đến công nợ khách hàng (AR).
 */
class AsReCalSO44Relate
{
    /**
     * Gọi stored procedure asReCalSO44Relate.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalSO44Relate', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pma_cty'  => $params['pma_cty'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asReCalSO44Relate with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, mixed $ma_cty = null, mixed $stt_rec = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pma_cty'  => $ma_cty,
            'pstt_rec' => $stt_rec,
        ];

        return self::call($params);
    }
}
