<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsCARptTMNH08
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH08', [
            'pMa_Cty'   => $paramObj->pMa_Cty ?? null,
            'pTk'       => $paramObj->pTk ?? null,
            'pNgay_Ct1' => $paramObj->pNgay_Ct1 ?? null,
            'pNgay_Ct2' => $paramObj->pNgay_Ct2 ?? null,
            'pMa_Nt'    => $paramObj->pMa_Nt ?? null,
        ], $connection);
    }
}
