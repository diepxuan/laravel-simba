<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsDMHHKM
{
    /**
     * Call stored procedure asSOInsDMHHKM
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsDMHHKM', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_km' => $params['pMa_km'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pLoai_km' => $params['pLoai_km'] ?? null,
            'pSl_km' => $params['pSl_km'] ?? null,
            'pMuc_km' => $params['pMuc_km'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOInsDMHHKM with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_km
     * @param string $Ma_vt
     * @param string $Loai_km
     * @param float $Sl_km
     * @param float $Muc_km
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_km = null, string $Ma_vt = null, string $Loai_km = null, float $Sl_km = null, float $Muc_km = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_km' => $Ma_km,
            'pMa_vt' => $Ma_vt,
            'pLoai_km' => $Loai_km,
            'pSl_km' => $Sl_km,
            'pMuc_km' => $Muc_km,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
