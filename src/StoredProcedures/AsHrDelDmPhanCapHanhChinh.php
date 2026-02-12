<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrDelDmPhanCapHanhChinh
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDmPhanCapHanhChinh', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_pchc'  => $params['pMa_pchc'] ?? '',
        ], $connection);
    }
}
