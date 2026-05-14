<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-14 09:12:33
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPOSavePO3.
 *
 * Stored procedure: asPOSavePO3
 * Mục đích: Lưu hóa đơn mua hàng (PO3) - bao gồm header, detail, chi phí và hạch toán.
 */
class AsPOSavePO3
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOSavePO3', [
            'pMa_cty'         => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec'        => $paramObj->pStt_rec ?? null,
            'pMa_ct'          => $paramObj->pMa_ct ?? 'PO3',
            'pMa_gd'          => $paramObj->pMa_gd ?? null,
            'pMau_hd'         => $paramObj->pMau_hd ?? null,
            'pMa_kh'          => $paramObj->pMa_kh ?? null,
            'pDia_chi'        => $paramObj->pDia_chi ?? null,
            'pNguoi_gd'       => $paramObj->pNguoi_gd ?? null,
            'pMa_httt'        => $paramObj->pMa_httt ?? null,
            'pTk_pt'          => $paramObj->pTk_pt ?? null,
            'pTk_ck_ds'       => $paramObj->pTk_ck_ds ?? null,
            'pDien_giai'      => $paramObj->pDien_giai ?? null,
            'pSo_seri'        => $paramObj->pSo_seri ?? null,
            'pSo_ct'          => $paramObj->pSo_ct ?? null,
            'pNgay_ct'        => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'       => $paramObj->pNgay_lct ?? null,
            'pKht_tain'       => $paramObj->pKht_tain ?? 0,
            'pNgay_pn'        => $paramObj->pNgay_pn ?? null,
            'pSo_pn'          => $paramObj->pSo_pn ?? null,
            'pNgay_hd'        => $paramObj->pNgay_hd ?? null,
            'pSo_hd'          => $paramObj->pSo_hd ?? null,
            'pMa_tt_po'       => $paramObj->pMa_tt_po ?? null,
            'pHan_ck'         => $paramObj->pHan_ck ?? 0,
            'pTl_ck'          => $paramObj->pTl_ck ?? 0,
            'pHan_tt'         => $paramObj->pHan_tt ?? 0,
            'pLs_qh'          => $paramObj->pLs_qh ?? 0,
            'pMa_nt'          => $paramObj->pMa_nt ?? 'VND',
            'pTy_gia'         => $paramObj->pTy_gia ?? 1,
            'pT_tien_nt0'     => $paramObj->pT_tien_nt0 ?? 0,
            'pT_tien0'        => $paramObj->pT_tien0 ?? 0,
            'pTs_nk'          => $paramObj->pTs_nk ?? 0,
            'pT_thue_nk_nt'   => $paramObj->pT_thue_nk_nt ?? 0,
            'pT_thue_nk'      => $paramObj->pT_thue_nk ?? 0,
            'pTs_ttdb'        => $paramObj->pTs_ttdb ?? 0,
            'pT_thue_ttdb_nt' => $paramObj->pT_thue_ttdb_nt ?? 0,
            'pT_thue_ttdb'    => $paramObj->pT_thue_ttdb ?? 0,
            'pT_cp_nt'        => $paramObj->pT_cp_nt ?? 0,
            'pT_cp'           => $paramObj->pT_cp ?? 0,
            'pT_tien_nt'      => $paramObj->pT_tien_nt ?? 0,
            'pT_tien'         => $paramObj->pT_tien ?? 0,
            'pT_thue_nt'      => $paramObj->pT_thue_nt ?? 0,
            'pT_thue'         => $paramObj->pT_thue ?? 0,
            'pTl_ck_hd'       => $paramObj->pTl_ck_hd ?? 0,
            'pT_ck'           => $paramObj->pT_ck ?? 0,
            'pT_ck_nt'        => $paramObj->pT_ck_nt ?? 0,
            'pT_tt'           => $paramObj->pT_tt ?? 0,
            'pT_tt_nt'        => $paramObj->pT_tt_nt ?? 0,
            'pT_so_luong'     => $paramObj->pT_so_luong ?? 0,
            'pCk_st'          => $paramObj->pCk_st ?? 0,
            'pSua_tien'       => $paramObj->pSua_tien ?? 0,
            'pSua_thue'       => $paramObj->pSua_thue ?? 0,
            'pSua_thue_nk'    => $paramObj->pSua_thue_nk ?? 0,
            'pSua_thue_ttdb'  => $paramObj->pSua_thue_ttdb ?? 0,
            'pSua_tt'         => $paramObj->pSua_tt ?? 0,
            'pTao_tu_pn'      => $paramObj->pTao_tu_pn ?? 0,
            'pTao_tu_dh'      => $paramObj->pTao_tu_dh ?? 0,
            'pTrang_thai'     => $paramObj->pTrang_thai ?? null,
            'pGhi_chu'        => $paramObj->pGhi_chu ?? null,
            'pPost2gl'        => $paramObj->pPost2gl ?? 0,
            'pPost2in'        => $paramObj->pPost2in ?? 0,
            'pCuser'          => $paramObj->pCuser ?? null,
            'pLuser'          => $paramObj->pLuser ?? null,
            'pChiTiet'        => $paramObj->pChiTiet ?? [],
            'pChiPhi'         => $paramObj->pChiPhi ?? [],
            'pRet'            => ['type' => 'INT', 'output' => true],
        ], $connection);
    }
}
