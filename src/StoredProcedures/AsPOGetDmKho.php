<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-14 09:12:30
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPOGetDmKho.
 *
 * Stored procedure: asPOGetDmKho
 * Mục đích: Lấy danh mục kho cho PO3.
 */
class AsPOGetDmKho
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOGetDmKho', [
            'pMa_cty' => $paramObj->pMa_cty ?? SModel::CTY,
        ], $connection);
    }
}
