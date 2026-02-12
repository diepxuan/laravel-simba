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

class AsSIUpdDMHTTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIUpdDMHTTT', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_httt'  => $params['pMa_httt'] ?? null,
            'pModuleid'  => $params['pModuleid'] ?? null,
            'pTen_httt'  => $params['pTen_httt'] ?? null,
            'pTk'  => $params['pTk'] ?? null,
            'pTk_thue_gtgt_mua'  => $params['pTk_thue_gtgt_mua'] ?? null,
            'pTk_thue_gtgt_ban'  => $params['pTk_thue_gtgt_ban'] ?? null,
            'pTk_thue_nk'  => $params['pTk_thue_nk'] ?? null,
            'pTk_thue_xk'  => $params['pTk_thue_xk'] ?? null,
            'pTk_gtgt_nk_no'  => $params['pTk_gtgt_nk_no'] ?? null,
            'pTk_gtgt_nk_co'  => $params['pTk_gtgt_nk_co'] ?? null,
            'pTk_thue_gtgt_xk'  => $params['pTk_thue_gtgt_xk'] ?? null,
            'pTK_thue_ttdb'  => $params['pTK_thue_ttdb'] ?? null,
            'pTk_ck'  => $params['pTk_ck'] ?? null,
            'pKsd'  => $params['pKsd'] ?? null,
            'pLUser'  => $params['pLUser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}