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

class Z_asCOUpdDmHsPb2
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCOUpdDmHsPb2', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pThang'        => $params['pThang'] ?? null,
            'pNam'          => $params['pNam'] ?? null,
            'pMa_sp'        => $params['pMa_sp'] ?? null,
            'pTk'           => $params['pTk'] ?? null,
            'pTen_sp'       => $params['pTen_sp'] ?? null,
            'pHs_621_ck'    => $params['pHs_621_ck'] ?? null,
            'pHs_622_ck'    => $params['pHs_622_ck'] ?? null,
            'pHs_td_ck'     => $params['pHs_td_ck'] ?? null,
            'pHs_621_dd'    => $params['pHs_621_dd'] ?? null,
            'pHs_622_dd'    => $params['pHs_622_dd'] ?? null,
            'pHs_td_dd'     => $params['pHs_td_dd'] ?? null,
            'pHs_621_lh'    => $params['pHs_621_lh'] ?? null,
            'pHs_622_lh'    => $params['pHs_622_lh'] ?? null,
            'pHs_td_lh'     => $params['pHs_td_lh'] ?? null,
            'pHs_621_ls'    => $params['pHs_621_ls'] ?? null,
            'pHs_622_ls'    => $params['pHs_622_ls'] ?? null,
            'pHs_td_ls'     => $params['pHs_td_ls'] ?? null,
            'pThs_621'      => $params['pThs_621'] ?? null,
            'pThs_621_ck'   => $params['pThs_621_ck'] ?? null,
            'pThs_622_ck'   => $params['pThs_622_ck'] ?? null,
            'pThs_td_ck'    => $params['pThs_td_ck'] ?? null,
            'pThs_621_dd'   => $params['pThs_621_dd'] ?? null,
            'pThs_622_dd'   => $params['pThs_622_dd'] ?? null,
            'pThs_td_dd'    => $params['pThs_td_dd'] ?? null,
            'pThs_621_lh'   => $params['pThs_621_lh'] ?? null,
            'pThs_622_lh'   => $params['pThs_622_lh'] ?? null,
            'pThs_td_lh'    => $params['pThs_td_lh'] ?? null,
            'pThs_621_ls'   => $params['pThs_621_ls'] ?? null,
            'pThs_622_ls'   => $params['pThs_622_ls'] ?? null,
            'pThs_td_ls'    => $params['pThs_td_ls'] ?? null,
            'pMa_pb'        => $params['pMa_pb'] ?? null,
            'pRet'          => $params['pRet'] ?? null,
        ], $connection);
    }
}