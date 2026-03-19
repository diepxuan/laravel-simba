<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:08
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsUpdreportDrilldownInfo
{
    /**
     * Call stored procedure asUpdreportDrilldownInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdreportDrilldownInfo', [
            'pKey_Menuid' => $paramObj->pKey_Menuid ?? null,
            'pKey_Ma_mau' => $paramObj->pKey_Ma_mau ?? null,
            'pKey_Press_key_name' => $paramObj->pKey_Press_key_name ?? null,
            'pMenuid' => $paramObj->pMenuid ?? null,
            'pMa_mau' => $paramObj->pMa_mau ?? null,
            'pPress_key_name' => $paramObj->pPress_key_name ?? null,
            'pDrilldown_menuid' => $paramObj->pDrilldown_menuid ?? null,
            'pDrilldown_menuid1' => $paramObj->pDrilldown_menuid1 ?? null,
            'pDrilldown_menuid2' => $paramObj->pDrilldown_menuid2 ?? null,
            'pDrilldown_menuid3' => $paramObj->pDrilldown_menuid3 ?? null,
            'pDrilldown_menuid4' => $paramObj->pDrilldown_menuid4 ?? null,
            'pDllname' => $paramObj->pDllname ?? null,
            'pCommand' => $paramObj->pCommand ?? null,
            'pDescription' => $paramObj->pDescription ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdreportDrilldownInfo with named parameters
     *
     * @param string $Key_Menuid
     * @param string $Key_Ma_mau
     * @param string $Key_Press_key_name
     * @param string $Menuid
     * @param string $Ma_mau
     * @param string $Press_key_name
     * @param string $Drilldown_menuid
     * @param string $Drilldown_menuid1
     * @param string $Drilldown_menuid2
     * @param string $Drilldown_menuid3
     * @param string $Drilldown_menuid4
     * @param string $Dllname
     * @param string $Command
     * @param string $Description
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Key_Menuid = null, string $Key_Ma_mau = null, string $Key_Press_key_name = null, string $Menuid = null, string $Ma_mau = null, string $Press_key_name = null, string $Drilldown_menuid = null, string $Drilldown_menuid1 = null, string $Drilldown_menuid2 = null, string $Drilldown_menuid3 = null, string $Drilldown_menuid4 = null, string $Dllname = null, string $Command = null, string $Description = null, int $Ret = null): Collection
    {
        $params = [
            'pKey_Menuid' => $Key_Menuid,
            'pKey_Ma_mau' => $Key_Ma_mau,
            'pKey_Press_key_name' => $Key_Press_key_name,
            'pMenuid' => $Menuid,
            'pMa_mau' => $Ma_mau,
            'pPress_key_name' => $Press_key_name,
            'pDrilldown_menuid' => $Drilldown_menuid,
            'pDrilldown_menuid1' => $Drilldown_menuid1,
            'pDrilldown_menuid2' => $Drilldown_menuid2,
            'pDrilldown_menuid3' => $Drilldown_menuid3,
            'pDrilldown_menuid4' => $Drilldown_menuid4,
            'pDllname' => $Dllname,
            'pCommand' => $Command,
            'pDescription' => $Description,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
