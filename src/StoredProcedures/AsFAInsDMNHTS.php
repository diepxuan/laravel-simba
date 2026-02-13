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

class AsFAInsDMNHTS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAInsDMNHTS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhts' => $params['pMa_nhts'] ?? null,
            'pLoai_nh' => $params['pLoai_nh'] ?? null,
            'pTen_nhts' => $params['pTen_nhts'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
