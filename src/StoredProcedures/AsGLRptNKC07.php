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

class AsGLRptNKC07
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKC07', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'Ngay_ct1' => $paramObj->Ngay_ct1 ?? null,
            'Ngay_ct2' => $paramObj->Ngay_ct2 ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pNhom_tk' => $paramObj->pNhom_tk ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null
        ], $connection);
    }
}
