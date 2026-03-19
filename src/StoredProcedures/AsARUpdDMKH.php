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

class AsARUpdDMKH
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdDMKH', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pLoai' => $paramObj->pLoai ?? null,
            'pTen_kh' => $paramObj->pTen_kh ?? null,
            'pMa_so_thue' => $paramObj->pMa_so_thue ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pTel' => $paramObj->pTel ?? null,
            'pFax' => $paramObj->pFax ?? null,
            'pEmail' => $paramObj->pEmail ?? null,
            'pHome_page' => $paramObj->pHome_page ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pMa_ngh' => $paramObj->pMa_ngh ?? null,
            'pTen_nh' => $paramObj->pTen_nh ?? null,
            'pCn_nh' => $paramObj->pCn_nh ?? null,
            'pSo_tk_nh' => $paramObj->pSo_tk_nh ?? null,
            'pTinh_tp_nh' => $paramObj->pTinh_tp_nh ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_tt' => $paramObj->pMa_tt ?? null,
            'pMa_httt' => $paramObj->pMa_httt ?? null,
            'pMa_httt_po' => $paramObj->pMa_httt_po ?? null,
            'pGh_no' => $paramObj->pGh_no ?? null,
            'pHan_ck' => $paramObj->pHan_ck ?? null,
            'pTl_ck' => $paramObj->pTl_ck ?? null,
            'pHan_tt' => $paramObj->pHan_tt ?? null,
            'pLs_qh' => $paramObj->pLs_qh ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTinh_dt_nb' => $paramObj->pTinh_dt_nb ?? null,
            'pIskh' => $paramObj->pIskh ?? null,
            'pIsncc' => $paramObj->pIsncc ?? null,
            'pIsnv' => $paramObj->pIsnv ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
