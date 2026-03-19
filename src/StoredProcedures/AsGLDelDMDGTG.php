<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLDelDMDGTG
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelDMDGTG', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pLoai_dg' => $paramObj->pLoai_dg ?? null,
            'pTk_dgtg' => $paramObj->pTk_dgtg ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pSTT' => $paramObj->pSTT ?? null,
        ], $connection);
    }
}
