<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARInsCT3
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsCT3', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pStt_rec0'     => $params['pStt_rec0'] ?? null,
            'pStt_rec_hd'   => $params['pStt_rec_hd'] ?? null,
            'pStt_rec_dh'   => $params['pStt_rec_dh'] ?? null,
            'pSo_hd'        => $params['pSo_hd'] ?? null,
            'pNgay_hd'      => $params['pNgay_hd'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTien_tt'      => $params['pTien_tt'] ?? null,
            'pTien_tt_nt'   => $params['pTien_tt_nt'] ?? null,
            'pTien_tt_qd'   => $params['pTien_tt_qd'] ?? null,
            'pTt_hd'        => $params['pTt_hd'] ?? null,
            'pTt_hd_nt'     => $params['pTt_hd_nt'] ?? null,
            'pTk'           => $params['pTk'] ?? null,
            'pDien_giai'    => $params['pDien_giai'] ?? null,
            'pMa_lo'        => $params['pMa_lo'] ?? null,
            'pMa_bp'        => $params['pMa_bp'] ?? null,
            'pMa_hd'        => $params['pMa_hd'] ?? null,
            'pMa_phi'       => $params['pMa_phi'] ?? null,
            'pMa_spct'      => $params['pMa_spct'] ?? null,
        ], $connection);
    }
}