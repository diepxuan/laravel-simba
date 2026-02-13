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

class AsGLRptCTGS01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptCTGS01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ct1' => $params['pNgay_ct1'] ?? null,
            'pNgay_ct2' => $params['pNgay_ct2'] ?? null
        ], $connection);
    }
}
