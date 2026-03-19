<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:30
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsPH3
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsPH3', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'   => $paramObj->pNgay_lct ?? null,
            'pMa_kh'      => $paramObj->pMa_kh ?? null,
            'pDia_chi'    => $paramObj->pDia_chi ?? null,
            'pNguoi_gd'   => $paramObj->pNguoi_gd ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
            'pTk_co'      => $paramObj->pTk_co ?? null,
            'pMa_gd'      => $paramObj->pMa_gd ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTy_gia'     => $paramObj->pTy_gia ?? 0.0,
            'pT_tien_nt'  => $paramObj->pT_tien_nt ?? 0.0,
            'pT_tien'     => $paramObj->pT_tien ?? 0.0,
            'pDu'         => $paramObj->pDu ?? 0.0,
            'pDu_nt'      => $paramObj->pDu_nt ?? 0.0,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pPost2gl'    => $paramObj->pPost2gl ?? null,
            'pLUser'      => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
