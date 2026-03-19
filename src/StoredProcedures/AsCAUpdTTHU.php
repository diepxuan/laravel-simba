<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsCAUpdTTHU
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdTTHU', [
            'pMa_cty'         => $paramObj->pMa_cty ?? null,
            'pStt_rec'        => $paramObj->pStt_rec ?? null,
            'pMa_ct'          => $paramObj->pMa_ct ?? null,
            'pNgay_ct'        => $paramObj->pNgay_ct ?? null,
            'pSo_ct'          => $paramObj->pSo_ct ?? null,
            'pMa_ct_tt'       => $paramObj->pMa_ct_tt ?? null,
            'pStt_rec_tt'     => $paramObj->pStt_rec_tt ?? null,
            'pNgay_ct_tt'     => $paramObj->pNgay_ct_tt ?? null,
            'pSo_ct_tt'       => $paramObj->pSo_ct_tt ?? null,
            'pMa_KH'          => $paramObj->pMa_KH ?? null,
            'pTk_tu'          => $paramObj->pTk_tu ?? null,
            'pMa_nt'          => $paramObj->pMa_nt ?? null,
            'pTy_gia'         => $paramObj->pTy_gia ?? null,
            'pTien_pc'        => $paramObj->pTien_pc ?? null,
            'pTien_pc_nt'     => $paramObj->pTien_pc_nt ?? null,
            'pTien_da_tt'     => $paramObj->pTien_da_tt ?? null,
            'pTien_da_tt_nt'  => $paramObj->pTien_da_tt_nt ?? null,
            'pTat_toan'       => $paramObj->pTat_toan ?? null,
            'pDien_giai'      => $paramObj->pDien_giai ?? null,
            'pLUser'          => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
