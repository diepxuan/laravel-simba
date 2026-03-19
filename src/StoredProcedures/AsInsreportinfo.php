<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsInsreportinfo
{
    /**
     * Call stored procedure asInsreportinfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsreportinfo', [
            'pMenuid' => $paramObj->pMenuid ?? null,
            'pMa_mau' => $paramObj->pMa_mau ?? null,
            'pCtlclass' => $paramObj->pCtlclass ?? null,
            'pSpname' => $paramObj->pSpname ?? null,
            'pRptname' => $paramObj->pRptname ?? null,
            'pIsdefault' => $paramObj->pIsdefault ?? null,
            'pBang_chu' => $paramObj->pBang_chu ?? null,
            'pBang_chu0' => $paramObj->pBang_chu0 ?? null,
            'pDynReportFields' => $paramObj->pDynReportFields ?? null,
            'pHasNT' => $paramObj->pHasNT ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsreportinfo with named parameters
     *
     * @param string $Menuid
     * @param string $Ma_mau
     * @param string $Ctlclass
     * @param string $Spname
     * @param string $Rptname
     * @param bool $Isdefault
     * @param string $Bang_chu
     * @param string $Bang_chu0
     * @param string $DynReportFields
     * @param bool $HasNT
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Menuid = null, string $Ma_mau = null, string $Ctlclass = null, string $Spname = null, string $Rptname = null, bool $Isdefault = null, string $Bang_chu = null, string $Bang_chu0 = null, string $DynReportFields = null, bool $HasNT = null, int $Ret = null): Collection
    {
        $params = [
            'pMenuid' => $Menuid,
            'pMa_mau' => $Ma_mau,
            'pCtlclass' => $Ctlclass,
            'pSpname' => $Spname,
            'pRptname' => $Rptname,
            'pIsdefault' => $Isdefault,
            'pBang_chu' => $Bang_chu,
            'pBang_chu0' => $Bang_chu0,
            'pDynReportFields' => $DynReportFields,
            'pHasNT' => $HasNT,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
