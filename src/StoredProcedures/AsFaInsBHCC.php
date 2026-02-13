<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsFaInsBHCC
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaInsBHCC', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_cc' => $params['pMa_cc'] ?? null,
            'pstt_rec' => $params['pstt_rec'] ?? null,
            'pstt_rec0' => $params['pstt_rec0'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pTen_cc' => $params['pTen_cc'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pDon_gia' => $params['pDon_gia'] ?? null,
            'pNgay_giam' => $params['pNgay_giam'] ?? null,
            'pmoduleid' => $params['pmoduleid'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'pTk_cp' => $params['pTk_cp'] ?? null,
            'pTk_cc' => $params['pTk_cc'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pGt_da_Kh' => $params['pGt_da_Kh'] ?? null,
        ], $connection);
    }
}
