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

class AsCAUpdDMKU
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdDMKU', [
            'pMa_cty'       => $paramObj->pMa_cty ?? null,
            'pMa_ku'        => $paramObj->pMa_ku ?? null,
            'pTen_ku'       => $paramObj->pTen_ku ?? null,
            'pSo_ku'        => $paramObj->pSo_ku ?? null,
            'pNgay_vay'     => $paramObj->pNgay_vay ?? null,
            'pNgay_ky'      => $paramObj->pNgay_ky ?? null,
            'pThoi_han'     => $paramObj->pThoi_han ?? null,
            'pTinh_theo'    => $paramObj->pTinh_theo ?? null,
            'pPhuong_phap'  => $paramObj->pPhuong_phap ?? null,
            'pKy_tt_goc'    => $paramObj->pKy_tt_goc ?? null,
            'pKy_tt_lai'    => $paramObj->pKy_tt_lai ?? null,
            'pNgay_dh'      => $paramObj->pNgay_dh ?? null,
            'pMa_hd'        => $paramObj->pMa_hd ?? null,
            'pMa_nt'        => $paramObj->pMa_nt ?? null,
            'pTien_nt'      => $paramObj->pTien_nt ?? null,
            'pTien'         => $paramObj->pTien ?? null,
            'pLai_suat'     => $paramObj->pLai_suat ?? null,
            'pLs_qh'        => $paramObj->pLs_qh ?? null,
            'pTk_vay'       => $paramObj->pTk_vay ?? null,
            'pTk_cp'        => $paramObj->pTk_cp ?? null,
            'pTk_cp_pt'     => $paramObj->pTk_cp_pt ?? null,
            'pGhi_chu'      => $paramObj->pGhi_chu ?? null,
            'pKsd'          => $paramObj->pKsd ?? null,
            'pLUser'        => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
