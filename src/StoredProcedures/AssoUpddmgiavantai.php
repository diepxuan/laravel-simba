<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AssoUpddmgiavantai
{
    /**
     * Call stored procedure assoUpddmgiavantai
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('assoUpddmgiavantai', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_td' => $params['pMa_td'] ?? null,
            'pMa_pt' => $params['pMa_pt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pGia_nt' => $params['pGia_nt'] ?? null,
            'pGia' => $params['pGia'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure assoUpddmgiavantai with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_td
     * @param string $Ma_pt
     * @param string $Ma_nt
     * @param float $Gia_nt
     * @param float $Gia
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_td = null, string $Ma_pt = null, string $Ma_nt = null, float $Gia_nt = null, float $Gia = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_td' => $Ma_td,
            'pMa_pt' => $Ma_pt,
            'pMa_nt' => $Ma_nt,
            'pGia_nt' => $Gia_nt,
            'pGia' => $Gia,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
