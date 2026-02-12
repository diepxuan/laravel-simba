<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsProcessSoPh5
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asProcessSoPh5', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            'pMode'  => $params['pMode'] ?? null,
            'pstt_rec'  => $params['pstt_rec'] ?? null,
        ], $connection);
    }
}