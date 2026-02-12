<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCARptTMNH01a
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH01a', [
            'ptk' => $params['ptk'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
        ], $connection);
    }
}
