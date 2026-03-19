<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOGetDMTT
{
    /**
     * Call stored procedure asPOGetDMTT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOGetDMTT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tt_po' => $paramObj->pMa_tt_po ?? null,
            'pStruct' => $paramObj->pStruct ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOGetDMTT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tt_po
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tt_po = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tt_po' => $Ma_tt_po,
            'pStruct' => $Struct
        ];

        return self::call($params);
    }
}
