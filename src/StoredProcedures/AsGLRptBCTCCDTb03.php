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
 * Class AsGLRptBCTCCDTb03
 * 
 * Stored procedure: asGLRptBCTCCDTb03
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar): Mô tả tham số
 * - @pNgay1 (nvarchar): Mô tả tham số
 * - @pNgay2 (nvarchar): Mô tả tham số
 * - @pTk (nvarchar): Mô tả tham số
 * - @pBac (nvarchar): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pNgay1: null
 * - @pNgay2: null
 * - @pTk: null
 * - @pBac: null
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 *     @pTk => '',
 *     @pBac => '',
 * ];
 * $result = AsGLRptBCTCCDTb03::call($params);
 * ```
 */
class AsGLRptBCTCCDTb03
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCDTb03', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pBac' => $params['pBac'] ?? null,
        ], $connection);
    }
}
