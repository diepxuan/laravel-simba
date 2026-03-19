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

class AsAPInsPH4
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsPH4', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'   => $paramObj->pNgay_lct ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTy_gia'     => $paramObj->pTy_gia ?? 0.0,
            'pT_tien'     => $paramObj->pT_tien ?? 0.0,
            'pT_tien_nt'  => $paramObj->pT_tien_nt ?? 0.0,
            'pNt_ph'      => $paramObj->pNt_ph ?? false,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pPost2gl'    => $paramObj->pPost2gl ?? null,
            'pLUser'      => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
