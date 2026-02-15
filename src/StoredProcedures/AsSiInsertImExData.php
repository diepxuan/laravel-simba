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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsertImExData', [
            'pXmlData' => $params['pXmlData'] ?? null,
            'pTable_name' => $params['pTable_name'] ?? null,
            'pWs_id' => $params['pWs_id'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pProc' => $params['pProc'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pDel' => $params['pDel'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pDropTable' => $params['pDropTable'] ?? null,
            'pColumnType' => $params['pColumnType'] ?? null,
            'pComlumName' => $params['pComlumName'] ?? null,
            'pStr' => $params['pStr'] ?? null,
            'pCodeName' => $params['pCodeName'] ?? null,
            'pSTT_rec' => $params['pSTT_rec'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null
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
