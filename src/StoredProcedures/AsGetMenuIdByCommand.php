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
 * Class AsGetMenuIdByCommand
 * 
 * Stored procedure: asGetMenuIdByCommand
 * Purpose: 
 * 
 * Parameters:
 * - @pCmd (NVARCHAR(200): input parameter.
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
 * $result = AsGetMenuIdByCommand::call($params);
 * ```
 */
class AsGetMenuIdByCommand
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetMenuIdByCommand', [
            'pCmd' => $params['pCmd'] ?? null,
        ], $connection);
    }
}
