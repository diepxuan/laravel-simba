<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 10:55:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLDelDGTG
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelDGTG', [
            'pMa_cty' => $paramObj->pMa_cty ?? SModel::CTY,
            'pMa_ct'  => $paramObj->pMa_ct ?? null,
            'pngay1'  => $paramObj->pngay1 ?? null,
            'pngay2'  => $paramObj->pngay2 ?? null,
            'pstt'    => $paramObj->pstt ?? null,
        ], $connection);
    }
}
