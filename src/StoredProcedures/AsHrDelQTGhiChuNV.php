<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrDelQTGhiChuNV
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelQTGhiChuNV', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pId' => $params['pId'] ?? '',
            'pId_qtgc' => $params['pId_qtgc'] ?? '',
            'pRet' => $params['pRet'] ?? ''
        ], $connection);
    }
}
