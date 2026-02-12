<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARDelCDKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARDelCDKH', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_kh'    => $params['pMa_kh'] ?? null,
            'pTk'       => $params['pTk'] ?? null,
            'pMa_Nt'    => $params['pMa_Nt'] ?? null,
            'pMa_SpCt'  => $params['pMa_SpCt'] ?? null,
            'pMa_hd'    => $params['pMa_hd'] ?? null,
            'pMa_Bp'    => $params['pMa_Bp'] ?? null,
            'pNam'      => $params['pNam'] ?? null,
        ], $connection);
    }
}
