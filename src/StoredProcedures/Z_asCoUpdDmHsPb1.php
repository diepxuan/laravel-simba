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

class Z_asCoUpdDmHsPb1
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCoUpdDmHsPb1', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pThang'  => $paramObj->pThang ?? null,
            'pNam'  => $paramObj->pNam ?? null,
            'pMa_sp'  => $paramObj->pMa_sp ?? null,
            'pTk'  => $paramObj->pTk ?? null,
            'pTen_sp'  => $paramObj->pTen_sp ?? null,
            'pHeso_621'  => $paramObj->pHeso_621 ?? null,
            'pHeso_622'  => $paramObj->pHeso_622 ?? null,
            'pHeso_td'  => $paramObj->pHeso_td ?? null,
            'pThs_621'  => $paramObj->pThs_621 ?? null,
            'pThs_622'  => $paramObj->pThs_622 ?? null,
            'pThs_td'  => $paramObj->pThs_td ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
