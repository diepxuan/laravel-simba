<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARDelTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARDelTT', [
            'pMa_cty'      => $params['pMa_cty'] ?? null,
            'pStt_rec'     => $params['pStt_rec'] ?? null,
            'pStt_rec_pt'  => $params['pStt_rec_pt'] ?? null,
        ], $connection);
    }
}