<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class ZasINDelCT7
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('zasINDelCT7', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec'  => $paramObj->pStt_rec ?? null,
            'pStt_rec0'  => $paramObj->pStt_rec0 ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
