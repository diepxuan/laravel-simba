<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 11:54:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPoGetCa4Po.
 *
 * Stored procedure: asPOGetCA4PO
 * Mục đích: Lấy thông tin chứng từ thanh toán (Chi/Báo nợ) từ phân hệ mua hàng.
 * Procedure truy vấn thông tin chứng từ thanh toán liên quan đến hóa đơn mua hàng.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (3 ký tự) - tuy nhiên trong điều kiện hiện tại bị comment.
 * - @pStt_rec_hd (string, bắt buộc): Số tham chiếu của hóa đơn (stt_rec_hd).
 *
 * Giá trị trả về:
 * - Resultset gồm các cột: stt_rec, ma_ct, ngay_ct, so_ct, ma_nt, ty_gia, ma_kh, dia_chi, nguoi_gd, dien_giai, tk_co, tk, ps_no, ps_no_nt, ma_hd, ma_bp, ma_phi, ma_spct, ma_lo.
 * - Dữ liệu từ hai bảng CAPH2 và CaCt2 join với điều kiện mã công ty và số tham chiếu hóa đơn.
 *
 * Ví dụ gọi:
 * ```php
 * $results = AsPoGetCa4Po::call([
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'PO',
 *     'pStt_rec_hd' => 'HD202500001',
 * ]);
 * foreach ($results as $row) {
 *     // Xử lý từng dòng
 * }
 * ```
 *
 * Lưu ý:
 * - Điều kiện `a.ma_ct = @pMa_ct` hiện đang bị comment trong procedure, có thể sử dụng sau.
 * - Procedure chỉ lấy các chứng từ thanh toán liên quan đến hóa đơn mua hàng cụ thể.
 */
class AsPOGetCA4PO extends StoredProcedure
{
    public const NAME = 'asPOGetCA4PO';

    /**
     * Call stored procedure asPOGetCA4PO.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'     => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_ct'      => $params['pMa_ct'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
        ], $params));
    }

    /**
     * Call stored procedure asPOGetCA4PO with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_ct = null, ?string $Stt_rec_hd = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pMa_ct'      => $Ma_ct,
            'pStt_rec_hd' => $Stt_rec_hd,
        ];

        return self::call($params);
    }
}
