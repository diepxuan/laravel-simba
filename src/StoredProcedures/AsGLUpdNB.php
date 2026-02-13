<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLUpdNB
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdNB', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pPs_co' => $params['pPs_co'] ?? null,
            'pPs_co_nt' => $params['pPs_co_nt'] ?? null,
            'pPs_no' => $params['pPs_no'] ?? null,
            'pPs_no_nt' => $params['pPs_no_nt'] ?? null,
            'pLUser' => $params['pLUser'] ?? null
        ], $connection);
    }
}
