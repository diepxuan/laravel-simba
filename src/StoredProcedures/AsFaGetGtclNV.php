<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsFaGetGtclNV
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaGetGtclNV', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pNgay_ck' => $paramObj->pNgay_ck ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pMa_ts_tgng' => $paramObj->pMa_ts_tgng ?? null,
        ], $connection);
    }
}
