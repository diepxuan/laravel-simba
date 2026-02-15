<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSoUpdCk
{
    /**
     * Call stored procedure asSoUpdCk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoUpdCk', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pVt_nhomvt' => $params['pVt_nhomvt'] ?? null,
            'pKh_nhomkh' => $params['pKh_nhomkh'] ?? null,
            'pSl_ds' => $params['pSl_ds'] ?? null,
            'pTl_gt' => $params['pTl_gt'] ?? null,
            'pTl_sl_ds' => $params['pTl_sl_ds'] ?? null,
            'pma_kyck' => $params['pma_kyck'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pGt0' => $params['pGt0'] ?? null,
            'pGt1' => $params['pGt1'] ?? null,
            'pCk1' => $params['pCk1'] ?? null,
            'pGt2' => $params['pGt2'] ?? null,
            'pCk2' => $params['pCk2'] ?? null,
            'pGt3' => $params['pGt3'] ?? null,
            'pCk3' => $params['pCk3'] ?? null,
            'pGt4' => $params['pGt4'] ?? null,
            'pCk4' => $params['pCk4'] ?? null,
            'pGt5' => $params['pGt5'] ?? null,
            'pCk5' => $params['pCk5'] ?? null,
            'pGt6' => $params['pGt6'] ?? null,
            'pCk6' => $params['pCk6'] ?? null,
            'pGt7' => $params['pGt7'] ?? null,
            'pCk7' => $params['pCk7'] ?? null,
            'pGt8' => $params['pGt8'] ?? null,
            'pCk8' => $params['pCk8'] ?? null,
            'pGt9' => $params['pGt9'] ?? null,
            'pCk9' => $params['pCk9'] ?? null,
            'pGt10' => $params['pGt10'] ?? null,
            'pCk10' => $params['pCk10'] ?? null,
            'pGt11' => $params['pGt11'] ?? null,
            'pCk11' => $params['pCk11'] ?? null,
            'pGt12' => $params['pGt12'] ?? null,
            'pCk12' => $params['pCk12'] ?? null,
            'pGt13' => $params['pGt13'] ?? null,
            'pCk13' => $params['pCk13'] ?? null,
            'pGt14' => $params['pGt14'] ?? null,
            'pCk14' => $params['pCk14'] ?? null,
            'pGt15' => $params['pGt15'] ?? null,
            'pCk15' => $params['pCk15'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSoUpdCk with named parameters
     *
     * @param string $Ma_cty
     * @param string $Vt_nhomvt
     * @param string $Kh_nhomkh
     * @param string $Sl_ds
     * @param string $Tl_gt
     * @param string $Tl_sl_ds
     * @param string $ma_kyck
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param float $Gt0
     * @param float $Gt1
     * @param float $Ck1
     * @param float $Gt2
     * @param float $Ck2
     * @param float $Gt3
     * @param float $Ck3
     * @param float $Gt4
     * @param float $Ck4
     * @param float $Gt5
     * @param float $Ck5
     * @param float $Gt6
     * @param float $Ck6
     * @param float $Gt7
     * @param float $Ck7
     * @param float $Gt8
     * @param float $Ck8
     * @param float $Gt9
     * @param float $Ck9
     * @param float $Gt10
     * @param float $Ck10
     * @param float $Gt11
     * @param float $Ck11
     * @param float $Gt12
     * @param float $Ck12
     * @param float $Gt13
     * @param float $Ck13
     * @param float $Gt14
     * @param float $Ck14
     * @param float $Gt15
     * @param float $Ck15
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Vt_nhomvt = null, string $Kh_nhomkh = null, string $Sl_ds = null, string $Tl_gt = null, string $Tl_sl_ds = null, string $ma_kyck = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kh = null, string $Ma_nhkh = null, float $Gt0 = null, float $Gt1 = null, float $Ck1 = null, float $Gt2 = null, float $Ck2 = null, float $Gt3 = null, float $Ck3 = null, float $Gt4 = null, float $Ck4 = null, float $Gt5 = null, float $Ck5 = null, float $Gt6 = null, float $Ck6 = null, float $Gt7 = null, float $Ck7 = null, float $Gt8 = null, float $Ck8 = null, float $Gt9 = null, float $Ck9 = null, float $Gt10 = null, float $Ck10 = null, float $Gt11 = null, float $Ck11 = null, float $Gt12 = null, float $Ck12 = null, float $Gt13 = null, float $Ck13 = null, float $Gt14 = null, float $Ck14 = null, float $Gt15 = null, float $Ck15 = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pVt_nhomvt' => $Vt_nhomvt,
            'pKh_nhomkh' => $Kh_nhomkh,
            'pSl_ds' => $Sl_ds,
            'pTl_gt' => $Tl_gt,
            'pTl_sl_ds' => $Tl_sl_ds,
            'pma_kyck' => $ma_kyck,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pGt0' => $Gt0,
            'pGt1' => $Gt1,
            'pCk1' => $Ck1,
            'pGt2' => $Gt2,
            'pCk2' => $Ck2,
            'pGt3' => $Gt3,
            'pCk3' => $Ck3,
            'pGt4' => $Gt4,
            'pCk4' => $Ck4,
            'pGt5' => $Gt5,
            'pCk5' => $Ck5,
            'pGt6' => $Gt6,
            'pCk6' => $Ck6,
            'pGt7' => $Gt7,
            'pCk7' => $Ck7,
            'pGt8' => $Gt8,
            'pCk8' => $Ck8,
            'pGt9' => $Gt9,
            'pCk9' => $Ck9,
            'pGt10' => $Gt10,
            'pCk10' => $Ck10,
            'pGt11' => $Gt11,
            'pCk11' => $Ck11,
            'pGt12' => $Gt12,
            'pCk12' => $Ck12,
            'pGt13' => $Gt13,
            'pCk13' => $Ck13,
            'pGt14' => $Gt14,
            'pCk14' => $Ck14,
            'pGt15' => $Gt15,
            'pCk15' => $Ck15,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
