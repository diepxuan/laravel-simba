<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCODelDMPB
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCODelDMPB', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId'     => $params['pId'] ?? null,
            'pTk_pb'  => $params['pTk_pb'] ?? null,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
        ], $connection);
    }
}
