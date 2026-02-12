<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 10:57:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetPh5
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetPh5', [
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? '%',
            'pMa_ct'   => $params['pMa_ct'] ?? '',
            'pStruct'  => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
