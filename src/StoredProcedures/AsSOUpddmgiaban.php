<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpddmgiaban
{
    /**
     * Call stored procedure asSOUpddmgiaban
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpddmgiaban', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pNgay_ad' => $params['pNgay_ad'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pGia_nt2' => $params['pGia_nt2'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpddmgiaban with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Ngay_ad
     * @param string $Ma_nt
     * @param float $Gia_nt2
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Ngay_ad = null, string $Ma_nt = null, float $Gia_nt2 = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pNgay_ad' => $Ngay_ad,
            'pMa_nt' => $Ma_nt,
            'pGia_nt2' => $Gia_nt2,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
