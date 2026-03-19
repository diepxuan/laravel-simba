<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsF5GLRptNKC07
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asF5GLRptNKC07', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'Ngay_ct1' => $paramObj->Ngay_ct1 ?? null,
            'Ngay_ct2' => $paramObj->Ngay_ct2 ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
        ], $connection);
    }
}
