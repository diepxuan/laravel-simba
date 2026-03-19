<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 12:16:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARDelCDKH
{
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARDelCDKH', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pMa_kh'   => $paramObj->pMa_kh ?? null,
            'pTk'      => $paramObj->pTk ?? null,
            'pMa_Nt'   => $paramObj->pMa_Nt ?? null,
            'pMa_SpCt' => $paramObj->pMa_SpCt ?? null,
            'pMa_hd'   => $paramObj->pMa_hd ?? null,
            'pMa_Bp'   => $paramObj->pMa_Bp ?? null,
            'pNam'     => $paramObj->pNam ?? null,
        ], $connection);
    }
}
