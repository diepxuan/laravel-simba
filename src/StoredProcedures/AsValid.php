<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsValid
{
    /**
     * Call stored procedure asValid
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asValid', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pCodeName' => $params['pCodeName'] ?? null,
            'pCodeValue' => $params['pCodeValue'] ?? null,
            'pFieldList' => $params['pFieldList'] ?? null,
            'pTableName' => $params['pTableName'] ?? null,
            'pWhere' => $params['pWhere'] ?? null,
            'paramDefs' => $params['paramDefs'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asValid with named parameters
     *
     * @param string $Ma_cty
     * @param string $CodeName
     * @param string $CodeValue
     * @param string $FieldList
     * @param string $TableName
     * @param string $Where
     * @param string $aramDefs
     * @param int $Ret
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $CodeName = null, string $CodeValue = null, string $FieldList = null, string $TableName = null, string $Where = null, string $aramDefs = null, int $Ret = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCodeName' => $CodeName,
            'pCodeValue' => $CodeValue,
            'pFieldList' => $FieldList,
            'pTableName' => $TableName,
            'pWhere' => $Where,
            'paramDefs' => $aramDefs,
            'pRet' => $Ret,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
