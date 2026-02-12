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

class AsSoInsPh1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoInsPh1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTen_kh_vat' => $params['pTen_kh_vat'] ?? null,
            'pDia_chi_vat' => $params['pDia_chi_vat'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_hh' => $params['pNgay_hh'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pCk_st' => $params['pCk_st'] ?? null,
            'pGia_st' => $params['pGia_st'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pTk_ck_ds' => $params['pTk_ck_ds'] ?? null,
            'pT_tien2' => $params['pT_tien2'] ?? null,
            'pT_tien_nt2' => $params['pT_tien_nt2'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pT_ck' => $params['pT_ck'] ?? null,
            'pT_ck_nt' => $params['pT_ck_nt'] ?? null,
            'pTl_ck_ds' => $params['pTl_ck_ds'] ?? null,
            'pT_ck_ds' => $params['pT_ck_ds'] ?? null,
            'pT_ck_ds_nt' => $params['pT_ck_ds_nt'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pt_so_luong' => $params['pt_so_luong'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
