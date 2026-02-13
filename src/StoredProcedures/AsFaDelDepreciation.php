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

class AsFaDelDepreciation
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaDelDepreciation', [
            'Ma_cty' => $params['Ma_cty'] ?? null,
            'Nam' => $params['Nam'] ?? null,
            'Thang' => $params['Thang'] ?? null,
            'Ma_Ts' => $params['Ma_Ts'] ?? null,
            'Ma_ct' => $params['Ma_ct'] ?? null,
        ], $connection);
    }
}
