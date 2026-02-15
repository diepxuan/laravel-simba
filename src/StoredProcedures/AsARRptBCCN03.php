<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN03
{
    /**
     * Call stored procedure asARRptBCCN03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN03', [
            'pSysMsg1' => $params['pSysMsg1'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asARRptBCCN03 with named parameters
     *
     * @param string $SysMsg1
     * @return Collection
     */
    public static function callWithParams(string $SysMsg1 = null): Collection
    {
        $params = [
            'pSysMsg1' => $SysMsg1
        ];
        
        return self::call($params);
    }
}
