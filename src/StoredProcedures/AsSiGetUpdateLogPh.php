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

class AsSiGetUpdateLogPh
{
    /**
     * Call stored procedure asSiGetUpdateLogPh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetUpdateLogPh', $params, $connection);
    }

    /**
     * Call stored procedure asSiGetUpdateLogPh with named parameters
     *
@return Collection
     */
    public static function callWithParams(): Collection
    {
        $params = [];
        
        return self::call($params);
    }
}
