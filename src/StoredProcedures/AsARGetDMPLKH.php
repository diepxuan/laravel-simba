<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARGetDMPLKH
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetDMPLKH', [
            'pMa_cty'   => $paramObj->pMa_cty ?? null,
            'pMa_plkh'  => $paramObj->pMa_plkh ?? null,
            'pStruct'   => $paramObj->pStruct ?? '0',
            'pLoai'     => $paramObj->pLoai ?? null,
        ], $connection);
    }
}