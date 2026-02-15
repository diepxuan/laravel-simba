<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdPH2
{
    /**
     * Call stored procedure asSOUpdPH2
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdPH2', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pTen_kh_vat' => $params['pTen_kh_vat'] ?? null,
            'pDia_chi_vat' => $params['pDia_chi_vat'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pNguoi_nhan' => $params['pNguoi_nhan'] ?? null,
            'pCty_nhan' => $params['pCty_nhan'] ?? null,
            'pDc_nhan' => $params['pDc_nhan'] ?? null,
            'pTel_nhan' => $params['pTel_nhan'] ?? null,
            'pMa_nvt' => $params['pMa_nvt'] ?? null,
            'pMa_pt' => $params['pMa_pt'] ?? null,
            'pBien_so' => $params['pBien_so'] ?? null,
            'pNguoi_lai' => $params['pNguoi_lai'] ?? null,
            'pMa_td' => $params['pMa_td'] ?? null,
            'pTen_td' => $params['pTen_td'] ?? null,
            'pKm' => $params['pKm'] ?? null,
            'pSua_tien' => $params['pSua_tien'] ?? null,
            'pGia_dd' => $params['pGia_dd'] ?? null,
            'pt_so_luong' => $params['pt_so_luong'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? null,
            'pPost2in' => $params['pPost2in'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdPH2 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Nguoi_gd
     * @param string $Ten_kh_vat
     * @param string $Dia_chi_vat
     * @param string $Ma_so_thue
     * @param string $Trang_thai
     * @param string $Dien_giai
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param string $Nguoi_nhan
     * @param string $Cty_nhan
     * @param string $Dc_nhan
     * @param string $Tel_nhan
     * @param string $Ma_nvt
     * @param string $Ma_pt
     * @param string $Bien_so
     * @param string $Nguoi_lai
     * @param string $Ma_td
     * @param string $Ten_td
     * @param float $Km
     * @param bool $Sua_tien
     * @param bool $Gia_dd
     * @param float $t_so_luong
     * @param float $T_tien
     * @param float $T_tien_nt
     * @param bool $Post2gl
     * @param bool $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_kh = null, string $Nguoi_gd = null, string $Ten_kh_vat = null, string $Dia_chi_vat = null, string $Ma_so_thue = null, string $Trang_thai = null, string $Dien_giai = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ma_nt = null, float $Ty_gia = null, string $Nguoi_nhan = null, string $Cty_nhan = null, string $Dc_nhan = null, string $Tel_nhan = null, string $Ma_nvt = null, string $Ma_pt = null, string $Bien_so = null, string $Nguoi_lai = null, string $Ma_td = null, string $Ten_td = null, float $Km = null, bool $Sua_tien = null, bool $Gia_dd = null, float $t_so_luong = null, float $T_tien = null, float $T_tien_nt = null, bool $Post2gl = null, bool $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pNguoi_gd' => $Nguoi_gd,
            'pTen_kh_vat' => $Ten_kh_vat,
            'pDia_chi_vat' => $Dia_chi_vat,
            'pMa_so_thue' => $Ma_so_thue,
            'pTrang_thai' => $Trang_thai,
            'pDien_giai' => $Dien_giai,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pNguoi_nhan' => $Nguoi_nhan,
            'pCty_nhan' => $Cty_nhan,
            'pDc_nhan' => $Dc_nhan,
            'pTel_nhan' => $Tel_nhan,
            'pMa_nvt' => $Ma_nvt,
            'pMa_pt' => $Ma_pt,
            'pBien_so' => $Bien_so,
            'pNguoi_lai' => $Nguoi_lai,
            'pMa_td' => $Ma_td,
            'pTen_td' => $Ten_td,
            'pKm' => $Km,
            'pSua_tien' => $Sua_tien,
            'pGia_dd' => $Gia_dd,
            'pt_so_luong' => $t_so_luong,
            'pT_tien' => $T_tien,
            'pT_tien_nt' => $T_tien_nt,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
