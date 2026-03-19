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
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLRptNKCTSoCai
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKCTSoCai', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pNgay1'  => $paramObj->pNgay1 ?? null,
            'pNgay2'  => $paramObj->pNgay2 ?? null,
            'pTk'  => $paramObj->pTk ?? null,
            'pThang1'  => $paramObj->pThang1 ?? null,
            'pThang2'  => $paramObj->pThang2 ?? null,
            'pNam'  => $paramObj->pNam ?? null,
        ], $connection);
    }
}