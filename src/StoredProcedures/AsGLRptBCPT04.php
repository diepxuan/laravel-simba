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

class AsGLRptBCPT04
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCPT04', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pThang1' => $paramObj->pThang1 ?? null,
            'pThang2' => $paramObj->pThang2 ?? null,
            'pQuyThang' => $paramObj->pQuyThang ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null
        ], $connection);
    }
}
