<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOUpdDMCP
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdDMCP', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_cp' => $params['pMa_cp'] ?? '',
            'pTen_cp' => $params['pTen_cp'] ?? '',
            'pTt_pb' => $params['pTt_pb'] ?? '',
            'pKsd' => $params['pKsd'] ?? '',
            'pLUser' => $params['pLUser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
