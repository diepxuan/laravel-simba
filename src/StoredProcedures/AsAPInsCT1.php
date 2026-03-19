<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:27
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsCT1
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsCT1', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pStt_rec0'   => $paramObj->pStt_rec0 ?? null,
            'pStt_rec_hd' => $paramObj->pStt_rec_hd ?? null,
            'pStt_rec_dh' => $paramObj->pStt_rec_dh ?? null,
            'pSo_hd'      => $paramObj->pSo_hd ?? null,
            'pNgay_hd'    => $paramObj->pNgay_hd ?? null,
            'pSo_dh'      => $paramObj->pSo_dh ?? null,
            'pNgay_dh'    => $paramObj->pNgay_dh ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTien_tt'    => $paramObj->pTien_tt ?? 0.0,
            'pTien_tt_nt' => $paramObj->pTien_tt_nt ?? 0.0,
            'pTien_tt_qd' => $paramObj->pTien_tt_qd ?? 0.0,
            'pTt_hd'      => $paramObj->pTt_hd ?? 0.0,
            'pTt_hd_nt'   => $paramObj->pTt_hd_nt ?? 0.0,
            'pDu_hd'      => $paramObj->pDu_hd ?? 0.0,
            'pDu_hd_nt'   => $paramObj->pDu_hd_nt ?? 0.0,
            'pTk'         => $paramObj->pTk ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? '',
            'pMa_lo'      => $paramObj->pMa_lo ?? '',
            'pMa_bp'      => $paramObj->pMa_bp ?? '',
            'pMa_hd'      => $paramObj->pMa_hd ?? '',
            'pMa_phi'     => $paramObj->pMa_phi ?? '',
            'pMa_spct'    => $paramObj->pMa_spct ?? '',
        ], $connection);
    }
}
