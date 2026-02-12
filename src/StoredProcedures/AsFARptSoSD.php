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
 * Class AsFARptSoSD
 * 
 * Stored procedure: asFARptSoSD
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pNgay1 (smalldatetime): input parameter.
 * - @pNgay2 (smalldatetime): input parameter.
 * - @pMa_tscd (nvarchar(20)): input parameter.
 * - @pMa_cc (nvarchar(20)): input parameter.
 * - @pMa_bpsd (nvarchar(20)): input parameter.
 * - @pLoai (TINYINT): input parameter.
 * - @pRet (int): output parameter.
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
 * $result = AsFARptSoSD::call($params);
 * ```
 */
class AsFARptSoSD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFARptSoSD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_tscd' => $params['pMa_tscd'] ?? null,
            'pMa_cc' => $params['pMa_cc'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pLoai' => $params['pLoai'] ?? 0,
        ], $connection);
    }
}
