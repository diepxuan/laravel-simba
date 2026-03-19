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
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOUpdDMCP
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdDMCP', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pMa_cp' => $paramObj->pMa_cp ?? '',
            'pTen_cp' => $paramObj->pTen_cp ?? '',
            'pTt_pb' => $paramObj->pTt_pb ?? '',
            'pKsd' => $paramObj->pKsd ?? '',
            'pLUser' => $paramObj->pLUser ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
