<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-01-12 00:35:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;

class AsGetSoCt
{
    public static function call(array $params): string
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetSoCt', [
            'pMa_Cty'  => $params['pMa_Cty'] ?? SModel::CTY,
            'pMa_ct'   => $params['pMa_ct'] ?? null,
            'pNgay_Ct' => $params['pNgay_Ct'] ?? now()->toDateString(),
            'pSo_Ct'   => $params['pSo_Ct'] ?? null,
        ], $connection)->first()->SoCt;
    }
}
