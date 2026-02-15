<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN01
{
    /**
     * Call stored procedure asARRptBCCN01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN01', [
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null,
            'pSysMsg3' => $params['pSysMsg3'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asARRptBCCN01 with named parameters
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
