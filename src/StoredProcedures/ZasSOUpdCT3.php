<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class ZasSOUpdCT3
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('zasSOUpdCT3', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec'  => $paramObj->pStt_rec ?? null,
            'pStt_rec0'  => $paramObj->pStt_rec0 ?? null,
            'pStt_rec_dh'  => $paramObj->pStt_rec_dh ?? null,
            'pStt_rec0_dh'  => $paramObj->pStt_rec0_dh ?? null,
            'pStt_rec_px'  => $paramObj->pStt_rec_px ?? null,
            'pStt_rec0_px'  => $paramObj->pStt_rec0_px ?? null,
            'pSo_dh'  => $paramObj->pSo_dh ?? null,
            'pSo_px'  => $paramObj->pSo_px ?? null,
            'pMa_kho'  => $paramObj->pMa_kho ?? null,
            'pMa_vt'  => $paramObj->pMa_vt ?? null,
            'pTen_vt'  => $paramObj->pTen_vt ?? null,
            'pDvt'  => $paramObj->pDvt ?? null,
            'pSo_luong'  => $paramObj->pSo_luong ?? null,
            'pSo_luong_qd'  => $paramObj->pSo_luong_qd ?? null,
            'pGia_nt2'  => $paramObj->pGia_nt2 ?? null,
            'pGia2'  => $paramObj->pGia2 ?? null,
            'pTien_nt2'  => $paramObj->pTien_nt2 ?? null,
            'pTien2'  => $paramObj->pTien2 ?? null,
            'pTl_ck'  => $paramObj->pTl_ck ?? null,
            'pTien_ck_nt'  => $paramObj->pTien_ck_nt ?? null,
            'pTien_ck'  => $paramObj->pTien_ck ?? null,
            'pCk_ds'  => $paramObj->pCk_ds ?? null,
            'pCk_ds_nt'  => $paramObj->pCk_ds_nt ?? null,
            'pTs_gtgt'  => $paramObj->pTs_gtgt ?? null,
            'pThue_gtgt_nt'  => $paramObj->pThue_gtgt_nt ?? null,
            'pThue_gtgt'  => $paramObj->pThue_gtgt ?? null,
            'pTt_nt'  => $paramObj->pTt_nt ?? null,
            'pTt'  => $paramObj->pTt ?? null,
            'pMa_nvkd'  => $paramObj->pMa_nvkd ?? null,
            'pMa_bp'  => $paramObj->pMa_bp ?? null,
            'pMa_hd'  => $paramObj->pMa_hd ?? null,
            'pMa_phi'  => $paramObj->pMa_phi ?? null,
            'pMa_vitri'  => $paramObj->pMa_vitri ?? null,
            'pMa_lo'  => $paramObj->pMa_lo ?? null,
            'pMa_spct'  => $paramObj->pMa_spct ?? null,
            'pTk_pt'  => $paramObj->pTk_pt ?? null,
            'pTk_thue'  => $paramObj->pTk_thue ?? null,
            'pTk_dt'  => $paramObj->pTk_dt ?? null,
            'pTk_gv'  => $paramObj->pTk_gv ?? null,
            'pTk_vt'  => $paramObj->pTk_vt ?? null,
            'pTk_ck'  => $paramObj->pTk_ck ?? null,
            'pKhuyen_mai'  => $paramObj->pKhuyen_mai ?? null,
            'pTra_ck'  => $paramObj->pTra_ck ?? null,
            'pSl_xuat'  => $paramObj->pSl_xuat ?? null,
            'pSl_xuat_qd'  => $paramObj->pSl_xuat_qd ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
