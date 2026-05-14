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
 * Class AsPOGetDmVt.
 *
 * Stored procedure: asPOGetDmVt
 * Mục đích: Lấy danh mục vật tư cho PO3.
 */
class AsPOGetDmVt
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOGetDmVt', [
            'pMa_cty' => $paramObj->pMa_cty ?? SModel::CTY,
            'pSearch' => $paramObj->pSearch ?? null,
        ], $connection);
    }
}
