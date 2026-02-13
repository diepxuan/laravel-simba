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

class AsFAChkThoiKHTS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAChkThoiKHTS', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pma_ts' => $params['pma_ts'] ?? null,
            'pNgay_dung_kh' => $params['pNgay_dung_kh'] ?? null,
        ], $connection);
    }
}
