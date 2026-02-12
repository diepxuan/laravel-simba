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

class AsCAUpdDMKU
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdDMKU', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pMa_ku'        => $params['pMa_ku'] ?? null,
            'pTen_ku'       => $params['pTen_ku'] ?? null,
            'pSo_ku'        => $params['pSo_ku'] ?? null,
            'pNgay_vay'     => $params['pNgay_vay'] ?? null,
            'pNgay_ky'      => $params['pNgay_ky'] ?? null,
            'pThoi_han'     => $params['pThoi_han'] ?? null,
            'pTinh_theo'    => $params['pTinh_theo'] ?? null,
            'pPhuong_phap'  => $params['pPhuong_phap'] ?? null,
            'pKy_tt_goc'    => $params['pKy_tt_goc'] ?? null,
            'pKy_tt_lai'    => $params['pKy_tt_lai'] ?? null,
            'pNgay_dh'      => $params['pNgay_dh'] ?? null,
            'pMa_hd'        => $params['pMa_hd'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTien_nt'      => $params['pTien_nt'] ?? null,
            'pTien'         => $params['pTien'] ?? null,
            'pLai_suat'     => $params['pLai_suat'] ?? null,
            'pLs_qh'        => $params['pLs_qh'] ?? null,
            'pTk_vay'       => $params['pTk_vay'] ?? null,
            'pTk_cp'        => $params['pTk_cp'] ?? null,
            'pTk_cp_pt'     => $params['pTk_cp_pt'] ?? null,
            'pGhi_chu'      => $params['pGhi_chu'] ?? null,
            'pKsd'          => $params['pKsd'] ?? null,
            'pLUser'        => $params['pLUser'] ?? null,
        ], $connection);
    }
}
