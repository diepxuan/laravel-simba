<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiInsUpdateLogPh
{
    /**
     * Call stored procedure asSiInsUpdateLogPh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsUpdateLogPh', [
            'pDescription' => $params['pDescription'] ?? null,
            'pNote' => $params['pNote'] ?? null,
            'pProductid' => $params['pProductid'] ?? null,
            'pFunctionMenuid' => $params['pFunctionMenuid'] ?? null,
            'pFunctionName' => $params['pFunctionName'] ?? null,
            'pBugnumber' => $params['pBugnumber'] ?? null,
            'pLinknumber' => $params['pLinknumber'] ?? null,
            'pConnection' => $params['pConnection'] ?? null,
            'pCuserbuild' => $params['pCuserbuild'] ?? null,
            'pLuserbuild' => $params['pLuserbuild'] ?? null,
            'pCUser' => $params['pCUser'] ?? null,
            'pID' => $params['pID'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiInsUpdateLogPh with named parameters
     *
     * @param string $Description
     * @param string $Note
     * @param string $Productid
     * @param string $FunctionMenuid
     * @param string $FunctionName
     * @param string $Bugnumber
     * @param string $Linknumber
     * @param string $Connection
     * @param string $Cuserbuild
     * @param string $Luserbuild
     * @param string $CUser
     * @param int $ID
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Description = null, string $Note = null, string $Productid = null, string $FunctionMenuid = null, string $FunctionName = null, string $Bugnumber = null, string $Linknumber = null, string $Connection = null, string $Cuserbuild = null, string $Luserbuild = null, string $CUser = null, int $ID = null, int $Ret = null): Collection
    {
        $params = [
            'pDescription' => $Description,
            'pNote' => $Note,
            'pProductid' => $Productid,
            'pFunctionMenuid' => $FunctionMenuid,
            'pFunctionName' => $FunctionName,
            'pBugnumber' => $Bugnumber,
            'pLinknumber' => $Linknumber,
            'pConnection' => $Connection,
            'pCuserbuild' => $Cuserbuild,
            'pLuserbuild' => $Luserbuild,
            'pCUser' => $CUser,
            'pID' => $ID,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
