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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiUpdUpdateLogPh', [
            'pId' => $paramObj->pId ?? null,
            'pDescription' => $paramObj->pDescription ?? null,
            'pNote' => $paramObj->pNote ?? null,
            'pProductid' => $paramObj->pProductid ?? null,
            'pFunctionMenuid' => $paramObj->pFunctionMenuid ?? null,
            'pFunctionName' => $paramObj->pFunctionName ?? null,
            'pBugnumber' => $paramObj->pBugnumber ?? null,
            'pLinknumber' => $paramObj->pLinknumber ?? null,
            'pConnection' => $paramObj->pConnection ?? null,
            'pCuserbuild' => $paramObj->pCuserbuild ?? null,
            'pLuserbuild' => $paramObj->pLuserbuild ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null,
            'ParentNumber' => $paramObj->ParentNumber ?? null,
            'ParentLevel' => $paramObj->ParentLevel ?? null
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
