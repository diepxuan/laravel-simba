<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOUpdND51phhdph
{
    /**
     * Call stored procedure asSOUpdND51phhdph
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdND51phhdph', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tb' => $paramObj->pMa_tb ?? null,
            'pNgay_tb' => $paramObj->pNgay_tb ?? null,
            'pDonvi_ph' => $paramObj->pDonvi_ph ?? null,
            'pMa_thue' => $paramObj->pMa_thue ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pTel' => $paramObj->pTel ?? null,
            'pDonvi_cq' => $paramObj->pDonvi_cq ?? null,
            'pMa_thuedvcq' => $paramObj->pMa_thuedvcq ?? null,
            'pCq_thue' => $paramObj->pCq_thue ?? null,
            'pDai_dien' => $paramObj->pDai_dien ?? null,
            'pNgay_duyet' => $paramObj->pNgay_duyet ?? null,
            'pChap_nhan' => $paramObj->pChap_nhan ?? null,
            'pLdate' => $paramObj->pLdate ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdND51phhdph with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param string $Ngay_tb
     * @param string $Donvi_ph
     * @param string $Ma_thue
     * @param string $Dia_chi
     * @param string $Tel
     * @param string $Donvi_cq
     * @param string $Ma_thuedvcq
     * @param string $Cq_thue
     * @param string $Dai_dien
     * @param string $Ngay_duyet
     * @param bool $Chap_nhan
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Ngay_tb = null, string $Donvi_ph = null, string $Ma_thue = null, string $Dia_chi = null, string $Tel = null, string $Donvi_cq = null, string $Ma_thuedvcq = null, string $Cq_thue = null, string $Dai_dien = null, string $Ngay_duyet = null, bool $Chap_nhan = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pNgay_tb' => $Ngay_tb,
            'pDonvi_ph' => $Donvi_ph,
            'pMa_thue' => $Ma_thue,
            'pDia_chi' => $Dia_chi,
            'pTel' => $Tel,
            'pDonvi_cq' => $Donvi_cq,
            'pMa_thuedvcq' => $Ma_thuedvcq,
            'pCq_thue' => $Cq_thue,
            'pDai_dien' => $Dai_dien,
            'pNgay_duyet' => $Ngay_duyet,
            'pChap_nhan' => $Chap_nhan,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
