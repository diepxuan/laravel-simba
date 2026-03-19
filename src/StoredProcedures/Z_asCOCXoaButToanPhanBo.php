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

class Z_asCOCXoaButToanPhanBo
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCOCXoaButToanPhanBo', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pMa_ct'  => $paramObj->pMa_ct ?? null,
            'pNgay_ct'  => $paramObj->pNgay_ct ?? null,
        ], $connection);
    }
}
