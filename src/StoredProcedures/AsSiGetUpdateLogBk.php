<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiGetUpdateLogBk
{
    /**
     * Call stored procedure asSiGetUpdateLogBk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetUpdateLogBk', [
            'pID' => $params['pID'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiGetUpdateLogBk with named parameters
     *
     * @param int $ID
     * @return Collection
     */
    public static function callWithParams(int $ID = null): Collection
    {
        $params = [
            'pID' => $ID
        ];
        
        return self::call($params);
    }
}
