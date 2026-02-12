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
 * Class AsGLRptBCT03
 * 
 * Stored procedure: asGLRptBCT03
 * Purpose: ===========================================
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Mô tả tham số
 * - @pNgay1 (SMALLDATETIME): Mô tả tham số
 * - @pNgay2 (SMALLDATETIME): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: 'A01'
 * - @pNgay1: '20150201'
 * - @pNgay2: '20150228'
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 * ];
 * $result = AsGLRptBCT03::call($params);
 * ```
 */
class AsGLRptBCT03
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCT03', [
            'pMa_cty' => $params['pMa_cty'] ?? 'A01',
            'pNgay1' => $params['pNgay1'] ?? '20150201',
            'pNgay2' => $params['pNgay2'] ?? '20150228',
        ], $connection);
    }
}
