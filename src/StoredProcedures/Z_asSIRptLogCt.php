<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class Z_asSIRptLogCt
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asSIRptLogCt', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pUser'  => $paramObj->pUser ?? null,
            'pAction'  => $paramObj->pAction ?? null,
            'pNgay1'  => $paramObj->pNgay1 ?? null,
            'pNgay2'  => $paramObj->pNgay2 ?? null,
        ], $connection);
    }
}
