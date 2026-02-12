<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARGetCT1
 * 
 * Stored procedure: asARGetCT1
 * Purpose: Lấy thông tin chi tiết phiếu công nợ phải thu (bảng ARCT1) theo mã công ty và số chứng từ.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3), default = NULL): Mã công ty. Nếu NULL thì tìm tất cả ('%').
 * - @pStt_rec (nvarchar(20), default = NULL): Số tham chiếu (stt_rec). Nếu NULL thì tìm tất cả ('%').
 * - @pStruct (nvarchar(1), default = '0'): Cấu trúc dữ liệu. Giá trị '0' (mặc định).
 * 
 * Kết quả trả về: Các dòng chi tiết phiếu công nợ phải thu với các thông tin:
 *   ma_cty, stt_rec, stt_rec0, stt_rec_hd, stt_rec_dh, so_hd, ngay_hd, so_dh, ngay_dh, ma_nt,
 *   tt_hd, tt_hd_nt, tien_tt, tien_tt_nt, tien_tt_qd, da_tt, da_tt_nt, du_hd, du_hd_nt,
 *   tk, ten_tk, dien_giai, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AR20230001',
 *     'pStruct' => '0',
 * ];
 * $result = AsARGetCT1::call($params);
 * ```
 */
class AsARGetCT1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetCT1', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStruct'  => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
