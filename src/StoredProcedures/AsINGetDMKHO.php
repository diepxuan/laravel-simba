<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsINGetDMKHO
 * 
 * Stored procedure: asINGetDMKHO
 * Purpose: 
 * 
 * Parameters:
 * (No parameters)
 * 
 * Default values: 
 * 
 * Returns: Collection of query results.
 * 
 * Example call:
 * ```php
 * $params = [
 *     // Provide parameter values
 * ];
 * $result = AsINGetDMKHO::call($params);
 * ```
 */
class AsINGetDMKHO
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMKHO', [

        ], $connection);
    }
}
