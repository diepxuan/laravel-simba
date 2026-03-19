<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARInsCT1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsCT1', [
            'pMa_cty'       => $paramObj->pMa_cty ?? null,
            'pStt_rec'      => $paramObj->pStt_rec ?? null,
            'pStt_rec0'     => $paramObj->pStt_rec0 ?? null,
            'pStt_rec_hd'   => $paramObj->pStt_rec_hd ?? null,
            'pStt_rec_dh'   => $paramObj->pStt_rec_dh ?? null,
            'pSo_hd'        => $paramObj->pSo_hd ?? null,
            'pNgay_hd'      => $paramObj->pNgay_hd ?? null,
            'pSo_dh'        => $paramObj->pSo_dh ?? null,
            'pNgay_dh'      => $paramObj->pNgay_dh ?? null,
            'pMa_nt'        => $paramObj->pMa_nt ?? null,
            'pTien_tt'      => $paramObj->pTien_tt ?? null,
            'pTien_tt_nt'   => $paramObj->pTien_tt_nt ?? null,
            'pTien_tt_qd'   => $paramObj->pTien_tt_qd ?? null,
            'pTt_hd'        => $paramObj->pTt_hd ?? null,
            'pTt_hd_nt'     => $paramObj->pTt_hd_nt ?? null,
            'pTk'           => $paramObj->pTk ?? null,
            'pDien_giai'    => $paramObj->pDien_giai ?? null,
            'pMa_lo'        => $paramObj->pMa_lo ?? null,
            'pMa_bp'        => $paramObj->pMa_bp ?? null,
            'pMa_hd'        => $paramObj->pMa_hd ?? null,
            'pMa_phi'       => $paramObj->pMa_phi ?? null,
            'pMa_spct'      => $paramObj->pMa_spct ?? null,
        ], $connection);
    }
}