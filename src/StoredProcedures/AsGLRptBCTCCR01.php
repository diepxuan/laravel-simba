<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLRptBCTCCR01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCR01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'Ngay_ct1' => $params['Ngay_ct1'] ?? null,
            'Ngay_ct2' => $params['Ngay_ct2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pBac_tk' => $params['pBac_tk'] ?? null
        ], $connection);
    }
}
