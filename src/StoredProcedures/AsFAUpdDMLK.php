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

class AsFAUpdDMLK
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAUpdDMLK', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pMa_lk' => $params['pMa_lk'] ?? null,
            'pTg' => $params['pTg'] ?? null,
            'pTen_lk' => $params['pTen_lk'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pGia_tri' => $params['pGia_tri'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
