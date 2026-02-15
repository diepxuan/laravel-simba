<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsHSNS
{
    /**
     * Call stored procedure asHrInsHSNS
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsHSNS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pMa_nvns' => $params['pMa_nvns'] ?? null,
            'pMa_uv' => $params['pMa_uv'] ?? null,
            'pMa_cham_cong' => $params['pMa_cham_cong'] ?? null,
            'pHo_ten' => $params['pHo_ten'] ?? null,
            'pHo_dem' => $params['pHo_dem'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pBi_danh' => $params['pBi_danh'] ?? null,
            'pNgay_sinh' => $params['pNgay_sinh'] ?? null,
            'pGioi_tinh' => $params['pGioi_tinh'] ?? null,
            'pSo_cmnd' => $params['pSo_cmnd'] ?? null,
            'pNgay_cap_cmnd' => $params['pNgay_cap_cmnd'] ?? null,
            'pNoi_cap_cmnd' => $params['pNoi_cap_cmnd'] ?? null,
            'pSo_hc' => $params['pSo_hc'] ?? null,
            'pNgay_cap_hc' => $params['pNgay_cap_hc'] ?? null,
            'pNgay_hh_hc' => $params['pNgay_hh_hc'] ?? null,
            'pNoi_cap_hc' => $params['pNoi_cap_hc'] ?? null,
            'pTrinh_do_pt' => $params['pTrinh_do_pt'] ?? null,
            'pNoi_sinh' => $params['pNoi_sinh'] ?? null,
            'pNoi_sinh_dc' => $params['pNoi_sinh_dc'] ?? null,
            'pNoi_sinh_xa' => $params['pNoi_sinh_xa'] ?? null,
            'pNoi_sinh_huyen' => $params['pNoi_sinh_huyen'] ?? null,
            'pNoi_sinh_tinh' => $params['pNoi_sinh_tinh'] ?? null,
            'pQue_quan' => $params['pQue_quan'] ?? null,
            'pQue_quan_dc' => $params['pQue_quan_dc'] ?? null,
            'pQue_quan_xa' => $params['pQue_quan_xa'] ?? null,
            'pQue_quan_huyen' => $params['pQue_quan_huyen'] ?? null,
            'pQue_quan_tinh' => $params['pQue_quan_tinh'] ?? null,
            'pHo_khau' => $params['pHo_khau'] ?? null,
            'pHo_khau_dc' => $params['pHo_khau_dc'] ?? null,
            'pHo_khau_xa' => $params['pHo_khau_xa'] ?? null,
            'pHo_khau_huyen' => $params['pHo_khau_huyen'] ?? null,
            'pHo_khau_tinh' => $params['pHo_khau_tinh'] ?? null,
            'pNoi_o' => $params['pNoi_o'] ?? null,
            'pNoi_o_dc' => $params['pNoi_o_dc'] ?? null,
            'pNoi_o_xa' => $params['pNoi_o_xa'] ?? null,
            'pNoi_o_huyen' => $params['pNoi_o_huyen'] ?? null,
            'pNoi_o_tinh' => $params['pNoi_o_tinh'] ?? null,
            'pMa_ton_giao' => $params['pMa_ton_giao'] ?? null,
            'pMa_dan_toc' => $params['pMa_dan_toc'] ?? null,
            'pMa_quoc_tich' => $params['pMa_quoc_tich'] ?? null,
            'pMa_dien_csach' => $params['pMa_dien_csach'] ?? null,
            'pMa_nghe' => $params['pMa_nghe'] ?? null,
            'pMa_tdql' => $params['pMa_tdql'] ?? null,
            'pMa_tdct' => $params['pMa_tdct'] ?? null,
            'pSuc_khoe' => $params['pSuc_khoe'] ?? null,
            'pChieu_cao' => $params['pChieu_cao'] ?? null,
            'pCan_nang' => $params['pCan_nang'] ?? null,
            'pNhom_mau' => $params['pNhom_mau'] ?? null,
            'pPhone_mobile' => $params['pPhone_mobile'] ?? null,
            'pPhone_home' => $params['pPhone_home'] ?? null,
            'pPhone_work' => $params['pPhone_work'] ?? null,
            'pPhone_work_ext' => $params['pPhone_work_ext'] ?? null,
            'pPhone_other' => $params['pPhone_other'] ?? null,
            'pEmail_home' => $params['pEmail_home'] ?? null,
            'pEmail_work' => $params['pEmail_work'] ?? null,
            'pEmail_other' => $params['pEmail_other'] ?? null,
            'pHome_page' => $params['pHome_page'] ?? null,
            'pFacebook' => $params['pFacebook'] ?? null,
            'pTwitter' => $params['pTwitter'] ?? null,
            'pLinkedin' => $params['pLinkedin'] ?? null,
            'pPrinterest' => $params['pPrinterest'] ?? null,
            'pSkype' => $params['pSkype'] ?? null,
            'pYahoo' => $params['pYahoo'] ?? null,
            'pNgay_nop_hs' => $params['pNgay_nop_hs'] ?? null,
            'pNgay_thu_viec' => $params['pNgay_thu_viec'] ?? null,
            'pNgay_lvct' => $params['pNgay_lvct'] ?? null,
            'pNgay_bc' => $params['pNgay_bc'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pMa_cvdt' => $params['pMa_cvdt'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pSo_tk_nh' => $params['pSo_tk_nh'] ?? null,
            'pMa_nh' => $params['pMa_nh'] ?? null,
            'pChu_the' => $params['pChu_the'] ?? null,
            'pDong_bhxh' => $params['pDong_bhxh'] ?? null,
            'pSo_sbh' => $params['pSo_sbh'] ?? null,
            'pNgay_cap_sbh' => $params['pNgay_cap_sbh'] ?? null,
            'pMa_tinh_dk_kcb' => $params['pMa_tinh_dk_kcb'] ?? null,
            'pNoi_dk_kcb' => $params['pNoi_dk_kcb'] ?? null,
            'pMa_tthn' => $params['pMa_tthn'] ?? null,
            'pNgay_cuoi' => $params['pNgay_cuoi'] ?? null,
            'pSo_con' => $params['pSo_con'] ?? null,
            'pThoi_viec' => $params['pThoi_viec'] ?? null,
            'pNgay_thoi_viec' => $params['pNgay_thoi_viec'] ?? null,
            'pSo_qd_thoi_viec' => $params['pSo_qd_thoi_viec'] ?? null,
            'pNguoi_qd_thoi_viec' => $params['pNguoi_qd_thoi_viec'] ?? null,
            'pTien_boi_thuong' => $params['pTien_boi_thuong'] ?? null,
            'pMa_thoi_viec' => $params['pMa_thoi_viec'] ?? null,
            'pGoi_lai_lv' => $params['pGoi_lai_lv'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pAnh_dai_dien' => $params['pAnh_dai_dien'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pHsns_type' => $params['pHsns_type'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsHSNS with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Ma_nvns
     * @param string $Ma_uv
     * @param string $Ma_cham_cong
     * @param string $Ho_ten
     * @param string $Ho_dem
     * @param string $Ten
     * @param string $Bi_danh
     * @param string $Ngay_sinh
     * @param string $Gioi_tinh
     * @param string $So_cmnd
     * @param string $Ngay_cap_cmnd
     * @param string $Noi_cap_cmnd
     * @param string $So_hc
     * @param string $Ngay_cap_hc
     * @param string $Ngay_hh_hc
     * @param string $Noi_cap_hc
     * @param string $Trinh_do_pt
     * @param string $Noi_sinh
     * @param string $Noi_sinh_dc
     * @param string $Noi_sinh_xa
     * @param string $Noi_sinh_huyen
     * @param string $Noi_sinh_tinh
     * @param string $Que_quan
     * @param string $Que_quan_dc
     * @param string $Que_quan_xa
     * @param string $Que_quan_huyen
     * @param string $Que_quan_tinh
     * @param string $Ho_khau
     * @param string $Ho_khau_dc
     * @param string $Ho_khau_xa
     * @param string $Ho_khau_huyen
     * @param string $Ho_khau_tinh
     * @param string $Noi_o
     * @param string $Noi_o_dc
     * @param string $Noi_o_xa
     * @param string $Noi_o_huyen
     * @param string $Noi_o_tinh
     * @param string $Ma_ton_giao
     * @param string $Ma_dan_toc
     * @param string $Ma_quoc_tich
     * @param string $Ma_dien_csach
     * @param string $Ma_nghe
     * @param string $Ma_tdql
     * @param string $Ma_tdct
     * @param string $Suc_khoe
     * @param float $Chieu_cao
     * @param float $Can_nang
     * @param string $Nhom_mau
     * @param string $Phone_mobile
     * @param string $Phone_home
     * @param string $Phone_work
     * @param string $Phone_work_ext
     * @param string $Phone_other
     * @param string $Email_home
     * @param string $Email_work
     * @param string $Email_other
     * @param string $Home_page
     * @param string $Facebook
     * @param string $Twitter
     * @param string $Linkedin
     * @param string $Printerest
     * @param string $Skype
     * @param string $Yahoo
     * @param string $Ngay_nop_hs
     * @param string $Ngay_thu_viec
     * @param string $Ngay_lvct
     * @param string $Ngay_bc
     * @param string $Ma_bp
     * @param string $Ma_cvcm
     * @param string $Ma_cvdt
     * @param string $Ma_so_thue
     * @param string $So_tk_nh
     * @param string $Ma_nh
     * @param string $Chu_the
     * @param bool $Dong_bhxh
     * @param string $So_sbh
     * @param string $Ngay_cap_sbh
     * @param string $Ma_tinh_dk_kcb
     * @param string $Noi_dk_kcb
     * @param string $Ma_tthn
     * @param string $Ngay_cuoi
     * @param int $So_con
     * @param bool $Thoi_viec
     * @param string $Ngay_thoi_viec
     * @param string $So_qd_thoi_viec
     * @param string $Nguoi_qd_thoi_viec
     * @param float $Tien_boi_thuong
     * @param string $Ma_thoi_viec
     * @param bool $Goi_lai_lv
     * @param string $Ghi_chu
     * @param string $Anh_dai_dien
     * @param string $Tai_lieu
     * @param string $Hsns_type
     * @param string $Trang_thai
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Ma_nvns = null, string $Ma_uv = null, string $Ma_cham_cong = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Bi_danh = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $So_cmnd = null, string $Ngay_cap_cmnd = null, string $Noi_cap_cmnd = null, string $So_hc = null, string $Ngay_cap_hc = null, string $Ngay_hh_hc = null, string $Noi_cap_hc = null, string $Trinh_do_pt = null, string $Noi_sinh = null, string $Noi_sinh_dc = null, string $Noi_sinh_xa = null, string $Noi_sinh_huyen = null, string $Noi_sinh_tinh = null, string $Que_quan = null, string $Que_quan_dc = null, string $Que_quan_xa = null, string $Que_quan_huyen = null, string $Que_quan_tinh = null, string $Ho_khau = null, string $Ho_khau_dc = null, string $Ho_khau_xa = null, string $Ho_khau_huyen = null, string $Ho_khau_tinh = null, string $Noi_o = null, string $Noi_o_dc = null, string $Noi_o_xa = null, string $Noi_o_huyen = null, string $Noi_o_tinh = null, string $Ma_ton_giao = null, string $Ma_dan_toc = null, string $Ma_quoc_tich = null, string $Ma_dien_csach = null, string $Ma_nghe = null, string $Ma_tdql = null, string $Ma_tdct = null, string $Suc_khoe = null, float $Chieu_cao = null, float $Can_nang = null, string $Nhom_mau = null, string $Phone_mobile = null, string $Phone_home = null, string $Phone_work = null, string $Phone_work_ext = null, string $Phone_other = null, string $Email_home = null, string $Email_work = null, string $Email_other = null, string $Home_page = null, string $Facebook = null, string $Twitter = null, string $Linkedin = null, string $Printerest = null, string $Skype = null, string $Yahoo = null, string $Ngay_nop_hs = null, string $Ngay_thu_viec = null, string $Ngay_lvct = null, string $Ngay_bc = null, string $Ma_bp = null, string $Ma_cvcm = null, string $Ma_cvdt = null, string $Ma_so_thue = null, string $So_tk_nh = null, string $Ma_nh = null, string $Chu_the = null, bool $Dong_bhxh = null, string $So_sbh = null, string $Ngay_cap_sbh = null, string $Ma_tinh_dk_kcb = null, string $Noi_dk_kcb = null, string $Ma_tthn = null, string $Ngay_cuoi = null, int $So_con = null, bool $Thoi_viec = null, string $Ngay_thoi_viec = null, string $So_qd_thoi_viec = null, string $Nguoi_qd_thoi_viec = null, float $Tien_boi_thuong = null, string $Ma_thoi_viec = null, bool $Goi_lai_lv = null, string $Ghi_chu = null, string $Anh_dai_dien = null, string $Tai_lieu = null, string $Hsns_type = null, string $Trang_thai = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pMa_nvns' => $Ma_nvns,
            'pMa_uv' => $Ma_uv,
            'pMa_cham_cong' => $Ma_cham_cong,
            'pHo_ten' => $Ho_ten,
            'pHo_dem' => $Ho_dem,
            'pTen' => $Ten,
            'pBi_danh' => $Bi_danh,
            'pNgay_sinh' => $Ngay_sinh,
            'pGioi_tinh' => $Gioi_tinh,
            'pSo_cmnd' => $So_cmnd,
            'pNgay_cap_cmnd' => $Ngay_cap_cmnd,
            'pNoi_cap_cmnd' => $Noi_cap_cmnd,
            'pSo_hc' => $So_hc,
            'pNgay_cap_hc' => $Ngay_cap_hc,
            'pNgay_hh_hc' => $Ngay_hh_hc,
            'pNoi_cap_hc' => $Noi_cap_hc,
            'pTrinh_do_pt' => $Trinh_do_pt,
            'pNoi_sinh' => $Noi_sinh,
            'pNoi_sinh_dc' => $Noi_sinh_dc,
            'pNoi_sinh_xa' => $Noi_sinh_xa,
            'pNoi_sinh_huyen' => $Noi_sinh_huyen,
            'pNoi_sinh_tinh' => $Noi_sinh_tinh,
            'pQue_quan' => $Que_quan,
            'pQue_quan_dc' => $Que_quan_dc,
            'pQue_quan_xa' => $Que_quan_xa,
            'pQue_quan_huyen' => $Que_quan_huyen,
            'pQue_quan_tinh' => $Que_quan_tinh,
            'pHo_khau' => $Ho_khau,
            'pHo_khau_dc' => $Ho_khau_dc,
            'pHo_khau_xa' => $Ho_khau_xa,
            'pHo_khau_huyen' => $Ho_khau_huyen,
            'pHo_khau_tinh' => $Ho_khau_tinh,
            'pNoi_o' => $Noi_o,
            'pNoi_o_dc' => $Noi_o_dc,
            'pNoi_o_xa' => $Noi_o_xa,
            'pNoi_o_huyen' => $Noi_o_huyen,
            'pNoi_o_tinh' => $Noi_o_tinh,
            'pMa_ton_giao' => $Ma_ton_giao,
            'pMa_dan_toc' => $Ma_dan_toc,
            'pMa_quoc_tich' => $Ma_quoc_tich,
            'pMa_dien_csach' => $Ma_dien_csach,
            'pMa_nghe' => $Ma_nghe,
            'pMa_tdql' => $Ma_tdql,
            'pMa_tdct' => $Ma_tdct,
            'pSuc_khoe' => $Suc_khoe,
            'pChieu_cao' => $Chieu_cao,
            'pCan_nang' => $Can_nang,
            'pNhom_mau' => $Nhom_mau,
            'pPhone_mobile' => $Phone_mobile,
            'pPhone_home' => $Phone_home,
            'pPhone_work' => $Phone_work,
            'pPhone_work_ext' => $Phone_work_ext,
            'pPhone_other' => $Phone_other,
            'pEmail_home' => $Email_home,
            'pEmail_work' => $Email_work,
            'pEmail_other' => $Email_other,
            'pHome_page' => $Home_page,
            'pFacebook' => $Facebook,
            'pTwitter' => $Twitter,
            'pLinkedin' => $Linkedin,
            'pPrinterest' => $Printerest,
            'pSkype' => $Skype,
            'pYahoo' => $Yahoo,
            'pNgay_nop_hs' => $Ngay_nop_hs,
            'pNgay_thu_viec' => $Ngay_thu_viec,
            'pNgay_lvct' => $Ngay_lvct,
            'pNgay_bc' => $Ngay_bc,
            'pMa_bp' => $Ma_bp,
            'pMa_cvcm' => $Ma_cvcm,
            'pMa_cvdt' => $Ma_cvdt,
            'pMa_so_thue' => $Ma_so_thue,
            'pSo_tk_nh' => $So_tk_nh,
            'pMa_nh' => $Ma_nh,
            'pChu_the' => $Chu_the,
            'pDong_bhxh' => $Dong_bhxh,
            'pSo_sbh' => $So_sbh,
            'pNgay_cap_sbh' => $Ngay_cap_sbh,
            'pMa_tinh_dk_kcb' => $Ma_tinh_dk_kcb,
            'pNoi_dk_kcb' => $Noi_dk_kcb,
            'pMa_tthn' => $Ma_tthn,
            'pNgay_cuoi' => $Ngay_cuoi,
            'pSo_con' => $So_con,
            'pThoi_viec' => $Thoi_viec,
            'pNgay_thoi_viec' => $Ngay_thoi_viec,
            'pSo_qd_thoi_viec' => $So_qd_thoi_viec,
            'pNguoi_qd_thoi_viec' => $Nguoi_qd_thoi_viec,
            'pTien_boi_thuong' => $Tien_boi_thuong,
            'pMa_thoi_viec' => $Ma_thoi_viec,
            'pGoi_lai_lv' => $Goi_lai_lv,
            'pGhi_chu' => $Ghi_chu,
            'pAnh_dai_dien' => $Anh_dai_dien,
            'pTai_lieu' => $Tai_lieu,
            'pHsns_type' => $Hsns_type,
            'pTrang_thai' => $Trang_thai,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
