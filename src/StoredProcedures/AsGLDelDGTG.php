<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 10:55:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLDelDGTG
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelDGTG', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            'pngay1'  => $params['pngay1'] ?? null,
            'pngay2'  => $params['pngay2'] ?? null,
            'pstt'    => $params['pstt'] ?? null,
        ], $connection);
    }
}
