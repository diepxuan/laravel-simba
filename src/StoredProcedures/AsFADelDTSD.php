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

class AsFADelDTSD
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFADelDTSD', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pNgay' => $paramObj->pNgay ?? null,
            'pLoai_dt' => $paramObj->pLoai_dt ?? null,
        ], $connection);
    }
}
