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

class AsGLRptBCT01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCT01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pThue_suat' => $params['pThue_suat'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMau_bc' => $params['pMau_bc'] ?? null
        ], $connection);
    }
}
