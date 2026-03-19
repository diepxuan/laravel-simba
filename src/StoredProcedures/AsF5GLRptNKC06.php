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

class AsF5GLRptNKC06
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asF5GLRptNKC06', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pNgay_ct1' => $paramObj->pNgay_ct1 ?? null,
            'pNgay_ct2' => $paramObj->pNgay_ct2 ?? null,
            'pMa_Nt' => $paramObj->pMa_Nt ?? null,
        ], $connection);
    }
}
