<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOInsPH2
{
    /**
     * Call stored procedure asPOInsPH2
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsPH2', $params, $connection);
    }

    /**
     * Call stored procedure asPOInsPH2 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Nguoi_gd
     * @param string $Ma_httt
     * @param string $Tk_pt
     * @param string $Dien_giai
     * @param string $Ghi_chu
     * @param string $So_seri
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $Ma_tt_po
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt0
     * @param float $T_tien0
     * @param float $T_tien_nt
     * @param float $T_tien
     * @param float $T_thue_nt
     * @param float $T_thue
     * @param float $T_gg
     * @param float $T_gg_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $T_so_luong
     * @param bool $Sua_tien
     * @param bool $Sua_thue
     * @param bool $Tao_tu_dh
     * @param bool $Post2gl
     * @param string $Trang_thai
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_kh = null, string $Nguoi_gd = null, string $Ma_httt = null, string $Tk_pt = null, string $Dien_giai = null, string $Ghi_chu = null, string $So_seri = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ma_tt_po = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt0 = null, float $T_tien0 = null, float $T_tien_nt = null, float $T_tien = null, float $T_thue_nt = null, float $T_thue = null, float $T_gg = null, float $T_gg_nt = null, float $T_tt = null, float $T_tt_nt = null, float $T_so_luong = null, bool $Sua_tien = null, bool $Sua_thue = null, bool $Tao_tu_dh = null, bool $Post2gl = null, string $Trang_thai = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pNguoi_gd' => $Nguoi_gd,
            'pMa_httt' => $Ma_httt,
            'pTk_pt' => $Tk_pt,
            'pDien_giai' => $Dien_giai,
            'pGhi_chu' => $Ghi_chu,
            'pSo_seri' => $So_seri,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pMa_tt_po' => $Ma_tt_po,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt0' => $T_tien_nt0,
            'pT_tien0' => $T_tien0,
            'pT_tien_nt' => $T_tien_nt,
            'pT_tien' => $T_tien,
            'pT_thue_nt' => $T_thue_nt,
            'pT_thue' => $T_thue,
            'pT_gg' => $T_gg,
            'pT_gg_nt' => $T_gg_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pT_so_luong' => $T_so_luong,
            'pSua_tien' => $Sua_tien,
            'pSua_thue' => $Sua_thue,
            'pTao_tu_dh' => $Tao_tu_dh,
            'pPost2gl' => $Post2gl,
            'pTrang_thai' => $Trang_thai,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
