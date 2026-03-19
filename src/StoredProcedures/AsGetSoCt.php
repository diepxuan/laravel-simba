<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 13:22:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;

class AsGetSoCt
{
    public static function call(array $params): string
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetSoCt', [
            'pMa_Cty'  => $paramObj->pMa_Cty ?? SModel::CTY,
            'pMa_ct'   => $paramObj->pMa_ct ?? null,
            'pNgay_Ct' => $paramObj->pNgay_Ct ?? now()->toDateString(),
            'pSo_Ct'   => $paramObj->pSo_Ct ?? null,
        ], $connection)->first()->SoCt;
    }
}
