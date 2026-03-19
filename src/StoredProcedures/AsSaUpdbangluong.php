<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSaUpdbangluong
{
    /**
     * Call stored procedure asSaUpdbangluong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaUpdbangluong', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pTen_bp' => $paramObj->pTen_bp ?? null,
            'pId_nv' => $paramObj->pId_nv ?? null,
            'pMa_nv' => $paramObj->pMa_nv ?? null,
            'pTen_nv' => $paramObj->pTen_nv ?? null,
            'pDiem' => $paramObj->pDiem ?? null,
            'pHs_diem' => $paramObj->pHs_diem ?? null,
            'pLuong_trich_diem' => $paramObj->pLuong_trich_diem ?? null,
            'pTl_bhxh' => $paramObj->pTl_bhxh ?? null,
            'pLoai' => $paramObj->pLoai ?? null,
            'pHs_loai' => $paramObj->pHs_loai ?? null,
            'pHsl_cb' => $paramObj->pHsl_cb ?? null,
            'pHsl_cv' => $paramObj->pHsl_cv ?? null,
            'pHs_pc' => $paramObj->pHs_pc ?? null,
            'pHs_dc' => $paramObj->pHs_dc ?? null,
            'pHspc_kv' => $paramObj->pHspc_kv ?? null,
            'pHspc_cv' => $paramObj->pHspc_cv ?? null,
            'pHspc_dd' => $paramObj->pHspc_dd ?? null,
            'pHspc_dh' => $paramObj->pHspc_dh ?? null,
            'pLuong_pcdh' => $paramObj->pLuong_pcdh ?? null,
            'pHspc_tn' => $paramObj->pHspc_tn ?? null,
            'pPc_tn' => $paramObj->pPc_tn ?? null,
            'pPc_th' => $paramObj->pPc_th ?? null,
            'pLuong_th' => $paramObj->pLuong_th ?? null,
            'pLuong_cung' => $paramObj->pLuong_cung ?? null,
            'pMuc_an' => $paramObj->pMuc_an ?? null,
            'pCong_cb' => $paramObj->pCong_cb ?? null,
            'pCong' => $paramObj->pCong ?? null,
            'pCong_sp' => $paramObj->pCong_sp ?? null,
            'pCong_le' => $paramObj->pCong_le ?? null,
            'pCong_phep' => $paramObj->pCong_phep ?? null,
            'pCong_om' => $paramObj->pCong_om ?? null,
            'pCong_co' => $paramObj->pCong_co ?? null,
            'pCong_ts' => $paramObj->pCong_ts ?? null,
            'pCong_khh' => $paramObj->pCong_khh ?? null,
            'pTcong_bh' => $paramObj->pTcong_bh ?? null,
            'pCong_khac' => $paramObj->pCong_khac ?? null,
            'pLuong_cd' => $paramObj->pLuong_cd ?? null,
            'pLuong_cb' => $paramObj->pLuong_cb ?? null,
            'pLuong_cong' => $paramObj->pLuong_cong ?? null,
            'pLuong_sp' => $paramObj->pLuong_sp ?? null,
            'pLuong_le' => $paramObj->pLuong_le ?? null,
            'pLuong_phep' => $paramObj->pLuong_phep ?? null,
            'pLuong_tn' => $paramObj->pLuong_tn ?? null,
            'pGio_lt' => $paramObj->pGio_lt ?? null,
            'pCong_tg' => $paramObj->pCong_tg ?? null,
            'pLuong_tg' => $paramObj->pLuong_tg ?? null,
            'pCong75' => $paramObj->pCong75 ?? null,
            'pCong100' => $paramObj->pCong100 ?? null,
            'pCong130' => $paramObj->pCong130 ?? null,
            'pCong150' => $paramObj->pCong150 ?? null,
            'pCong180' => $paramObj->pCong180 ?? null,
            'pCong200' => $paramObj->pCong200 ?? null,
            'pCong230' => $paramObj->pCong230 ?? null,
            'pCong300' => $paramObj->pCong300 ?? null,
            'pCong330' => $paramObj->pCong330 ?? null,
            'pLuong75' => $paramObj->pLuong75 ?? null,
            'pLuong100' => $paramObj->pLuong100 ?? null,
            'pLuong130' => $paramObj->pLuong130 ?? null,
            'pLuong150' => $paramObj->pLuong150 ?? null,
            'pLuong180' => $paramObj->pLuong180 ?? null,
            'pLuong200' => $paramObj->pLuong200 ?? null,
            'pLuong230' => $paramObj->pLuong230 ?? null,
            'pLuong300' => $paramObj->pLuong300 ?? null,
            'pLuong330' => $paramObj->pLuong330 ?? null,
            'pLuong_bh' => $paramObj->pLuong_bh ?? null,
            'pLuong_khac' => $paramObj->pLuong_khac ?? null,
            'pAn_ca' => $paramObj->pAn_ca ?? null,
            'pTru_an_ca' => $paramObj->pTru_an_ca ?? null,
            'pPhu_cap' => $paramObj->pPhu_cap ?? null,
            'pThuong' => $paramObj->pThuong ?? null,
            'pCon_bu' => $paramObj->pCon_bu ?? null,
            'pViec_rieng' => $paramObj->pViec_rieng ?? null,
            'pTong_luong' => $paramObj->pTong_luong ?? null,
            'pTam_ung' => $paramObj->pTam_ung ?? null,
            'pBhyt' => $paramObj->pBhyt ?? null,
            'pBhxh' => $paramObj->pBhxh ?? null,
            'pDpcd' => $paramObj->pDpcd ?? null,
            'pDp' => $paramObj->pDp ?? null,
            'pKpcd' => $paramObj->pKpcd ?? null,
            'pThue_tn' => $paramObj->pThue_tn ?? null,
            'pTru_khac' => $paramObj->pTru_khac ?? null,
            'pLuong_pt' => $paramObj->pLuong_pt ?? null,
            'pThuc_linh' => $paramObj->pThuc_linh ?? null,
            'pDa_linh' => $paramObj->pDa_linh ?? null,
            'pLuy_ke' => $paramObj->pLuy_ke ?? null,
            'pNop_bhxh' => $paramObj->pNop_bhxh ?? null,
            'pDoan_vien' => $paramObj->pDoan_vien ?? null,
            'pDang_vien' => $paramObj->pDang_vien ?? null,
            'pBp_khac' => $paramObj->pBp_khac ?? null,
            'pTk_nv' => $paramObj->pTk_nv ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaUpdbangluong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param string $Ten_bp
     * @param string $Id_nv
     * @param string $Ma_nv
     * @param string $Ten_nv
     * @param float $Diem
     * @param float $Hs_diem
     * @param float $Luong_trich_diem
     * @param float $Tl_bhxh
     * @param string $Loai
     * @param float $Hs_loai
     * @param float $Hsl_cb
     * @param float $Hsl_cv
     * @param float $Hs_pc
     * @param float $Hs_dc
     * @param float $Hspc_kv
     * @param float $Hspc_cv
     * @param float $Hspc_dd
     * @param float $Hspc_dh
     * @param float $Luong_pcdh
     * @param float $Hspc_tn
     * @param float $Pc_tn
     * @param float $Pc_th
     * @param float $Luong_th
     * @param float $Luong_cung
     * @param float $Muc_an
     * @param float $Cong_cb
     * @param float $Cong
     * @param float $Cong_sp
     * @param float $Cong_le
     * @param float $Cong_phep
     * @param float $Cong_om
     * @param float $Cong_co
     * @param float $Cong_ts
     * @param float $Cong_khh
     * @param float $Tcong_bh
     * @param float $Cong_khac
     * @param float $Luong_cd
     * @param float $Luong_cb
     * @param float $Luong_cong
     * @param float $Luong_sp
     * @param float $Luong_le
     * @param float $Luong_phep
     * @param float $Luong_tn
     * @param float $Gio_lt
     * @param float $Cong_tg
     * @param float $Luong_tg
     * @param float $Cong75
     * @param float $Cong100
     * @param float $Cong130
     * @param float $Cong150
     * @param float $Cong180
     * @param float $Cong200
     * @param float $Cong230
     * @param float $Cong300
     * @param float $Cong330
     * @param float $Luong75
     * @param float $Luong100
     * @param float $Luong130
     * @param float $Luong150
     * @param float $Luong180
     * @param float $Luong200
     * @param float $Luong230
     * @param float $Luong300
     * @param float $Luong330
     * @param float $Luong_bh
     * @param float $Luong_khac
     * @param float $An_ca
     * @param float $Tru_an_ca
     * @param float $Phu_cap
     * @param float $Thuong
     * @param float $Con_bu
     * @param float $Viec_rieng
     * @param float $Tong_luong
     * @param float $Tam_ung
     * @param float $Bhyt
     * @param float $Bhxh
     * @param float $Dpcd
     * @param float $Dp
     * @param float $Kpcd
     * @param float $Thue_tn
     * @param float $Tru_khac
     * @param float $Luong_pt
     * @param float $Thuc_linh
     * @param float $Da_linh
     * @param float $Luy_ke
     * @param string $Nop_bhxh
     * @param string $Doan_vien
     * @param string $Dang_vien
     * @param string $Bp_khac
     * @param string $Tk_nv
     * @param string $User
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, string $Ten_bp = null, string $Id_nv = null, string $Ma_nv = null, string $Ten_nv = null, float $Diem = null, float $Hs_diem = null, float $Luong_trich_diem = null, float $Tl_bhxh = null, string $Loai = null, float $Hs_loai = null, float $Hsl_cb = null, float $Hsl_cv = null, float $Hs_pc = null, float $Hs_dc = null, float $Hspc_kv = null, float $Hspc_cv = null, float $Hspc_dd = null, float $Hspc_dh = null, float $Luong_pcdh = null, float $Hspc_tn = null, float $Pc_tn = null, float $Pc_th = null, float $Luong_th = null, float $Luong_cung = null, float $Muc_an = null, float $Cong_cb = null, float $Cong = null, float $Cong_sp = null, float $Cong_le = null, float $Cong_phep = null, float $Cong_om = null, float $Cong_co = null, float $Cong_ts = null, float $Cong_khh = null, float $Tcong_bh = null, float $Cong_khac = null, float $Luong_cd = null, float $Luong_cb = null, float $Luong_cong = null, float $Luong_sp = null, float $Luong_le = null, float $Luong_phep = null, float $Luong_tn = null, float $Gio_lt = null, float $Cong_tg = null, float $Luong_tg = null, float $Cong75 = null, float $Cong100 = null, float $Cong130 = null, float $Cong150 = null, float $Cong180 = null, float $Cong200 = null, float $Cong230 = null, float $Cong300 = null, float $Cong330 = null, float $Luong75 = null, float $Luong100 = null, float $Luong130 = null, float $Luong150 = null, float $Luong180 = null, float $Luong200 = null, float $Luong230 = null, float $Luong300 = null, float $Luong330 = null, float $Luong_bh = null, float $Luong_khac = null, float $An_ca = null, float $Tru_an_ca = null, float $Phu_cap = null, float $Thuong = null, float $Con_bu = null, float $Viec_rieng = null, float $Tong_luong = null, float $Tam_ung = null, float $Bhyt = null, float $Bhxh = null, float $Dpcd = null, float $Dp = null, float $Kpcd = null, float $Thue_tn = null, float $Tru_khac = null, float $Luong_pt = null, float $Thuc_linh = null, float $Da_linh = null, float $Luy_ke = null, string $Nop_bhxh = null, string $Doan_vien = null, string $Dang_vien = null, string $Bp_khac = null, string $Tk_nv = null, string $User = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pTen_bp' => $Ten_bp,
            'pId_nv' => $Id_nv,
            'pMa_nv' => $Ma_nv,
            'pTen_nv' => $Ten_nv,
            'pDiem' => $Diem,
            'pHs_diem' => $Hs_diem,
            'pLuong_trich_diem' => $Luong_trich_diem,
            'pTl_bhxh' => $Tl_bhxh,
            'pLoai' => $Loai,
            'pHs_loai' => $Hs_loai,
            'pHsl_cb' => $Hsl_cb,
            'pHsl_cv' => $Hsl_cv,
            'pHs_pc' => $Hs_pc,
            'pHs_dc' => $Hs_dc,
            'pHspc_kv' => $Hspc_kv,
            'pHspc_cv' => $Hspc_cv,
            'pHspc_dd' => $Hspc_dd,
            'pHspc_dh' => $Hspc_dh,
            'pLuong_pcdh' => $Luong_pcdh,
            'pHspc_tn' => $Hspc_tn,
            'pPc_tn' => $Pc_tn,
            'pPc_th' => $Pc_th,
            'pLuong_th' => $Luong_th,
            'pLuong_cung' => $Luong_cung,
            'pMuc_an' => $Muc_an,
            'pCong_cb' => $Cong_cb,
            'pCong' => $Cong,
            'pCong_sp' => $Cong_sp,
            'pCong_le' => $Cong_le,
            'pCong_phep' => $Cong_phep,
            'pCong_om' => $Cong_om,
            'pCong_co' => $Cong_co,
            'pCong_ts' => $Cong_ts,
            'pCong_khh' => $Cong_khh,
            'pTcong_bh' => $Tcong_bh,
            'pCong_khac' => $Cong_khac,
            'pLuong_cd' => $Luong_cd,
            'pLuong_cb' => $Luong_cb,
            'pLuong_cong' => $Luong_cong,
            'pLuong_sp' => $Luong_sp,
            'pLuong_le' => $Luong_le,
            'pLuong_phep' => $Luong_phep,
            'pLuong_tn' => $Luong_tn,
            'pGio_lt' => $Gio_lt,
            'pCong_tg' => $Cong_tg,
            'pLuong_tg' => $Luong_tg,
            'pCong75' => $Cong75,
            'pCong100' => $Cong100,
            'pCong130' => $Cong130,
            'pCong150' => $Cong150,
            'pCong180' => $Cong180,
            'pCong200' => $Cong200,
            'pCong230' => $Cong230,
            'pCong300' => $Cong300,
            'pCong330' => $Cong330,
            'pLuong75' => $Luong75,
            'pLuong100' => $Luong100,
            'pLuong130' => $Luong130,
            'pLuong150' => $Luong150,
            'pLuong180' => $Luong180,
            'pLuong200' => $Luong200,
            'pLuong230' => $Luong230,
            'pLuong300' => $Luong300,
            'pLuong330' => $Luong330,
            'pLuong_bh' => $Luong_bh,
            'pLuong_khac' => $Luong_khac,
            'pAn_ca' => $An_ca,
            'pTru_an_ca' => $Tru_an_ca,
            'pPhu_cap' => $Phu_cap,
            'pThuong' => $Thuong,
            'pCon_bu' => $Con_bu,
            'pViec_rieng' => $Viec_rieng,
            'pTong_luong' => $Tong_luong,
            'pTam_ung' => $Tam_ung,
            'pBhyt' => $Bhyt,
            'pBhxh' => $Bhxh,
            'pDpcd' => $Dpcd,
            'pDp' => $Dp,
            'pKpcd' => $Kpcd,
            'pThue_tn' => $Thue_tn,
            'pTru_khac' => $Tru_khac,
            'pLuong_pt' => $Luong_pt,
            'pThuc_linh' => $Thuc_linh,
            'pDa_linh' => $Da_linh,
            'pLuy_ke' => $Luy_ke,
            'pNop_bhxh' => $Nop_bhxh,
            'pDoan_vien' => $Doan_vien,
            'pDang_vien' => $Dang_vien,
            'pBp_khac' => $Bp_khac,
            'pTk_nv' => $Tk_nv,
            'pUser' => $User,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
