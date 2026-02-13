<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLGetBudget
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLGetBudget', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_tk' => $params['pMa_tk'] ?? null,
            'pMa_tk_du' => $params['pMa_tk_du'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pTtps_no_co' => $params['pTtps_no_co'] ?? null,
        ], $connection);
    }
}
