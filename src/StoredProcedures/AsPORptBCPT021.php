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
 * Class AsPORptBCPT021
 * 
 * Stored procedure: asPORptBCPT021
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pngay1 (SMALLDATETIME): input parameter.
 * - @pNgay2 (SMALLDATETIME): input parameter.
 * - @pPOct1 (NVARCHAR(12)): input parameter.
 * - @pPOct2 (NVARCHAR(12)): input parameter.
 * - @pMa_kh (NVARCHAR(20)): input parameter.
 * - @pMa_nhkh (NVARCHAR(8)): input parameter.
 * - @pMa_plkh1 (NVARCHAR(8)): input parameter.
 * - @pMa_plkh2 (NVARCHAR(8)): input parameter.
 * - @pMa_plkh3 (NVARCHAR(8)): input parameter.
 * - @pMa_hd (NVARCHAR(20)): input parameter.
 * - @pMa_nhhd (NVARCHAR(8)): input parameter.
 * - @pMa_NT (NVARCHAR(3)): input parameter.
 * - @pMa_vt (NVARCHAR(20)): input parameter.
 * - @pMa_nhvt (NVARCHAR(8)): input parameter.
 * - @pMa_plvt1 (NVARCHAR(8)): input parameter.
 * - @pMa_plvt2 (NVARCHAR(8)): input parameter.
 * - @pMa_plvt3 (NVARCHAR(8)): input parameter.
 * - @pma_tt_po (NVARCHAR(20)): input parameter.
 * - @pStatus (NVARCHAR(1)): input parameter.
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
 * $result = AsPORptBCPT021::call($params);
 * ```
 */
class AsPORptBCPT021
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptBCPT021', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pngay1' => $params['pngay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pPOct1' => $params['pPOct1'] ?? null,
            'pPOct2' => $params['pPOct2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pma_tt_po' => $params['pma_tt_po'] ?? null,
            'pStatus' => $params['pStatus'] ?? null,
        ], $connection);
    }
}
