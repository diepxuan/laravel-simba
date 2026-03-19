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
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLInsPh1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsPh1', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pNt_ph' => $paramObj->pNt_ph ?? null,
            'pKht_thue_vao' => $paramObj->pKht_thue_vao ?? null,
            'pKht_thue_ra' => $paramObj->pKht_thue_ra ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien' => $paramObj->pT_tien ?? null,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? null,
            'pT_thue_vao' => $paramObj->pT_thue_vao ?? null,
            'pT_thue_ra' => $paramObj->pT_thue_ra ?? null,
            'pT_thue_vao_nt' => $paramObj->pT_thue_vao_nt ?? null,
            'pT_thue_ra_nt' => $paramObj->pT_thue_ra_nt ?? null,
            'pT_tt' => $paramObj->pT_tt ?? null,
            'pT_tt_nt' => $paramObj->pT_tt_nt ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pUser' => $paramObj->pUser ?? null
        ], $connection);
    }
}
