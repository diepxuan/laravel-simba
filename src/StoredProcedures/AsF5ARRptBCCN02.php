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

class AsF5ARRptBCCN02
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asF5ARRptBCCN02', [
            'ma_cty' => $paramObj->ma_cty ?? null,
            'Tk' => $paramObj->Tk ?? null,
            'Ngay1' => $paramObj->Ngay1 ?? null,
            'Ngay2' => $paramObj->Ngay2 ?? null,
        ], $connection);
    }
}
