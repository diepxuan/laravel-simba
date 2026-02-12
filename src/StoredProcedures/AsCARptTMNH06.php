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

class AsCARptTMNH06
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH06', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pNgay_ct1' => $params['pNgay_ct1'] ?? null,
            'pNgay_ct2' => $params['pNgay_ct2'] ?? null,
            'pTk'       => $params['pTk'] ?? null,
            'pMa_Ku'    => $params['pMa_Ku'] ?? null,
            'pMa_Nt'    => $params['pMa_Nt'] ?? null,
        ], $connection);
    }
}
