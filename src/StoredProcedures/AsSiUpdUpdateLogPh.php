<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiUpdUpdateLogPh
{
    /**
     * Call stored procedure asSiUpdUpdateLogPh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiUpdUpdateLogPh', [
            'pId' => $params['pId'] ?? null,
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
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'ParentNumber' => $params['ParentNumber'] ?? null,
            'ParentLevel' => $params['ParentLevel'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiUpdUpdateLogPh with named parameters
     *
     * @param int $Id
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
     * @param string $LUser
     * @param int $Ret
     * @param string $ParentNumber
     * @param string $ParentLevel
     * @return Collection
     */
    public static function callWithParams(int $Id = null, string $Description = null, string $Note = null, string $Productid = null, string $FunctionMenuid = null, string $FunctionName = null, string $Bugnumber = null, string $Linknumber = null, string $Connection = null, string $Cuserbuild = null, string $Luserbuild = null, string $LUser = null, int $Ret = null, string $ParentNumber = null, string $ParentLevel = null): Collection
    {
        $params = [
            'pId' => $Id,
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
            'pLUser' => $LUser,
            'pRet' => $Ret,
            'ParentNumber' => $ParentNumber,
            'ParentLevel' => $ParentLevel
        ];
        
        return self::call($params);
    }
}
