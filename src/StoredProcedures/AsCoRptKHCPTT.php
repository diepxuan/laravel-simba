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

class AsCoRptKHCPTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCoRptKHCPTT', [
            'pMa_Cty'  => $params['pMa_Cty'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
            'pMa_bpsd'  => $params['pMa_bpsd'] ?? null,
            'pMa_cp'  => $params['pMa_cp'] ?? null,
            'pTk_pb'  => $params['pTk_pb'] ?? null,
            'pTk_cp'  => $params['pTk_cp'] ?? null,
            'pMa_phi'  => $params['pMa_phi'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pMa_cty'  => $params['pMa_cty'] ?? null,
        ], $connection);
    }
}