<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:04:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsCT3
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsCT3', [
            'pMa_cty'        => $params['pMa_cty'] ?? null,
            'pStt_rec'       => $params['pStt_rec'] ?? null,
            'pStt_rec0'      => $params['pStt_rec0'] ?? null,
            'pStt_rec_hd'    => $params['pStt_rec_hd'] ?? null,
            'pStt_rec_dh'    => $params['pStt_rec_dh'] ?? null,
            'pSo_hd'         => $params['pSo_hd'] ?? null,
            'pNgay_hd'       => $params['pNgay_hd'] ?? null,
            'pMa_nt'         => $params['pMa_nt'] ?? null,
            'pTien_tt'       => $params['pTien_tt'] ?? 0.0,
            'pTien_tt_nt'    => $params['pTien_tt_nt'] ?? 0.0,
            'pTien_tt_qd'    => $params['pTien_tt_qd'] ?? 0.0,
            'pTt_hd'         => $params['pTt_hd'] ?? 0.0,
            'pTt_hd_nt'      => $params['pTt_hd_nt'] ?? 0.0,
            'pTk'            => $params['pTk'] ?? null,
            'pDien_giai'     => $params['pDien_giai'] ?? '',
            'pMa_lo'         => $params['pMa_lo'] ?? '',
            'pMa_bp'         => $params['pMa_bp'] ?? '',
            'pMa_hd'         => $params['pMa_hd'] ?? '',
            'pMa_phi'        => $params['pMa_phi'] ?? '',
            'pMa_spct'       => $params['pMa_spct'] ?? '',
        ], $connection);
    }
}
