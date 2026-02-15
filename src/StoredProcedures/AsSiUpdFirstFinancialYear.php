<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiUpdFirstFinancialYear
{
    /**
     * Call stored procedure asSiUpdFirstFinancialYear
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiUpdFirstFinancialYear', $params, $connection);
    }

    /**
     * Call stored procedure asSiUpdFirstFinancialYear with named parameters
     *
     * @param string $Ngay1
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ngay1 = null, int $Ret = null): Collection
    {
        $params = [
            'pNgay1' => $Ngay1,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
