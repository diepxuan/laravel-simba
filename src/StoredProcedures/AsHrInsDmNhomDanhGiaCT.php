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
 * Class AsHrInsDmNhomDanhGiaCT
 * 
 * Stored procedure: asHrInsDmNhomDanhGiaCT
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pMa_nhdg (NVARCHAR(20)): input parameter.
 * - @pMa_tcdg (NVARCHAR(20)): input parameter.
 * - @pTen_tcdg (NVARCHAR(200)): input parameter.
 * - @pDiem_toi_da (DECIMAL(19, 4)): input parameter.
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
 * $result = AsHrInsDmNhomDanhGiaCT::call($params);
 * ```
 */
class AsHrInsDmNhomDanhGiaCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmNhomDanhGiaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhdg' => $params['pMa_nhdg'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null,
            'pTen_tcdg' => $params['pTen_tcdg'] ?? null,
            'pDiem_toi_da' => $params['pDiem_toi_da'] ?? 0.0,
        ], $connection);
    }
}
