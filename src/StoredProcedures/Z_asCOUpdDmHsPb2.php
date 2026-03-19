<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class Z_asCOUpdDmHsPb2
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCOUpdDmHsPb2', [
            'pMa_cty'       => $paramObj->pMa_cty ?? null,
            'pThang'        => $paramObj->pThang ?? null,
            'pNam'          => $paramObj->pNam ?? null,
            'pMa_sp'        => $paramObj->pMa_sp ?? null,
            'pTk'           => $paramObj->pTk ?? null,
            'pTen_sp'       => $paramObj->pTen_sp ?? null,
            'pHs_621_ck'    => $paramObj->pHs_621_ck ?? null,
            'pHs_622_ck'    => $paramObj->pHs_622_ck ?? null,
            'pHs_td_ck'     => $paramObj->pHs_td_ck ?? null,
            'pHs_621_dd'    => $paramObj->pHs_621_dd ?? null,
            'pHs_622_dd'    => $paramObj->pHs_622_dd ?? null,
            'pHs_td_dd'     => $paramObj->pHs_td_dd ?? null,
            'pHs_621_lh'    => $paramObj->pHs_621_lh ?? null,
            'pHs_622_lh'    => $paramObj->pHs_622_lh ?? null,
            'pHs_td_lh'     => $paramObj->pHs_td_lh ?? null,
            'pHs_621_ls'    => $paramObj->pHs_621_ls ?? null,
            'pHs_622_ls'    => $paramObj->pHs_622_ls ?? null,
            'pHs_td_ls'     => $paramObj->pHs_td_ls ?? null,
            'pThs_621'      => $paramObj->pThs_621 ?? null,
            'pThs_621_ck'   => $paramObj->pThs_621_ck ?? null,
            'pThs_622_ck'   => $paramObj->pThs_622_ck ?? null,
            'pThs_td_ck'    => $paramObj->pThs_td_ck ?? null,
            'pThs_621_dd'   => $paramObj->pThs_621_dd ?? null,
            'pThs_622_dd'   => $paramObj->pThs_622_dd ?? null,
            'pThs_td_dd'    => $paramObj->pThs_td_dd ?? null,
            'pThs_621_lh'   => $paramObj->pThs_621_lh ?? null,
            'pThs_622_lh'   => $paramObj->pThs_622_lh ?? null,
            'pThs_td_lh'    => $paramObj->pThs_td_lh ?? null,
            'pThs_621_ls'   => $paramObj->pThs_621_ls ?? null,
            'pThs_622_ls'   => $paramObj->pThs_622_ls ?? null,
            'pThs_td_ls'    => $paramObj->pThs_td_ls ?? null,
            'pMa_pb'        => $paramObj->pMa_pb ?? null,
            'pRet'          => $paramObj->pRet ?? null,
        ], $connection);
    }
}