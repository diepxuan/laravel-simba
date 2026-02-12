<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCAUpdTTHU
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdTTHU', [
            'pMa_cty'         => $params['pMa_cty'] ?? null,
            'pStt_rec'        => $params['pStt_rec'] ?? null,
            'pMa_ct'          => $params['pMa_ct'] ?? null,
            'pNgay_ct'        => $params['pNgay_ct'] ?? null,
            'pSo_ct'          => $params['pSo_ct'] ?? null,
            'pMa_ct_tt'       => $params['pMa_ct_tt'] ?? null,
            'pStt_rec_tt'     => $params['pStt_rec_tt'] ?? null,
            'pNgay_ct_tt'     => $params['pNgay_ct_tt'] ?? null,
            'pSo_ct_tt'       => $params['pSo_ct_tt'] ?? null,
            'pMa_KH'          => $params['pMa_KH'] ?? null,
            'pTk_tu'          => $params['pTk_tu'] ?? null,
            'pMa_nt'          => $params['pMa_nt'] ?? null,
            'pTy_gia'         => $params['pTy_gia'] ?? null,
            'pTien_pc'        => $params['pTien_pc'] ?? null,
            'pTien_pc_nt'     => $params['pTien_pc_nt'] ?? null,
            'pTien_da_tt'     => $params['pTien_da_tt'] ?? null,
            'pTien_da_tt_nt'  => $params['pTien_da_tt_nt'] ?? null,
            'pTat_toan'       => $params['pTat_toan'] ?? null,
            'pDien_giai'      => $params['pDien_giai'] ?? null,
            'pLUser'          => $params['pLUser'] ?? null,
        ], $connection);
    }
}
