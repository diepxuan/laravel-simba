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
 * Class AsGLCR1GetMaSo_MaBang
 * 
 * Stored procedure: asGLCR1GetMaSo_MaBang
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pTk (nvarchar(20): input parameter.
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
 * $result = AsGLCR1GetMaSo_MaBang::call($params);
 * ```
 */
class AsGLCR1GetMaSo_MaBang
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLCR1GetMaSo_MaBang', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTk' => $params['pTk'] ?? null,
        ], $connection);
    }
}
