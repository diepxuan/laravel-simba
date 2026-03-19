<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsFAUpdGiamTS
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAUpdGiamTS', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pMa_Giam_Ts' => $paramObj->pMa_Giam_Ts ?? null,
            'pNgay_Giam' => $paramObj->pNgay_Giam ?? null,
            'pSo_Luong' => $paramObj->pSo_Luong ?? null,
            'pSo_ct_giam' => $paramObj->pSo_ct_giam ?? null,
            'pNgay_ct_giam' => $paramObj->pNgay_ct_giam ?? null,
            'pUser' => $paramObj->pUser ?? null,
        ], $connection);
    }
}
