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
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLUpdCdTk
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdCdTk', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pDu_No_Nt00' => $paramObj->pDu_No_Nt00 ?? null,
            'pDu_Co_Nt00' => $paramObj->pDu_Co_Nt00 ?? null,
            'pDu_No00' => $paramObj->pDu_No00 ?? null,
            'pDu_Co00' => $paramObj->pDu_Co00 ?? null,
            'pDu_No_Nt' => $paramObj->pDu_No_Nt ?? null,
            'pDu_Co_Nt' => $paramObj->pDu_Co_Nt ?? null,
            'pDu_No' => $paramObj->pDu_No ?? null,
            'pDu_Co' => $paramObj->pDu_Co ?? null,
            'pLUser' => $paramObj->pLUser ?? null
        ], $connection);
    }
}
