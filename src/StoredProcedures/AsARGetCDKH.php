<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARGetCDKH
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetCDKH', [
            'pMa_Cty'   => $paramObj->pMa_Cty ?? null,
            'pNam'      => $paramObj->pNam ?? null,
            'pTk'       => $paramObj->pTk ?? null,
            'pMa_kh'    => $paramObj->pMa_kh ?? null,
            'pMa_hd'    => $paramObj->pMa_hd ?? null,
            'pMa_bp'    => $paramObj->pMa_bp ?? null,
            'pMa_spct'  => $paramObj->pMa_spct ?? null,
            'pLoai'     => $paramObj->pLoai ?? null,
        ], $connection);
    }
}