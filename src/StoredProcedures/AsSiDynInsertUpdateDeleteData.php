<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiDynInsertUpdateDeleteData
{
    /**
     * Call stored procedure asSiDynInsertUpdateDeleteData
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiDynInsertUpdateDeleteData', [
            'pXmlData' => $paramObj->pXmlData ?? null,
            'pTable_name' => $paramObj->pTable_name ?? null,
            'pMode' => $paramObj->pMode ?? null,
            'pKeyColumns' => $paramObj->pKeyColumns ?? null,
            'pColumnType' => $paramObj->pColumnType ?? null,
            'pComlumName' => $paramObj->pComlumName ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pStr' => $paramObj->pStr ?? null,
            'psWhere' => $paramObj->psWhere ?? null,
            'pCl_Udp' => $paramObj->pCl_Udp ?? null,
            'pStrOn' => $paramObj->pStrOn ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiDynInsertUpdateDeleteData with named parameters
     *
     * @param mixed $XmlData
     * @param string $Table_name
     * @param string $Mode
     * @param string $KeyColumns
     * @param mixed $ColumnType
     * @param mixed $ComlumName
     * @param string $ParamDefines
     * @param mixed $Str
     * @param mixed $sWhere
     * @param mixed $Cl_Udp
     * @param mixed $StrOn
     * @return Collection
     */
    public static function callWithParams(mixed $XmlData = null, string $Table_name = null, string $Mode = null, string $KeyColumns = null, mixed $ColumnType = null, mixed $ComlumName = null, string $ParamDefines = null, mixed $Str = null, mixed $sWhere = null, mixed $Cl_Udp = null, mixed $StrOn = null): Collection
    {
        $params = [
            'pXmlData' => $XmlData,
            'pTable_name' => $Table_name,
            'pMode' => $Mode,
            'pKeyColumns' => $KeyColumns,
            'pColumnType' => $ColumnType,
            'pComlumName' => $ComlumName,
            'ParamDefines' => $ParamDefines,
            'pStr' => $Str,
            'psWhere' => $sWhere,
            'pCl_Udp' => $Cl_Udp,
            'pStrOn' => $StrOn
        ];

        return self::call($params);
    }
}
