<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARInsDMKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsDMKH', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pLoai'         => $params['pLoai'] ?? null,
            'pTen_kh'       => $params['pTen_kh'] ?? null,
            'pMa_so_thue'   => $params['pMa_so_thue'] ?? null,
            'pDia_chi'      => $params['pDia_chi'] ?? null,
            'pTel'          => $params['pTel'] ?? null,
            'pFax'          => $params['pFax'] ?? null,
            'pEmail'        => $params['pEmail'] ?? null,
            'pHome_page'    => $params['pHome_page'] ?? null,
            'pNguoi_gd'     => $params['pNguoi_gd'] ?? null,
            'pMa_ngh'       => $params['pMa_ngh'] ?? null,
            'pTen_nh'       => $params['pTen_nh'] ?? null,
            'pCn_nh'        => $params['pCn_nh'] ?? null,
            'pSo_tk_nh'     => $params['pSo_tk_nh'] ?? null,
            'pTinh_tp_nh'   => $params['pTinh_tp_nh'] ?? null,
            'pTk'           => $params['pTk'] ?? null,
            'pMa_plkh1'     => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2'     => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3'     => $params['pMa_plkh3'] ?? null,
            'pMa_nhkh'      => $params['pMa_nhkh'] ?? null,
            'pMa_tt'        => $params['pMa_tt'] ?? null,
            'pMa_httt'      => $params['pMa_httt'] ?? null,
            'pMa_httt_po'   => $params['pMa_httt_po'] ?? null,
            'pGh_no'        => $params['pGh_no'] ?? null,
            'pHan_ck'       => $params['pHan_ck'] ?? null,
            'pTl_ck'        => $params['pTl_ck'] ?? null,
            'pHan_tt'       => $params['pHan_tt'] ?? null,
            'pLs_qh'        => $params['pLs_qh'] ?? null,
            'pGhi_chu'      => $params['pGhi_chu'] ?? null,
            'pTinh_dt_nb'   => $params['pTinh_dt_nb'] ?? null,
            'pIskh'         => $params['pIskh'] ?? null,
            'pIsncc'        => $params['pIsncc'] ?? null,
            'pIsnv'         => $params['pIsnv'] ?? null,
            'pKsd'          => $params['pKsd'] ?? null,
            'pLUser'        => $params['pLUser'] ?? null,
        ], $connection);
    }
}
