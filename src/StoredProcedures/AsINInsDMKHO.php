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

class AsINInsDMKHO
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsDMKHO', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pTen_kho' => $paramObj->pTen_kho ?? null,
            'pKho_dl' => $paramObj->pKho_dl ?? null,
            'pTk_dl' => $paramObj->pTk_dl ?? null,
            'pStt_ntxt' => $paramObj->pStt_ntxt ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pNguoi_lh' => $paramObj->pNguoi_lh ?? null,
            'pTel' => $paramObj->pTel ?? null,
            'pFax' => $paramObj->pFax ?? null,
            'pEmail' => $paramObj->pEmail ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null,
        ], $connection);
    }
}
