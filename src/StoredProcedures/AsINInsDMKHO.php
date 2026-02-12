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

class AsINInsDMKHO
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsDMKHO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pTen_kho' => $params['pTen_kho'] ?? null,
            'pKho_dl' => $params['pKho_dl'] ?? null,
            'pTk_dl' => $params['pTk_dl'] ?? null,
            'pStt_ntxt' => $params['pStt_ntxt'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pNguoi_lh' => $params['pNguoi_lh'] ?? null,
            'pTel' => $params['pTel'] ?? null,
            'pFax' => $params['pFax'] ?? null,
            'pEmail' => $params['pEmail'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
