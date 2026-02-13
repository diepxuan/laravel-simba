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

class AsFAUpdKHTS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAUpdKHTS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pMa_ts_tgng' => $params['pMa_ts_tgng'] ?? null,
            'pKh_n1' => $params['pKh_n1'] ?? null,
            'pKh_n2' => $params['pKh_n2'] ?? null,
            'pKh_n3' => $params['pKh_n3'] ?? null,
            'pKh_n4' => $params['pKh_n4'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pma_bpsd' => $params['pma_bpsd'] ?? null,
            'ptk_kh' => $params['ptk_kh'] ?? null,
            'ptk_cp' => $params['ptk_cp'] ?? null,
            'pSua_kh' => $params['pSua_kh'] ?? null,
        ], $connection);
    }
}
