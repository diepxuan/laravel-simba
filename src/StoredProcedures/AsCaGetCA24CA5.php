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

class AsCaGetCA24CA5
{
    public static function call(array \$params): Collection
    {
        \$connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCaGetCA24CA5', [
            'pMa_Cty'  => $params['pMa_Cty'] ?? null,
            'pMa_Kh'  => $params['pMa_Kh'] ?? null,
            'pNgay_ct'  => $params['pNgay_ct'] ?? null,
        ], \$connection);
    }
}