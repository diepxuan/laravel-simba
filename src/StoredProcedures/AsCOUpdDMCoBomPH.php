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
 * Class AsCOUpdDMCoBomPH
 * 
 * Stored procedure: asCOUpdDMCoBomPH
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (VARCHAR(3)): input parameter.
 * - @pMa_spct (NVARCHAR(20)): input parameter.
 * - @pNgay1 (SMALLDATETIME): input parameter.
 * - @pNgay2 (SMALLDATETIME): input parameter.
 * - @pDon_gia_luong (DECIMAL(19, 4)): input parameter.
 * - @pGhi_chu (NVARCHAR(255)): input parameter.
 * - @pUser (NVARCHAR(20)): input parameter.
 * - @pRet (INT): output parameter.
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
 * $result = AsCOUpdDMCoBomPH::call($params);
 * ```
 */
class AsCOUpdDMCoBomPH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCOUpdDMCoBomPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pDon_gia_luong' => $params['pDon_gia_luong'] ?? 0.0,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pUser' => $params['pUser'] ?? null,
        ], $connection);
    }
}
