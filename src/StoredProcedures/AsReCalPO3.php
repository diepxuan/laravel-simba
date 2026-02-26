<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:03:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsReCalPO3.
 *
 * Stored procedure: asReCalPO3
 * Mục đích: Tính và cập nhật lại số liệu cho một hóa đơn (purchase invoice).
 * Procedure thực hiện cập nhật số lượng đã xuất trả lại (sl_px, sl_px_qd) cho từng dòng chi tiết hóa đơn (poct3)
 * dựa trên tổng hợp dữ liệu từ bảng chi tiết phiếu xuất trả lại (poct5).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec_hd (string, bắt buộc): Số thứ tự bản ghi của hóa đơn (stt_rec_hd).
 *
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên bảng poct3.
 *
 * Ví dụ gọi:
 * ```php
 * AsReCalPO3::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec_hd' => 'HD001',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure sử dụng các bảng: poct3 (chi tiết hóa đơn/hợp đồng), poct5 (chi tiết phiếu xuất trả lại).
 * - Cột sl_px (số lượng đã xuất trả lại) và sl_px_qd (số lượng quy đổi đã xuất trả lại) được tính từ tổng so_luong, so_luong_qd trong poct5.
 * - Điều kiện nhóm: stt_rec0_hd, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Mua hàng (PO) và hóa đơn (PO3).
 */
class AsReCalPO3
{
    /**
     * Gọi stored procedure asReCalPO3.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalPO3', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
            'pma_cty'     => $params['pma_cty'] ?? null,
            'pstt_rec_hd' => $params['pstt_rec_hd'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asReCalPO3 with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec_hd = null, mixed $ma_cty = null, mixed $stt_rec_hd = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pStt_rec_hd' => $Stt_rec_hd,
            'pma_cty'     => $ma_cty,
            'pstt_rec_hd' => $stt_rec_hd,
        ];

        return self::call($params);
    }
}
