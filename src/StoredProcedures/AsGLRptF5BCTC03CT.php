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

class AsGLRptF5BCTC03CT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptF5BCTC03CT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pNo_co' => $paramObj->pNo_co ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null
        ], $connection);
    }
}
