<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINUpdDMVT
{
    /**
     * Call stored procedure asINUpdDMVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdDMVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pLoai' => $params['pLoai'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pPart_no' => $params['pPart_no'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pDvt_ban' => $params['pDvt_ban'] ?? null,
            'pHs_dvtban' => $params['pHs_dvtban'] ?? null,
            'pDvt_mua' => $params['pDvt_mua'] ?? null,
            'pHs_dvtmua' => $params['pHs_dvtmua'] ?? null,
            'pTon_kho' => $params['pTon_kho'] ?? null,
            'pGia_ton' => $params['pGia_ton'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pTk_dt' => $params['pTk_dt'] ?? null,
            'pTk_dtnb' => $params['pTk_dtnb'] ?? null,
            'pTk_gv' => $params['pTk_gv'] ?? null,
            'pTk_tl' => $params['pTk_tl'] ?? null,
            'pTk_ck' => $params['pTk_ck'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pTinh_gt' => $params['pTinh_gt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pMa_nhvat' => $params['pMa_nhvat'] ?? null,
            'pSl_min' => $params['pSl_min'] ?? null,
            'pSl_max' => $params['pSl_max'] ?? null,
            'pGia_nt0' => $params['pGia_nt0'] ?? null,
            'pGia_nt2' => $params['pGia_nt2'] ?? null,
            'pTs_nk' => $params['pTs_nk'] ?? null,
            'pTs_gtgt' => $params['pTs_gtgt'] ?? null,
            'pTs_xk' => $params['pTs_xk'] ?? null,
            'pTs_ttdb' => $params['pTs_ttdb'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pCo_ct' => $params['pCo_ct'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNha_sx' => $params['pNha_sx'] ?? null,
            'pNha_pp' => $params['pNha_pp'] ?? null,
            'pNuoc_sx' => $params['pNuoc_sx'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdDMVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Loai
     * @param string $Ten_vt
     * @param string $Part_no
     * @param string $Dvt
     * @param string $Dvt_ban
     * @param float $Hs_dvtban
     * @param string $Dvt_mua
     * @param float $Hs_dvtmua
     * @param bool $Ton_kho
     * @param string $Gia_ton
     * @param string $Tk_vt
     * @param string $Tk_dt
     * @param string $Tk_dtnb
     * @param string $Tk_gv
     * @param string $Tk_tl
     * @param string $Tk_ck
     * @param string $Ma_thue
     * @param bool $Tinh_gt
     * @param string $Ma_nhvt
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $Ma_nhvat
     * @param float $Sl_min
     * @param float $Sl_max
     * @param float $Gia_nt0
     * @param float $Gia_nt2
     * @param int $Ts_nk
     * @param int $Ts_gtgt
     * @param int $Ts_xk
     * @param int $Ts_ttdb
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param bool $Co_ct
     * @param string $Ma_lo
     * @param string $Ghi_chu
     * @param string $Nha_sx
     * @param string $Nha_pp
     * @param string $Nuoc_sx
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @param mixed $ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Loai = null, string $Ten_vt = null, string $Part_no = null, string $Dvt = null, string $Dvt_ban = null, float $Hs_dvtban = null, string $Dvt_mua = null, float $Hs_dvtmua = null, bool $Ton_kho = null, string $Gia_ton = null, string $Tk_vt = null, string $Tk_dt = null, string $Tk_dtnb = null, string $Tk_gv = null, string $Tk_tl = null, string $Tk_ck = null, string $Ma_thue = null, bool $Tinh_gt = null, string $Ma_nhvt = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $Ma_nhvat = null, float $Sl_min = null, float $Sl_max = null, float $Gia_nt0 = null, float $Gia_nt2 = null, int $Ts_nk = null, int $Ts_gtgt = null, int $Ts_xk = null, int $Ts_ttdb = null, string $Ma_kho = null, string $Ma_vitri = null, bool $Co_ct = null, string $Ma_lo = null, string $Ghi_chu = null, string $Nha_sx = null, string $Nha_pp = null, string $Nuoc_sx = null, bool $Ksd = null, string $LUser = null, int $Ret = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pLoai' => $Loai,
            'pTen_vt' => $Ten_vt,
            'pPart_no' => $Part_no,
            'pDvt' => $Dvt,
            'pDvt_ban' => $Dvt_ban,
            'pHs_dvtban' => $Hs_dvtban,
            'pDvt_mua' => $Dvt_mua,
            'pHs_dvtmua' => $Hs_dvtmua,
            'pTon_kho' => $Ton_kho,
            'pGia_ton' => $Gia_ton,
            'pTk_vt' => $Tk_vt,
            'pTk_dt' => $Tk_dt,
            'pTk_dtnb' => $Tk_dtnb,
            'pTk_gv' => $Tk_gv,
            'pTk_tl' => $Tk_tl,
            'pTk_ck' => $Tk_ck,
            'pMa_thue' => $Ma_thue,
            'pTinh_gt' => $Tinh_gt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pMa_nhvat' => $Ma_nhvat,
            'pSl_min' => $Sl_min,
            'pSl_max' => $Sl_max,
            'pGia_nt0' => $Gia_nt0,
            'pGia_nt2' => $Gia_nt2,
            'pTs_nk' => $Ts_nk,
            'pTs_gtgt' => $Ts_gtgt,
            'pTs_xk' => $Ts_xk,
            'pTs_ttdb' => $Ts_ttdb,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pCo_ct' => $Co_ct,
            'pMa_lo' => $Ma_lo,
            'pGhi_chu' => $Ghi_chu,
            'pNha_sx' => $Nha_sx,
            'pNha_pp' => $Nha_pp,
            'pNuoc_sx' => $Nuoc_sx,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret,
            'pma_cty' => $ma_cty
        ];
        
        return self::call($params);
    }
}
