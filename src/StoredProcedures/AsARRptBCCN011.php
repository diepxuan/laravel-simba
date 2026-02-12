<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN011
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN011', [
            'ma_cty' => $params['pma_cty'] ?? $params['ma_cty'] ?? null,
            'Ngay1' => $params['pNgay1'] ?? $params['Ngay1'] ?? null,
            'Ngay2' => $params['pNgay2'] ?? $params['Ngay2'] ?? null,
            'Tk' => $params['pTk'] ?? $params['Tk'] ?? null,
            'ma_kh' => $params['pma_kh'] ?? $params['ma_kh'] ?? null,
            'ma_nt' => $params['pma_nt'] ?? $params['ma_nt'] ?? null,
        ], $connection);
    }
}
