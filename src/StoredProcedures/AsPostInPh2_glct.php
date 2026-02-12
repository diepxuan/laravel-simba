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
 * Class AsPostInPh2_glct
 * 
 * Stored procedure: asPostInPh2_glct
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pStt_rec (NVARCHAR(20): input parameter.
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
 * $result = AsPostInPh2_glct::call($params);
 * ```
 */
class AsPostInPh2_glct
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostInPh2_glct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }
}
