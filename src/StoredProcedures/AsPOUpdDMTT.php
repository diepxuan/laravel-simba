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
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOUpdDMTT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdDMTT', [
            'pMa_cty' => $paramObj->pMa_cty ?? '',
            'pma_tt_po' => $paramObj->pma_tt_po ?? '',
            'pMo_ta' => $paramObj->pMo_ta ?? '',
            'pHan_ck' => $paramObj->pHan_ck ?? '',
            'pTl_ck' => $paramObj->pTl_ck ?? '',
            'pHan_tt' => $paramObj->pHan_tt ?? '',
            'pLs_qh' => $paramObj->pLs_qh ?? '',
            'pkSd' => $paramObj->pkSd ?? '',
            'pLUser' => $paramObj->pLUser ?? '',
            'pRet' => $paramObj->pRet ?? ''
        ], $connection);
    }
}
