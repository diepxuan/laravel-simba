<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsFaInsDMCC
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaInsDMCC', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_cc' => $paramObj->pMa_cc ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pTen_cc' => $paramObj->pTen_cc ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pDon_gia' => $paramObj->pDon_gia ?? null,
            'pNg_gia' => $paramObj->pNg_gia ?? null,
            'pGt_da_kh' => $paramObj->pGt_da_kh ?? null,
            'pGt_cl' => $paramObj->pGt_cl ?? null,
            'pKy_pb' => $paramObj->pKy_pb ?? null,
            'pSo_ky' => $paramObj->pSo_ky ?? null,
            'pKh_ky' => $paramObj->pKh_ky ?? null,
            'pNgay_bdkh' => $paramObj->pNgay_bdkh ?? null,
            'pNgay_gt_cl' => $paramObj->pNgay_gt_cl ?? null,
            'pTk_cc' => $paramObj->pTk_cc ?? null,
            'pTk_cp' => $paramObj->pTk_cp ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pTinh_kh' => $paramObj->pTinh_kh ?? null,
            'pSua_kh' => $paramObj->pSua_kh ?? null,
            'pCUser' => $paramObj->pCUser ?? null,
        ], $connection);
    }
}
