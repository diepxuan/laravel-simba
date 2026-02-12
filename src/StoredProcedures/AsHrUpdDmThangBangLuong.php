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

class AsHrUpdDmThangBangLuong
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmThangBangLuong', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_tbl' => $params['pMa_tbl'] ?? '',
            'pTen_tbl' => $params['pTen_tbl'] ?? '',
            'pKsd' => $params['pKsd'] ?? '',
            'pLuser' => $params['pLuser'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
