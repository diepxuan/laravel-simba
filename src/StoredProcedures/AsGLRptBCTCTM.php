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
 * Class AsGLRptBCTCTM
 * 
 * Stored procedure: asGLRptBCTCTM
 * Purpose: =============================================
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Mô tả tham số
 * - @pMau (NVARCHAR(10)): Mô tả tham số
 * - @pNgay1 (SMALLDATETIME): Mô tả tham số
 * - @pNgay2 (SMALLDATETIME): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pMau: null
 * - @pNgay1: null
 * - @pNgay2: null
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pMau => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 * ];
 * $result = AsGLRptBCTCTM::call($params);
 * ```
 */
class AsGLRptBCTCTM
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTM', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
        ], $connection);
    }
}
