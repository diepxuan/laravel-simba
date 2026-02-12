<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCARptTMNH07
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH07', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pTk'  => $params['pTk'] ?? null,
            'pMa_ku'  => $params['pMa_ku'] ?? null,
            'pNgay_ctk'  => $params['pNgay_ctk'] ?? null,
            'pNgay_cdk'  => $params['pNgay_cdk'] ?? null,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
        ], $connection);
    }
}