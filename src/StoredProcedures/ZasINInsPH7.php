<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class ZasINInsPH7
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('zasINInsPH7', [
            'pMa_cty'      => $paramObj->pMa_cty ?? null,
            'pStt_rec'     => $paramObj->pStt_rec ?? null,
            'pMa_ct'       => $paramObj->pMa_ct ?? null,
            'pMa_gd'       => $paramObj->pMa_gd ?? null,
            'pNgay_ct'     => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'    => $paramObj->pNgay_lct ?? null,
            'pSo_ct'       => $paramObj->pSo_ct ?? null,
            'pMa_kh'       => $paramObj->pMa_kh ?? null,
            'pTen_kh'      => $paramObj->pTen_kh ?? null,
            'pDia_chi'     => $paramObj->pDia_chi ?? null,
            'pNguoi_gd'    => $paramObj->pNguoi_gd ?? null,
            'pDien_giai'   => $paramObj->pDien_giai ?? null,
            'pMa_nx'       => $paramObj->pMa_nx ?? null,
            'pMa_nt'       => $paramObj->pMa_nt ?? null,
            'pTy_gia'      => $paramObj->pTy_gia ?? null,
            'pT_tien_nt'   => $paramObj->pT_tien_nt ?? null,
            'pT_tien'      => $paramObj->pT_tien ?? null,
            'pTrang_thai'  => $paramObj->pTrang_thai ?? null,
            'pPost2gl'     => $paramObj->pPost2gl ?? null,
            'pPost2in'     => $paramObj->pPost2in ?? null,
            'pLUser'       => $paramObj->pLUser ?? null,
            'pRet'         => $paramObj->pRet ?? null,
        ], $connection);
    }
}