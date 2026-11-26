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

class AsGLRptBCPT03
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCPT03', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pLoai' => $paramObj->pLoai ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pSo_ky' => $paramObj->pSo_ky ?? null,
            'pMau' => $paramObj->pMau ?? null
        ], $connection);
    }
}
