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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsreportinfo', [
            'pMenuid' => $params['pMenuid'] ?? null,
            'pMa_mau' => $params['pMa_mau'] ?? null,
            'pCtlclass' => $params['pCtlclass'] ?? null,
            'pSpname' => $params['pSpname'] ?? null,
            'pRptname' => $params['pRptname'] ?? null,
            'pIsdefault' => $params['pIsdefault'] ?? null,
            'pBang_chu' => $params['pBang_chu'] ?? null,
            'pBang_chu0' => $params['pBang_chu0'] ?? null,
            'pDynReportFields' => $params['pDynReportFields'] ?? null,
            'pHasNT' => $params['pHasNT'] ?? null,
            'pRet' => $params['pRet'] ?? null
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
