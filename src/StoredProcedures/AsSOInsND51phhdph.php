<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsND51phhdph
{
    /**
     * Call stored procedure asSOInsND51phhdph
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsND51phhdph', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsND51phhdph with named parameters
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
     * @param string $Cdate
     * @param string $Cuser
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Ngay_tb = null, string $Donvi_ph = null, string $Ma_thue = null, string $Dia_chi = null, string $Tel = null, string $Donvi_cq = null, string $Ma_thuedvcq = null, string $Cq_thue = null, string $Dai_dien = null, string $Ngay_duyet = null, bool $Chap_nhan = null, string $Cdate = null, string $Cuser = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
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
            'pCdate' => $Cdate,
            'pCuser' => $Cuser,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
