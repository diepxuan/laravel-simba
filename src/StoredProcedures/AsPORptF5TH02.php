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

class AsPORptF5TH02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptF5TH02', [
            'pma_cty'  => $params['pma_cty'] ?? null,
            'pLoai'  => $params['pLoai'] ?? null,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pNam'  => $params['pNam'] ?? null,
            'pSo_ky'  => $params['pSo_ky'] ?? null,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
            'pMa_vt'  => $params['pMa_vt'] ?? null,
            'pKy'  => $params['pKy'] ?? null,
        ], $connection);
    }
}