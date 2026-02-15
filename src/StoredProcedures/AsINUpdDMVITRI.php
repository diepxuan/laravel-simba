<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINUpdDMVITRI
{
    /**
     * Call stored procedure asINUpdDMVITRI
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdDMVITRI', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pTen_vitri' => $params['pTen_vitri'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdDMVITRI with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ten_vitri
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ten_vitri = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pTen_vitri' => $Ten_vitri,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
