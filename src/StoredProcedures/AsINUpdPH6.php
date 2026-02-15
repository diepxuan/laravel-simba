<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINUpdPH6
{
    /**
     * Call stored procedure asINUpdPH6
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdPH6', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_gd' => $params['pMa_gd'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ctn' => $params['pNgay_ctn'] ?? null,
            'pSo_ctn' => $params['pSo_ctn'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pPN_GTB' => $params['pPN_GTB'] ?? null,
            'pPX_GDD' => $params['pPX_GDD'] ?? null,
            'pTk_vt_lrtd' => $params['pTk_vt_lrtd'] ?? null,
            'pTk_lrtd' => $params['pTk_lrtd'] ?? null,
            'pT_so_luong' => $params['pT_so_luong'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? null,
            'pPost2in' => $params['pPost2in'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdPH6 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_gd
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $So_ct
     * @param string $Ngay_ctn
     * @param string $So_ctn
     * @param string $Ma_kh
     * @param string $Nguoi_gd
     * @param string $Dien_giai
     * @param bool $PN_GTB
     * @param bool $PX_GDD
     * @param string $Tk_vt_lrtd
     * @param string $Tk_lrtd
     * @param float $T_so_luong
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt
     * @param float $T_tien
     * @param bool $Post2gl
     * @param bool $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_gd = null, string $Ngay_ct = null, string $Ngay_lct = null, string $So_ct = null, string $Ngay_ctn = null, string $So_ctn = null, string $Ma_kh = null, string $Nguoi_gd = null, string $Dien_giai = null, bool $PN_GTB = null, bool $PX_GDD = null, string $Tk_vt_lrtd = null, string $Tk_lrtd = null, float $T_so_luong = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt = null, float $T_tien = null, bool $Post2gl = null, bool $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_gd' => $Ma_gd,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pSo_ct' => $So_ct,
            'pNgay_ctn' => $Ngay_ctn,
            'pSo_ctn' => $So_ctn,
            'pMa_kh' => $Ma_kh,
            'pNguoi_gd' => $Nguoi_gd,
            'pDien_giai' => $Dien_giai,
            'pPN_GTB' => $PN_GTB,
            'pPX_GDD' => $PX_GDD,
            'pTk_vt_lrtd' => $Tk_vt_lrtd,
            'pTk_lrtd' => $Tk_lrtd,
            'pT_so_luong' => $T_so_luong,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt' => $T_tien_nt,
            'pT_tien' => $T_tien,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
