<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsCARptTMNH01
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCARptTMNH01', [
            'pMa_Cty'   => $paramObj->pMa_Cty ?? SModel::CTY,
            'pTk'       => $paramObj->pTk ?? '111',
            'pNgay_Ct1' => $paramObj->pNgay_Ct1 ?? '2015-10-01',
            'pNgay_ct2' => $paramObj->pNgay_ct2 ?? '2015-10-31',
            'pMa_Nt'    => $paramObj->pMa_Nt ?? '',
        ], $connection);
    }
}
