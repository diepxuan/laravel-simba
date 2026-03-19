<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:31
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsPost2TT_APTT
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsPost2TT_APTT', [
            'pMa_cty'     => $paramObj->pMa_cty ?? SModel::CTY,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pStt_rec_hd' => $paramObj->pStt_rec_hd ?? null,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pNguoi_gd'   => $paramObj->pNguoi_gd ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
            'pTk_pt'      => $paramObj->pTk_pt ?? null,
            'pMa_kh'      => $paramObj->pMa_kh ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTy_gia'     => $paramObj->pTy_gia ?? null,
            'pT_tt'       => $paramObj->pT_tt ?? null,
            'pT_tt_nt'    => $paramObj->pT_tt_nt ?? null,
            'pTien_tt'    => $paramObj->pTien_tt ?? null,
            'pTien_tt_nt' => $paramObj->pTien_tt_nt ?? null,
            'pTien_tt_qd' => $paramObj->pTien_tt_qd ?? null,
            'pT_tien'     => $paramObj->pT_tien ?? null,
            'pT_tien_nt'  => $paramObj->pT_tien_nt ?? null,
            'pUser'       => $paramObj->pUser ?? null,
        ], $connection);
    }
}
