<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIMaintain021
{
    /**
     * Call stored procedure asSIMaintain021
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIMaintain021', $params, $connection);
    }

    /**
     * Call stored procedure asSIMaintain021 with named parameters
     *
@return Collection
     */
    public static function callWithParams(): Collection
    {
        $params = [];
        
        return self::call($params);
    }
}
