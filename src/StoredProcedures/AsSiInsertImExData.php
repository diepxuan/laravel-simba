<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiInsertImExData
{
    /**
     * Call stored procedure asSiInsertImExData
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsertImExData', [
            'pXmlData' => $paramObj->pXmlData ?? null,
            'pTable_name' => $paramObj->pTable_name ?? null,
            'pWs_id' => $paramObj->pWs_id ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pProc' => $paramObj->pProc ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pDel' => $paramObj->pDel ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pDropTable' => $paramObj->pDropTable ?? null,
            'pColumnType' => $paramObj->pColumnType ?? null,
            'pComlumName' => $paramObj->pComlumName ?? null,
            'pStr' => $paramObj->pStr ?? null,
            'pCodeName' => $paramObj->pCodeName ?? null,
            'pSTT_rec' => $paramObj->pSTT_rec ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiInsertImExData with named parameters
     *
     * @param mixed $XmlData
     * @param mixed $Table_name
     * @param mixed $Ws_id
     * @param mixed $Ngay1
     * @param mixed $Ngay2
     * @param mixed $Proc
     * @param mixed $Ma_cty
     * @param mixed $Del
     * @param mixed $Ma_ct
     * @param mixed $DropTable
     * @param mixed $ColumnType
     * @param mixed $ComlumName
     * @param mixed $Str
     * @param mixed $CodeName
     * @param mixed $STT_rec
     * @param string $ParamDefines
     * @return Collection
     */
    public static function callWithParams(mixed $XmlData = null, mixed $Table_name = null, mixed $Ws_id = null, mixed $Ngay1 = null, mixed $Ngay2 = null, mixed $Proc = null, mixed $Ma_cty = null, mixed $Del = null, mixed $Ma_ct = null, mixed $DropTable = null, mixed $ColumnType = null, mixed $ComlumName = null, mixed $Str = null, mixed $CodeName = null, mixed $STT_rec = null, string $ParamDefines = null): Collection
    {
        $params = [
            'pXmlData' => $XmlData,
            'pTable_name' => $Table_name,
            'pWs_id' => $Ws_id,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pProc' => $Proc,
            'pMa_cty' => $Ma_cty,
            'pDel' => $Del,
            'pMa_ct' => $Ma_ct,
            'pDropTable' => $DropTable,
            'pColumnType' => $ColumnType,
            'pComlumName' => $ComlumName,
            'pStr' => $Str,
            'pCodeName' => $CodeName,
            'pSTT_rec' => $STT_rec,
            'ParamDefines' => $ParamDefines
        ];

        return self::call($params);
    }
}
