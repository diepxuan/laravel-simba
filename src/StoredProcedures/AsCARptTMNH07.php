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

class AsCARptTMNH07
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH07', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pTk'  => $paramObj->pTk ?? null,
            'pMa_ku'  => $paramObj->pMa_ku ?? null,
            'pNgay_ctk'  => $paramObj->pNgay_ctk ?? null,
            'pNgay_cdk'  => $paramObj->pNgay_cdk ?? null,
            'pMa_nt'  => $paramObj->pMa_nt ?? null,
        ], $connection);
    }
}