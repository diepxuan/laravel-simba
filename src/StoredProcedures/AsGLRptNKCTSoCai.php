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

class AsGLRptNKCTSoCai
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKCTSoCai', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
            'pTk'  => $params['pTk'] ?? null,
            'pThang1'  => $params['pThang1'] ?? null,
            'pThang2'  => $params['pThang2'] ?? null,
            'pNam'  => $params['pNam'] ?? null,
        ], $connection);
    }
}