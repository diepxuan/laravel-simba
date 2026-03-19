<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPUpdTT
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPUpdTT', [
            'pMa_cty'        => $paramObj->pMa_cty ?? null,
            'pStt_rec'       => $paramObj->pStt_rec ?? null,
            'pMa_ct'         => $paramObj->pMa_ct ?? null,
            'pNgay_ct'       => $paramObj->pNgay_ct ?? null,
            'pSo_ct'         => $paramObj->pSo_ct ?? null,
            'pMa_KH'         => $paramObj->pMa_KH ?? null,
            'pTk_pt'         => $paramObj->pTk_pt ?? null,
            'pMa_nt'         => $paramObj->pMa_nt ?? null,
            'pTy_gia'        => $paramObj->pTy_gia ?? 0.0,
            'pT_tien0'       => $paramObj->pT_tien0 ?? 0.0,
            'pT_tien_nt0'    => $paramObj->pT_tien_nt0 ?? 0.0,
            'pT_thue'        => $paramObj->pT_thue ?? 0.0,
            'pT_thue_nt'     => $paramObj->pT_thue_nt ?? 0.0,
            'pT_tt'          => $paramObj->pT_tt ?? 0.0,
            'pT_tt_nt'       => $paramObj->pT_tt_nt ?? 0.0,
            'pNgay_tt'       => $paramObj->pNgay_tt ?? null,
            'pMa_tt_po'      => $paramObj->pMa_tt_po ?? null,
            'pHan_ck'        => $paramObj->pHan_ck ?? 0.0,
            'pTl_ck'         => $paramObj->pTl_ck ?? 0.0,
            'pHan_tt'        => $paramObj->pHan_tt ?? 0.0,
            'pLs_qh'         => $paramObj->pLs_qh ?? 0.0,
            'pMa_hd'         => $paramObj->pMa_hd ?? null,
            'pDien_giai'     => $paramObj->pDien_giai ?? null,
            'pStt_rec_tt'    => $paramObj->pStt_rec_tt ?? null,
            'pNgay_ct_tt'    => $paramObj->pNgay_ct_tt ?? null,
            'pMa_ct_tt'      => $paramObj->pMa_ct_tt ?? null,
            'pSo_ct_tt'      => $paramObj->pSo_ct_tt ?? null,
            'pTien_da_tt_nt' => $paramObj->pTien_da_tt_nt ?? 0.0,
            'pTien_da_tt'    => $paramObj->pTien_da_tt ?? 0.0,
            'pDu_hd'         => $paramObj->pDu_hd ?? 0.0,
            'pDu_hd_nt'      => $paramObj->pDu_hd_nt ?? 0.0,
            'pLUser'         => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
