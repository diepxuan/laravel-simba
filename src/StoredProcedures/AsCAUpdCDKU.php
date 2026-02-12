<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCAUpdCDKU
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAUpdCDKU', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pNam'       => $params['pNam'] ?? null,
            'pMa_ku'     => $params['pMa_ku'] ?? null,
            'pTk'        => $params['pTk'] ?? null,
            'pMa_nt'     => $params['pMa_nt'] ?? null,
            'pNgay_ku'   => $params['pNgay_ku'] ?? null,
            'pNgay_tt'   => $params['pNgay_tt'] ?? null,
            'pDa_vay'    => $params['pDa_vay'] ?? null,
            'pDa_vay_nt' => $params['pDa_vay_nt'] ?? null,
            'pDa_tt'     => $params['pDa_tt'] ?? null,
            'pDa_tt_nt'  => $params['pDa_tt_nt'] ?? null,
            'pLUser'     => $params['pLUser'] ?? null,
        ], $connection);
    }
}
