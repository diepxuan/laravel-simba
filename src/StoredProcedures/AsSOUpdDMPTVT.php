<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdDMPTVT
{
    /**
     * Call stored procedure asSOUpdDMPTVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdDMPTVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_pt' => $params['pMa_pt'] ?? null,
            'pTen_pt' => $params['pTen_pt'] ?? null,
            'pBien_so' => $params['pBien_so'] ?? null,
            'pNguoi_dk' => $params['pNguoi_dk'] ?? null,
            'pCao' => $params['pCao'] ?? null,
            'pDai' => $params['pDai'] ?? null,
            'pRong' => $params['pRong'] ?? null,
            'pThe_tich' => $params['pThe_tich'] ?? null,
            'pTrong_tai' => $params['pTrong_tai'] ?? null,
            'pTg_xep' => $params['pTg_xep'] ?? null,
            'pTg_do' => $params['pTg_do'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdDMPTVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_pt
     * @param string $Ten_pt
     * @param string $Bien_so
     * @param string $Nguoi_dk
     * @param float $Cao
     * @param float $Dai
     * @param float $Rong
     * @param float $The_tich
     * @param float $Trong_tai
     * @param float $Tg_xep
     * @param float $Tg_do
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_pt = null, string $Ten_pt = null, string $Bien_so = null, string $Nguoi_dk = null, float $Cao = null, float $Dai = null, float $Rong = null, float $The_tich = null, float $Trong_tai = null, float $Tg_xep = null, float $Tg_do = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_pt' => $Ma_pt,
            'pTen_pt' => $Ten_pt,
            'pBien_so' => $Bien_so,
            'pNguoi_dk' => $Nguoi_dk,
            'pCao' => $Cao,
            'pDai' => $Dai,
            'pRong' => $Rong,
            'pThe_tich' => $The_tich,
            'pTrong_tai' => $Trong_tai,
            'pTg_xep' => $Tg_xep,
            'pTg_do' => $Tg_do,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
