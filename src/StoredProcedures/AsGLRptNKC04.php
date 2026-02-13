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

class AsGLRptNKC04
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKC04', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pNgay_ct2' => $params['pNgay_ct2'] ?? null,
            'pDs_Tk_Pt' => $params['pDs_Tk_Pt'] ?? null,
            'pDs_Tk_Dt_Hh' => $params['pDs_Tk_Dt_Hh'] ?? null,
            'pDs_Tk_Dt_Tp' => $params['pDs_Tk_Dt_Tp'] ?? null,
            'pDs_Tk_Dt_Dv' => $params['pDs_Tk_Dt_Dv'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null
        ], $connection);
    }
}
