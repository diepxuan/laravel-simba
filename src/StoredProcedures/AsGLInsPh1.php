<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLInsPh1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsPh1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pNt_ph' => $params['pNt_ph'] ?? null,
            'pKht_thue_vao' => $params['pKht_thue_vao'] ?? null,
            'pKht_thue_ra' => $params['pKht_thue_ra'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pT_thue_vao' => $params['pT_thue_vao'] ?? null,
            'pT_thue_ra' => $params['pT_thue_ra'] ?? null,
            'pT_thue_vao_nt' => $params['pT_thue_vao_nt'] ?? null,
            'pT_thue_ra_nt' => $params['pT_thue_ra_nt'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pUser' => $params['pUser'] ?? null
        ], $connection);
    }
}
