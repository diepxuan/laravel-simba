<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSoInsPh1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoInsPh1', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pTen_kh_vat' => $paramObj->pTen_kh_vat ?? null,
            'pDia_chi_vat' => $paramObj->pDia_chi_vat ?? null,
            'pMa_so_thue' => $paramObj->pMa_so_thue ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_hh' => $paramObj->pNgay_hh ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pCk_st' => $paramObj->pCk_st ?? null,
            'pGia_st' => $paramObj->pGia_st ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pTk_thue' => $paramObj->pTk_thue ?? null,
            'pTk_ck_ds' => $paramObj->pTk_ck_ds ?? null,
            'pT_tien2' => $paramObj->pT_tien2 ?? null,
            'pT_tien_nt2' => $paramObj->pT_tien_nt2 ?? null,
            'pT_thue' => $paramObj->pT_thue ?? null,
            'pT_thue_nt' => $paramObj->pT_thue_nt ?? null,
            'pT_ck' => $paramObj->pT_ck ?? null,
            'pT_ck_nt' => $paramObj->pT_ck_nt ?? null,
            'pTl_ck_ds' => $paramObj->pTl_ck_ds ?? null,
            'pT_ck_ds' => $paramObj->pT_ck_ds ?? null,
            'pT_ck_ds_nt' => $paramObj->pT_ck_ds_nt ?? null,
            'pT_tt' => $paramObj->pT_tt ?? null,
            'pT_tt_nt' => $paramObj->pT_tt_nt ?? null,
            'pt_so_luong' => $paramObj->pt_so_luong ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null,
        ], $connection);
    }
}
