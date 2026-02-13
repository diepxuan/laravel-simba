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

class AsFAInsDTSD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAInsDTSD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pLoai_dt' => $params['pLoai_dt'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pTk_ts' => $params['pTk_ts'] ?? null,
            'pTk_kh' => $params['pTk_kh'] ?? null,
            'pTk_cp' => $params['pTk_cp'] ?? null,
            'pCdate' => $params['pCdate'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pLdate' => $params['pLdate'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
        ], $connection);
    }
}
