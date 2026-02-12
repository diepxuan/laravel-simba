<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOUpdDMTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdDMTT', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pma_tt_po' => $params['pma_tt_po'] ?? '',
            'pMo_ta' => $params['pMo_ta'] ?? '',
            'pHan_ck' => $params['pHan_ck'] ?? '',
            'pTl_ck' => $params['pTl_ck'] ?? '',
            'pHan_tt' => $params['pHan_tt'] ?? '',
            'pLs_qh' => $params['pLs_qh'] ?? '',
            'pkSd' => $params['pkSd'] ?? '',
            'pLUser' => $params['pLUser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
