<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInCalGiaTB_GiaChung
{
    /**
     * Call stored procedure asInCalGiaTB_GiaChung
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInCalGiaTB_GiaChung', $params, $connection);
    }

    /**
     * Call stored procedure asInCalGiaTB_GiaChung with named parameters
     *
@return Collection
     */
    public static function callWithParams(): Collection
    {
        $params = [];
        
        return self::call($params);
    }
}
