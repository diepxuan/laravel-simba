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
use Diepxuan\Simba\Helper\ParamHelper;

class AsTaInsOut
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTaInsOut', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pStt_rec' => $paramObj->pStt_rec ?? '',
            'pStt_rec0' => $paramObj->pStt_rec0 ?? '',
            'pMa_ct' => $paramObj->pMa_ct ?? '',
            'pNgay_ct' => $paramObj->pNgay_ct ?? '',
            'pThang' => $paramObj->pThang ?? '',
            'pNam' => $paramObj->pNam ?? '',
            'pSo_seri_mhd' => $paramObj->pSo_seri_mhd ?? '',
            'pNgay_lct' => $paramObj->pNgay_lct ?? '',
            'pSo_ct' => $paramObj->pSo_ct ?? '',
            'pSo_seri' => $paramObj->pSo_seri ?? '',
            'pTen_kh' => $paramObj->pTen_kh ?? '',
            'pDia_chi' => $paramObj->pDia_chi ?? '',
            'pMa_so_thue' => $paramObj->pMa_so_thue ?? '',
            'pMa_vt' => $paramObj->pMa_vt ?? '',
            'pTen_vt' => $paramObj->pTen_vt ?? '',
            'pSo_luong' => $paramObj->pSo_luong ?? '',
            'pGia' => $paramObj->pGia ?? '',
            'pMa_nt' => $paramObj->pMa_nt ?? '',
            'pTy_gia' => $paramObj->pTy_gia ?? '',
            'pT_tien' => $paramObj->pT_tien ?? '',
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? '',
            'pMa_thue' => $paramObj->pMa_thue ?? '',
            'pThue_suat' => $paramObj->pThue_suat ?? '',
            'pT_thue' => $paramObj->pT_thue ?? '',
            'pT_thue_nt' => $paramObj->pT_thue_nt ?? '',
            'pTk_thue' => $paramObj->pTk_thue ?? '',
            'pTk_du' => $paramObj->pTk_du ?? '',
            'pMa_spct' => $paramObj->pMa_spct ?? '',
            'pMa_lo' => $paramObj->pMa_lo ?? '',
            'pMa_bp' => $paramObj->pMa_bp ?? '',
            'pMa_hd' => $paramObj->pMa_hd ?? '',
            'pGhi_chu' => $paramObj->pGhi_chu ?? '',
            'pMa_kh' => $paramObj->pMa_kh ?? '',
            'pUser' => $paramObj->pUser ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
