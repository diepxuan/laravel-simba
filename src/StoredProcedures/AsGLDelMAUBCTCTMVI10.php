<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:08:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLDelMAUBCTCTMVI10
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelMAUBCTCTMVI10', [
            'pMa_cty' => $paramObj->pMa_cty ?? SModel::CTY,
            'pMau'    => $paramObj->pMau ?? null,
            'pMa_so'  => $paramObj->pMa_so ?? null,
        ], $connection);
    }
}
