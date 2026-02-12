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

class AsARRptBCCN05
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN05', [
            'pMa_cty' => $params['pPMa_cty'] ?? $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pPNgay1'] ?? $params['pNgay1'] ?? null,
            'pNgay2' => $params['pPNgay2'] ?? $params['pNgay2'] ?? null,
            'pTk' => $params['pPTk'] ?? $params['pTk'] ?? null,
            'pMa_kh' => $params['pPMa_kh'] ?? $params['pMa_kh'] ?? null,
            'pMa_nt' => $params['pPMa_nt'] ?? $params['pMa_nt'] ?? null,
        ], $connection);
    }
}
