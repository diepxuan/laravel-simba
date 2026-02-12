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

class AsARGetCDKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetCDKH', [
            'pMa_Cty'   => $params['pMa_Cty'] ?? null,
            'pNam'      => $params['pNam'] ?? null,
            'pTk'       => $params['pTk'] ?? null,
            'pMa_kh'    => $params['pMa_kh'] ?? null,
            'pMa_hd'    => $params['pMa_hd'] ?? null,
            'pMa_bp'    => $params['pMa_bp'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pLoai'     => $params['pLoai'] ?? null,
        ], $connection);
    }
}