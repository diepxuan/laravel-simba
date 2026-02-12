<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsTaInsOut
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTaInsOut', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pStt_rec' => $params['pStt_rec'] ?? '',
            'pStt_rec0' => $params['pStt_rec0'] ?? '',
            'pMa_ct' => $params['pMa_ct'] ?? '',
            'pNgay_ct' => $params['pNgay_ct'] ?? '',
            'pThang' => $params['pThang'] ?? '',
            'pNam' => $params['pNam'] ?? '',
            'pSo_seri_mhd' => $params['pSo_seri_mhd'] ?? '',
            'pNgay_lct' => $params['pNgay_lct'] ?? '',
            'pSo_ct' => $params['pSo_ct'] ?? '',
            'pSo_seri' => $params['pSo_seri'] ?? '',
            'pTen_kh' => $params['pTen_kh'] ?? '',
            'pDia_chi' => $params['pDia_chi'] ?? '',
            'pMa_so_thue' => $params['pMa_so_thue'] ?? '',
            'pMa_vt' => $params['pMa_vt'] ?? '',
            'pTen_vt' => $params['pTen_vt'] ?? '',
            'pSo_luong' => $params['pSo_luong'] ?? '',
            'pGia' => $params['pGia'] ?? '',
            'pMa_nt' => $params['pMa_nt'] ?? '',
            'pTy_gia' => $params['pTy_gia'] ?? '',
            'pT_tien' => $params['pT_tien'] ?? '',
            'pT_tien_nt' => $params['pT_tien_nt'] ?? '',
            'pMa_thue' => $params['pMa_thue'] ?? '',
            'pThue_suat' => $params['pThue_suat'] ?? '',
            'pT_thue' => $params['pT_thue'] ?? '',
            'pT_thue_nt' => $params['pT_thue_nt'] ?? '',
            'pTk_thue' => $params['pTk_thue'] ?? '',
            'pTk_du' => $params['pTk_du'] ?? '',
            'pMa_spct' => $params['pMa_spct'] ?? '',
            'pMa_lo' => $params['pMa_lo'] ?? '',
            'pMa_bp' => $params['pMa_bp'] ?? '',
            'pMa_hd' => $params['pMa_hd'] ?? '',
            'pGhi_chu' => $params['pGhi_chu'] ?? '',
            'pMa_kh' => $params['pMa_kh'] ?? '',
            'pUser' => $params['pUser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
