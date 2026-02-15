<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIUpddmngh
{
    /**
     * Call stored procedure asSIUpddmngh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpddmngh', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ngh' => $params['pMa_ngh'] ?? null,
            'pTen_ngh' => $params['pTen_ngh'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pkSd' => $params['pkSd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIUpddmngh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ngh
     * @param string $Ten_ngh
     * @param string $Ghi_chu
     * @param bool $kSd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ngh = null, string $Ten_ngh = null, string $Ghi_chu = null, bool $kSd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ngh' => $Ma_ngh,
            'pTen_ngh' => $Ten_ngh,
            'pGhi_chu' => $Ghi_chu,
            'pkSd' => $kSd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
