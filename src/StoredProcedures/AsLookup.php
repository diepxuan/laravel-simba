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

class AsLookup
{
    /**
     * Call stored procedure asLookup
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asLookup', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pCodeName' => $paramObj->pCodeName ?? null,
            'pFieldList' => $paramObj->pFieldList ?? null,
            'pTableName' => $paramObj->pTableName ?? null,
            'pWhere' => $paramObj->pWhere ?? null,
            'pLastModDate' => $paramObj->pLastModDate ?? null,
            'pPage_size' => $paramObj->pPage_size ?? null,
            'pPage_num' => $paramObj->pPage_num ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null,
            'paramDefs' => $paramObj->paramDefs ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pageSize' => $paramObj->pageSize ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asLookup with named parameters
     *
     * @param string $Ma_cty
     * @param string $CodeName
     * @param string $FieldList
     * @param string $TableName
     * @param string $Where
     * @param string $LastModDate
     * @param int $Page_size
     * @param int $Page_num
     * @param string $Language
     * @param string $aramDefs
     * @param string $Ma_Cty
     * @param int $ageSize
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $CodeName = null, string $FieldList = null, string $TableName = null, string $Where = null, string $LastModDate = null, int $Page_size = null, int $Page_num = null, string $Language = null, string $aramDefs = null, string $Ma_Cty = null, int $ageSize = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCodeName' => $CodeName,
            'pFieldList' => $FieldList,
            'pTableName' => $TableName,
            'pWhere' => $Where,
            'pLastModDate' => $LastModDate,
            'pPage_size' => $Page_size,
            'pPage_num' => $Page_num,
            'pLanguage' => $Language,
            'paramDefs' => $aramDefs,
            'pMa_Cty' => $Ma_Cty,
            'pageSize' => $ageSize
        ];

        return self::call($params);
    }
}
