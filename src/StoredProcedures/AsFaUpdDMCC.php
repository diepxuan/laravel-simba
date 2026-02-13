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

class AsFaUpdDMCC
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdDMCC', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pModuleid' => $params['pModuleid'] ?? null,
            'pID' => $params['pID'] ?? null,
            'pMa_cc' => $params['pMa_cc'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pTen_cc' => $params['pTen_cc'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pDon_gia' => $params['pDon_gia'] ?? null,
            'pNg_gia' => $params['pNg_gia'] ?? null,
            'pGt_da_kh' => $params['pGt_da_kh'] ?? null,
            'pGt_cl' => $params['pGt_cl'] ?? null,
            'pKy_pb' => $params['pKy_pb'] ?? null,
            'pSo_ky' => $params['pSo_ky'] ?? null,
            'pKh_ky' => $params['pKh_ky'] ?? null,
            'pNgay_bdkh' => $params['pNgay_bdkh'] ?? null,
            'pNgay_gt_cl' => $params['pNgay_gt_cl'] ?? null,
            'pTk_cc' => $params['pTk_cc'] ?? null,
            'pTk_cp' => $params['pTk_cp'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pTinh_kh' => $params['pTinh_kh'] ?? null,
            'pSua_kh' => $params['pSua_kh'] ?? null,
            'pCUser' => $params['pCUser'] ?? null,
        ], $connection);
    }
}
