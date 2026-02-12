<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLRptBCTCCR01F5
 * 
 * Stored procedure: asGLRptBCTCCR01F5
 * Purpose: ====================================================
 * 
 * Tham số:
 * - @pMa_Cty (NVARCHAR(3)): Mô tả tham số
 * - @pTk (NVARCHAR(20)): Mô tả tham số
 * - @pMa_nt (NVARCHAR(3)): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_Cty: null
 * - @pTk: null
 * - @pMa_nt: null
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_Cty => '',
 *     @pTk => '',
 *     @pMa_nt => '',
 * ];
 * $result = AsGLRptBCTCCR01F5::call($params);
 * ```
 */
class AsGLRptBCTCCR01F5
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCR01F5', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
        ], $connection);
    }
}
