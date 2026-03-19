<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINGetDMVITRI
{
    /**
     * Call stored procedure asINGetDMVITRI
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMVITRI', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pStruct' => $paramObj->pStruct ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetDMVITRI with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vitri
     * @param string $Struct
     * @param string $Ma_kho
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vitri = null, string $Struct = null, string $Ma_kho = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vitri' => $Ma_vitri,
            'pStruct' => $Struct,
            'pMa_kho' => $Ma_kho
        ];

        return self::call($params);
    }
}
