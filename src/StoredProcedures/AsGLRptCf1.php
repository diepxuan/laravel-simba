<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLRptCf1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptCf1', [
            'Ma_Cty' => $paramObj->Ma_Cty ?? null,
            'Mau' => $paramObj->Mau ?? null,
            'ngay00' => $paramObj->ngay00 ?? null,
            'ngay0' => $paramObj->ngay0 ?? null,
            'ngay1' => $paramObj->ngay1 ?? null,
            'ngay2' => $paramObj->ngay2 ?? null,
            'format' => $paramObj->format ?? null
        ], $connection);
    }
}
