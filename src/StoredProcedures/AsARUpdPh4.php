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

class AsARUpdPh4
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdPh4', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pNt_ph' => $paramObj->pNt_ph ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien' => $paramObj->pT_tien ?? null,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
