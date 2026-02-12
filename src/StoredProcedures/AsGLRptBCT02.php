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
 * Class AsGLRptBCT02
 * 
 * Stored procedure: asGLRptBCT02
 * Purpose: ==================================================================
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pNgay1 (SMALLDATETIME): Tham số đầu vào.
 * - @pNgay2 (SMALLDATETIME): Tham số đầu vào.
 * - @pThue_suat (NUMERIC): Tham số đầu vào.
 * - @pTk (NVARCHAR(20)): Tham số đầu vào.
 * - @pTk_du (NVARCHAR(20)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pNgay1' => '',
            'pNgay2' => '',
            'pThue_suat' => '',
            'pTk' => '',
            'pTk_du' => '',
 * ];
 * $result = AsGLRptBCT02::call($params);
 * ```
 */
class AsGLRptBCT02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCT02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pThue_suat' => $params['pThue_suat'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
        ], $connection);
    }
}
