<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsARRptBCCN01SL
{
    /**
     * Call stored procedure asARRptBCCN01SL
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN01SL', [
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'pSysMsg2' => $paramObj->pSysMsg2 ?? null,
            'pSysMsg3' => $paramObj->pSysMsg3 ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asARRptBCCN01SL with named parameters
     *
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param string $SysMsg3
     * @return Collection
     */
    public static function callWithParams(string $SysMsg1 = null, string $SysMsg2 = null, string $SysMsg3 = null): Collection
    {
        $params = [
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pSysMsg3' => $SysMsg3
        ];

        return self::call($params);
    }
}
