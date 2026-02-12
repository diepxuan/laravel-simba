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
 * Class AsGLRptBCTCCDTf03C
 * 
 * Stored procedure: asGLRptBCTCCDTf03C
 * Purpose: BAO CAO CHU DAU TU
 * 
 * Tham số:
 * - @pMa_cty (nvarchar): Mô tả tham số
 * - @pNgay1 (nvarchar): Mô tả tham số
 * - @pNgay2 (nvarchar): Mô tả tham số
 * - @pTk (nvarchar): Mô tả tham số
 * - @pMa_cty (nvarchar): Mô tả tham số
 * - @pTk (nvarchar): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pNgay1: null
 * - @pNgay2: null
 * - @pTk: null
 * - @pMa_cty: null
 * - @pTk: null
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
 *     @pMa_cty => '',
 *     @pTk => '',
 * ];
 * $result = AsGLRptBCTCCDTf03C::call($params);
 * ```
 */
class AsGLRptBCTCCDTf03C
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCDTf03C', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTk' => $params['pTk'] ?? null,
        ], $connection);
    }
}
