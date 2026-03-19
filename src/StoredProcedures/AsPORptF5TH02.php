<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPORptF5TH02
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptF5TH02', [
            'pma_cty'  => $paramObj->pma_cty ?? null,
            'pLoai'  => $paramObj->pLoai ?? null,
            'pMa_ct'  => $paramObj->pMa_ct ?? null,
            'pThang'  => $paramObj->pThang ?? null,
            'pNam'  => $paramObj->pNam ?? null,
            'pSo_ky'  => $paramObj->pSo_ky ?? null,
            'pMa_nt'  => $paramObj->pMa_nt ?? null,
            'pMa_vt'  => $paramObj->pMa_vt ?? null,
            'pKy'  => $paramObj->pKy ?? null,
        ], $connection);
    }
}