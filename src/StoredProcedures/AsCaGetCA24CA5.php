<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 13:22:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCaGetCA24CA5
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCaGetCA24CA5', [
            'pMa_Cty'  => $paramObj->pMa_Cty ?? null,
            'pMa_Kh'   => $paramObj->pMa_Kh ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
        ], $connection);
    }
}
