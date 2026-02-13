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

class AsFAUpdGiamTS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAUpdGiamTS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pMa_Giam_Ts' => $params['pMa_Giam_Ts'] ?? null,
            'pNgay_Giam' => $params['pNgay_Giam'] ?? null,
            'pSo_Luong' => $params['pSo_Luong'] ?? null,
            'pSo_ct_giam' => $params['pSo_ct_giam'] ?? null,
            'pNgay_ct_giam' => $params['pNgay_ct_giam'] ?? null,
            'pUser' => $params['pUser'] ?? null,
        ], $connection);
    }
}
