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
 * Class AsSIGetDMBP
 * 
 * Stored procedure: asSIGetDMBP
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pMa_bp (nvarchar(20)): input parameter.
 * - @pStruct (nvarchar(1)): input parameter.
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
 * $result = AsSIGetDMBP::call($params);
 * ```
 */
class AsSIGetDMBP
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMBP', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
        ], $connection);
    }
}
