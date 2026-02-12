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

class ZasSOUpdCT3
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('zasSOUpdCT3', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            'pStt_rec0'  => $params['pStt_rec0'] ?? null,
            'pStt_rec_dh'  => $params['pStt_rec_dh'] ?? null,
            'pStt_rec0_dh'  => $params['pStt_rec0_dh'] ?? null,
            'pStt_rec_px'  => $params['pStt_rec_px'] ?? null,
            'pStt_rec0_px'  => $params['pStt_rec0_px'] ?? null,
            'pSo_dh'  => $params['pSo_dh'] ?? null,
            'pSo_px'  => $params['pSo_px'] ?? null,
            'pMa_kho'  => $params['pMa_kho'] ?? null,
            'pMa_vt'  => $params['pMa_vt'] ?? null,
            'pTen_vt'  => $params['pTen_vt'] ?? null,
            'pDvt'  => $params['pDvt'] ?? null,
            'pSo_luong'  => $params['pSo_luong'] ?? null,
            'pSo_luong_qd'  => $params['pSo_luong_qd'] ?? null,
            'pGia_nt2'  => $params['pGia_nt2'] ?? null,
            'pGia2'  => $params['pGia2'] ?? null,
            'pTien_nt2'  => $params['pTien_nt2'] ?? null,
            'pTien2'  => $params['pTien2'] ?? null,
            'pTl_ck'  => $params['pTl_ck'] ?? null,
            'pTien_ck_nt'  => $params['pTien_ck_nt'] ?? null,
            'pTien_ck'  => $params['pTien_ck'] ?? null,
            'pCk_ds'  => $params['pCk_ds'] ?? null,
            'pCk_ds_nt'  => $params['pCk_ds_nt'] ?? null,
            'pTs_gtgt'  => $params['pTs_gtgt'] ?? null,
            'pThue_gtgt_nt'  => $params['pThue_gtgt_nt'] ?? null,
            'pThue_gtgt'  => $params['pThue_gtgt'] ?? null,
            'pTt_nt'  => $params['pTt_nt'] ?? null,
            'pTt'  => $params['pTt'] ?? null,
            'pMa_nvkd'  => $params['pMa_nvkd'] ?? null,
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pMa_hd'  => $params['pMa_hd'] ?? null,
            'pMa_phi'  => $params['pMa_phi'] ?? null,
            'pMa_vitri'  => $params['pMa_vitri'] ?? null,
            'pMa_lo'  => $params['pMa_lo'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pTk_pt'  => $params['pTk_pt'] ?? null,
            'pTk_thue'  => $params['pTk_thue'] ?? null,
            'pTk_dt'  => $params['pTk_dt'] ?? null,
            'pTk_gv'  => $params['pTk_gv'] ?? null,
            'pTk_vt'  => $params['pTk_vt'] ?? null,
            'pTk_ck'  => $params['pTk_ck'] ?? null,
            'pKhuyen_mai'  => $params['pKhuyen_mai'] ?? null,
            'pTra_ck'  => $params['pTra_ck'] ?? null,
            'pSl_xuat'  => $params['pSl_xuat'] ?? null,
            'pSl_xuat_qd'  => $params['pSl_xuat_qd'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
