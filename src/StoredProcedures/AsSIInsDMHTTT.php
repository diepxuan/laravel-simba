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
use Diepxuan\Simba\Helper\ParamHelper;

class AsSIInsDMHTTT
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIInsDMHTTT', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pMa_httt'  => $paramObj->pMa_httt ?? null,
            'pModuleid'  => $paramObj->pModuleid ?? null,
            'pTen_httt'  => $paramObj->pTen_httt ?? null,
            'pTk'  => $paramObj->pTk ?? null,
            'pTk_thue_gtgt_mua'  => $paramObj->pTk_thue_gtgt_mua ?? null,
            'pTk_thue_gtgt_ban'  => $paramObj->pTk_thue_gtgt_ban ?? null,
            'pTk_thue_nk'  => $paramObj->pTk_thue_nk ?? null,
            'pTk_thue_xk'  => $paramObj->pTk_thue_xk ?? null,
            'pTk_gtgt_nk_no'  => $paramObj->pTk_gtgt_nk_no ?? null,
            'pTk_gtgt_nk_co'  => $paramObj->pTk_gtgt_nk_co ?? null,
            'pTk_thue_gtgt_xk'  => $paramObj->pTk_thue_gtgt_xk ?? null,
            'pTK_thue_ttdb'  => $paramObj->pTK_thue_ttdb ?? null,
            'pTk_ck'  => $paramObj->pTk_ck ?? null,
            'pKsd'  => $paramObj->pKsd ?? null,
            'pLUser'  => $paramObj->pLUser ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}