<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsCT9
{
    /**
     * Call stored procedure asINInsCT9
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCT9', $params, $connection);
    }

    /**
     * Call stored procedure asINInsCT9 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_kho
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Dvt
     * @param string $Tk_vt
     * @param string $Tk_co
     * @param string $Ma_nx
     * @param float $Sl_ton
     * @param float $Sl_kk
     * @param float $Sl_cl
     * @param float $Tien_ss
     * @param string $Ma_vitri
     * @param int $Con_tot
     * @param int $Kem_pc
     * @param int $Mat_pc
     * @param string $Ghi_chu
     * @param string $Ma_lo
     * @param string $Ma_hd
     * @param string $Ma_bp
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_kho = null, string $Ma_vt = null, string $Ten_vt = null, string $Dvt = null, string $Tk_vt = null, string $Tk_co = null, string $Ma_nx = null, float $Sl_ton = null, float $Sl_kk = null, float $Sl_cl = null, float $Tien_ss = null, string $Ma_vitri = null, int $Con_tot = null, int $Kem_pc = null, int $Mat_pc = null, string $Ghi_chu = null, string $Ma_lo = null, string $Ma_hd = null, string $Ma_bp = null, string $Ma_phi = null, string $Ma_spct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_kho' => $Ma_kho,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pDvt' => $Dvt,
            'pTk_vt' => $Tk_vt,
            'pTk_co' => $Tk_co,
            'pMa_nx' => $Ma_nx,
            'pSl_ton' => $Sl_ton,
            'pSl_kk' => $Sl_kk,
            'pSl_cl' => $Sl_cl,
            'pTien_ss' => $Tien_ss,
            'pMa_vitri' => $Ma_vitri,
            'pCon_tot' => $Con_tot,
            'pKem_pc' => $Kem_pc,
            'pMat_pc' => $Mat_pc,
            'pGhi_chu' => $Ghi_chu,
            'pMa_lo' => $Ma_lo,
            'pMa_hd' => $Ma_hd,
            'pMa_bp' => $Ma_bp,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
