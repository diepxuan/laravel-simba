<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsCAUpdCDKU
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdCDKU', [
            'pMa_cty'    => $paramObj->pMa_cty ?? null,
            'pNam'       => $paramObj->pNam ?? null,
            'pMa_ku'     => $paramObj->pMa_ku ?? null,
            'pTk'        => $paramObj->pTk ?? null,
            'pMa_nt'     => $paramObj->pMa_nt ?? null,
            'pNgay_ku'   => $paramObj->pNgay_ku ?? null,
            'pNgay_tt'   => $paramObj->pNgay_tt ?? null,
            'pDa_vay'    => $paramObj->pDa_vay ?? null,
            'pDa_vay_nt' => $paramObj->pDa_vay_nt ?? null,
            'pDa_tt'     => $paramObj->pDa_tt ?? null,
            'pDa_tt_nt'  => $paramObj->pDa_tt_nt ?? null,
            'pLUser'     => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
