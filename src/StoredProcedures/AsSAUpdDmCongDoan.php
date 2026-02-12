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
 * Class AsSAUpdDmCongDoan
 * 
 * Stored procedure: asSAUpdDmCongDoan
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pMa_congdoan (NVARCHAR(20)): input parameter.
 * - @pMa_sanpham (NVARCHAR(20)): input parameter.
 * - @pTen_cd (NVARCHAR(200)): input parameter.
 * - @pKsd (BIT): input parameter.
 * - @pLUser (NVARCHAR(20)): input parameter.
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
 * $result = AsSAUpdDmCongDoan::call($params);
 * ```
 */
class AsSAUpdDmCongDoan
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDmCongDoan', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_congdoan' => $params['pMa_congdoan'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
            'pTen_cd' => $params['pTen_cd'] ?? null,
            'pKsd' => $params['pKsd'] ?? false,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
