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
 * Class AsGLRptBCTCTMVI15a
 * 
 * Stored procedure: asGLRptBCTCTMVI15a
 * Purpose: @pTk_01 NVARCHAR(20)='311'
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pMau (NVARCHAR(10)): Tham số đầu vào.
 * - @pNgay1 (SMALLDATETIME): Tham số đầu vào.
 * - @pNgay2 (SMALLDATETIME): Tham số đầu vào.
 * - @pTk_01 (NVARCHAR(20)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMau' => '',
            'pNgay1' => '',
            'pNgay2' => '',
            'pTk_01' => '',
 * ];
 * $result = AsGLRptBCTCTMVI15a::call($params);
 * ```
 */
class AsGLRptBCTCTMVI15a
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTMVI15a', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
        ], $connection);
    }
}
