<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:36:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCOGetDMCoBomPH
 * 
 * Stored procedure: asCOGetDMCoBomPH
 * Purpose: =========================================================================
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(20)): Tham số đầu vào.
 * - @pma_spct (NVARCHAR(20)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pma_spct' => '',
 * ];
 * $result = AsCOGetDMCoBomPH::call($params);
 * ```
 */
class AsCOGetDMCoBomPH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCOGetDMCoBomPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pma_spct' => $params['pma_spct'] ?? null,
        ], $connection);
    }
}
