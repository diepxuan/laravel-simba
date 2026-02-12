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

class AsDelreportDrilldownInfo
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asDelreportDrilldownInfo', [
            'pMenuid'  => $params['pMenuid'] ?? null,
            'pMa_mau'  => $params['pMa_mau'] ?? null,
            'pPress_key_name'  => $params['pPress_key_name'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}