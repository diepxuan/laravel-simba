<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARUpdTT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdTT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pMa_KH' => $paramObj->pMa_KH ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien2' => $paramObj->pT_tien2 ?? null,
            'pT_tien_nt2' => $paramObj->pT_tien_nt2 ?? null,
            'pT_thue' => $paramObj->pT_thue ?? null,
            'pT_thue_nt' => $paramObj->pT_thue_nt ?? null,
            'pT_tt' => $paramObj->pT_tt ?? null,
            'pT_tt_nt' => $paramObj->pT_tt_nt ?? null,
            'pTien_tt' => $paramObj->pTien_tt ?? null,
            'pTien_tt_nt' => $paramObj->pTien_tt_nt ?? null,
            'pNgay_tt' => $paramObj->pNgay_tt ?? null,
            'pMa_tt' => $paramObj->pMa_tt ?? null,
            'pHan_ck' => $paramObj->pHan_ck ?? null,
            'pTl_ck' => $paramObj->pTl_ck ?? null,
            'pHan_tt' => $paramObj->pHan_tt ?? null,
            'pLs_qh' => $paramObj->pLs_qh ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pStt_rec_tt' => $paramObj->pStt_rec_tt ?? null,
            'pNgay_ct_tt' => $paramObj->pNgay_ct_tt ?? null,
            'pMa_ct_tt' => $paramObj->pMa_ct_tt ?? null,
            'pSo_ct_tt' => $paramObj->pSo_ct_tt ?? null,
            'pTien_da_tt_nt' => $paramObj->pTien_da_tt_nt ?? null,
            'pTien_da_tt' => $paramObj->pTien_da_tt ?? null,
            'pDu_hd' => $paramObj->pDu_hd ?? null,
            'pDu_hd_nt' => $paramObj->pDu_hd_nt ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
