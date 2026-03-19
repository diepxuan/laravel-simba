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

class AsFaInsBHCC
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaInsBHCC', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_cc' => $paramObj->pMa_cc ?? null,
            'pstt_rec' => $paramObj->pstt_rec ?? null,
            'pstt_rec0' => $paramObj->pstt_rec0 ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pTen_cc' => $paramObj->pTen_cc ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pDon_gia' => $paramObj->pDon_gia ?? null,
            'pNgay_giam' => $paramObj->pNgay_giam ?? null,
            'pmoduleid' => $paramObj->pmoduleid ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pTk_cp' => $paramObj->pTk_cp ?? null,
            'pTk_cc' => $paramObj->pTk_cc ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pGt_da_Kh' => $paramObj->pGt_da_Kh ?? null,
        ], $connection);
    }
}
