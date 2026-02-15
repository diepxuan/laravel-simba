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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaUpdbangluong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pTen_bp' => $params['pTen_bp'] ?? null,
            'pId_nv' => $params['pId_nv'] ?? null,
            'pMa_nv' => $params['pMa_nv'] ?? null,
            'pTen_nv' => $params['pTen_nv'] ?? null,
            'pDiem' => $params['pDiem'] ?? null,
            'pHs_diem' => $params['pHs_diem'] ?? null,
            'pLuong_trich_diem' => $params['pLuong_trich_diem'] ?? null,
            'pTl_bhxh' => $params['pTl_bhxh'] ?? null,
            'pLoai' => $params['pLoai'] ?? null,
            'pHs_loai' => $params['pHs_loai'] ?? null,
            'pHsl_cb' => $params['pHsl_cb'] ?? null,
            'pHsl_cv' => $params['pHsl_cv'] ?? null,
            'pHs_pc' => $params['pHs_pc'] ?? null,
            'pHs_dc' => $params['pHs_dc'] ?? null,
            'pHspc_kv' => $params['pHspc_kv'] ?? null,
            'pHspc_cv' => $params['pHspc_cv'] ?? null,
            'pHspc_dd' => $params['pHspc_dd'] ?? null,
            'pHspc_dh' => $params['pHspc_dh'] ?? null,
            'pLuong_pcdh' => $params['pLuong_pcdh'] ?? null,
            'pHspc_tn' => $params['pHspc_tn'] ?? null,
            'pPc_tn' => $params['pPc_tn'] ?? null,
            'pPc_th' => $params['pPc_th'] ?? null,
            'pLuong_th' => $params['pLuong_th'] ?? null,
            'pLuong_cung' => $params['pLuong_cung'] ?? null,
            'pMuc_an' => $params['pMuc_an'] ?? null,
            'pCong_cb' => $params['pCong_cb'] ?? null,
            'pCong' => $params['pCong'] ?? null,
            'pCong_sp' => $params['pCong_sp'] ?? null,
            'pCong_le' => $params['pCong_le'] ?? null,
            'pCong_phep' => $params['pCong_phep'] ?? null,
            'pCong_om' => $params['pCong_om'] ?? null,
            'pCong_co' => $params['pCong_co'] ?? null,
            'pCong_ts' => $params['pCong_ts'] ?? null,
            'pCong_khh' => $params['pCong_khh'] ?? null,
            'pTcong_bh' => $params['pTcong_bh'] ?? null,
            'pCong_khac' => $params['pCong_khac'] ?? null,
            'pLuong_cd' => $params['pLuong_cd'] ?? null,
            'pLuong_cb' => $params['pLuong_cb'] ?? null,
            'pLuong_cong' => $params['pLuong_cong'] ?? null,
            'pLuong_sp' => $params['pLuong_sp'] ?? null,
            'pLuong_le' => $params['pLuong_le'] ?? null,
            'pLuong_phep' => $params['pLuong_phep'] ?? null,
            'pLuong_tn' => $params['pLuong_tn'] ?? null,
            'pGio_lt' => $params['pGio_lt'] ?? null,
            'pCong_tg' => $params['pCong_tg'] ?? null,
            'pLuong_tg' => $params['pLuong_tg'] ?? null,
            'pCong75' => $params['pCong75'] ?? null,
            'pCong100' => $params['pCong100'] ?? null,
            'pCong130' => $params['pCong130'] ?? null,
            'pCong150' => $params['pCong150'] ?? null,
            'pCong180' => $params['pCong180'] ?? null,
            'pCong200' => $params['pCong200'] ?? null,
            'pCong230' => $params['pCong230'] ?? null,
            'pCong300' => $params['pCong300'] ?? null,
            'pCong330' => $params['pCong330'] ?? null,
            'pLuong75' => $params['pLuong75'] ?? null,
            'pLuong100' => $params['pLuong100'] ?? null,
            'pLuong130' => $params['pLuong130'] ?? null,
            'pLuong150' => $params['pLuong150'] ?? null,
            'pLuong180' => $params['pLuong180'] ?? null,
            'pLuong200' => $params['pLuong200'] ?? null,
            'pLuong230' => $params['pLuong230'] ?? null,
            'pLuong300' => $params['pLuong300'] ?? null,
            'pLuong330' => $params['pLuong330'] ?? null,
            'pLuong_bh' => $params['pLuong_bh'] ?? null,
            'pLuong_khac' => $params['pLuong_khac'] ?? null,
            'pAn_ca' => $params['pAn_ca'] ?? null,
            'pTru_an_ca' => $params['pTru_an_ca'] ?? null,
            'pPhu_cap' => $params['pPhu_cap'] ?? null,
            'pThuong' => $params['pThuong'] ?? null,
            'pCon_bu' => $params['pCon_bu'] ?? null,
            'pViec_rieng' => $params['pViec_rieng'] ?? null,
            'pTong_luong' => $params['pTong_luong'] ?? null,
            'pTam_ung' => $params['pTam_ung'] ?? null,
            'pBhyt' => $params['pBhyt'] ?? null,
            'pBhxh' => $params['pBhxh'] ?? null,
            'pDpcd' => $params['pDpcd'] ?? null,
            'pDp' => $params['pDp'] ?? null,
            'pKpcd' => $params['pKpcd'] ?? null,
            'pThue_tn' => $params['pThue_tn'] ?? null,
            'pTru_khac' => $params['pTru_khac'] ?? null,
            'pLuong_pt' => $params['pLuong_pt'] ?? null,
            'pThuc_linh' => $params['pThuc_linh'] ?? null,
            'pDa_linh' => $params['pDa_linh'] ?? null,
            'pLuy_ke' => $params['pLuy_ke'] ?? null,
            'pNop_bhxh' => $params['pNop_bhxh'] ?? null,
            'pDoan_vien' => $params['pDoan_vien'] ?? null,
            'pDang_vien' => $params['pDang_vien'] ?? null,
            'pBp_khac' => $params['pBp_khac'] ?? null,
            'pTk_nv' => $params['pTk_nv'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
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
