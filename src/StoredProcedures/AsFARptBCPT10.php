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

class AsFARptBCPT10
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFARptBCPT10', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay_dk' => $params['pNgay_dk'] ?? null,
            'pNgay_ck' => $params['pNgay_ck'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pMa_cc' => $params['pMa_cc'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pTk_PB' => $params['pTk_PB'] ?? null,
            'PTk_CP' => $params['PTk_CP'] ?? null,
        ], $connection);
    }
}
