<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLRptCf1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptCf1', [
            'Ma_Cty' => $params['Ma_Cty'] ?? null,
            'Mau' => $params['Mau'] ?? null,
            'ngay00' => $params['ngay00'] ?? null,
            'ngay0' => $params['ngay0'] ?? null,
            'ngay1' => $params['ngay1'] ?? null,
            'ngay2' => $params['ngay2'] ?? null,
            'format' => $params['format'] ?? null
        ], $connection);
    }
}
