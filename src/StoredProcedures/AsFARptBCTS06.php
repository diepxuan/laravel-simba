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

class AsFARptBCTS06
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFARptBCTS06', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay_Dk' => $params['pNgay_Dk'] ?? null,
            'pNgay_Ck' => $params['pNgay_Ck'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
        ], $connection);
    }
}
