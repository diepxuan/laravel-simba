<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetQTCapCongCu
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetQTCapCongCu', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtccc' => $params['pId_qtccc'] ?? null,
        ], $connection);
    }
}
