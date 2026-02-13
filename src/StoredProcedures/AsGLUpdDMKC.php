<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLUpdDMKC
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdDMKC', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pModuleID' => $params['pModuleID'] ?? null,
            'pTen_bt' => $params['pTen_bt'] ?? null,
            'pLoai_kc' => $params['pLoai_kc'] ?? null,
            'pKc_ps' => $params['pKc_ps'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
            'pKc_spct' => $params['pKc_spct'] ?? null,
            'pKc_bp' => $params['pKc_bp'] ?? null,
            'pso_ct' => $params['pso_ct'] ?? null,
            'pKc_hd' => $params['pKc_hd'] ?? null,
            'pKc_phi' => $params['pKc_phi'] ?? null,
            'pKc_dt_ps' => $params['pKc_dt_ps'] ?? null,
            'pKc_lo' => $params['pKc_lo'] ?? null,
            'pkSd' => $params['pkSd'] ?? null,
            'pCUser' => $params['pCUser'] ?? null,
            'pOld_Tk' => $params['pOld_Tk'] ?? null,
            'pOld_Tk_du' => $params['pOld_Tk_du'] ?? null
        ], $connection);
    }
}
