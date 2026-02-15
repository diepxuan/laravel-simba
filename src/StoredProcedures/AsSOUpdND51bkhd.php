<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdND51bkhd
{
    /**
     * Call stored procedure asSOUpdND51bkhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdND51bkhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tb' => $params['pMa_tb'] ?? null,
            'pNgay_tb' => $params['pNgay_tb'] ?? null,
            'pTen_cty' => $params['pTen_cty'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pDai_dien' => $params['pDai_dien'] ?? null,
            'pLdate' => $params['pLdate'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdND51bkhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param string $Ngay_tb
     * @param string $Ten_cty
     * @param string $Ma_thue
     * @param string $Dai_dien
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Ngay_tb = null, string $Ten_cty = null, string $Ma_thue = null, string $Dai_dien = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pNgay_tb' => $Ngay_tb,
            'pTen_cty' => $Ten_cty,
            'pMa_thue' => $Ma_thue,
            'pDai_dien' => $Dai_dien,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
