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
 * Class AsGLRptBCTCCR04
 * 
 * Stored procedure: asGLRptBCTCCR04
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pMa_Cty (nvarchar(3)): Tham số đầu vào.
 * - @pNam (int): Tham số đầu vào.
 * - @pNgay_Ct1 (smalldatetime): Tham số đầu vào.
 * - @pNgay_Ct2 (smalldatetime): Tham số đầu vào.
 * - @pNgay_Ct01 (smalldatetime): Tham số đầu vào.
 * - @pNgay_Ct02 (smalldatetime): Tham số đầu vào.
 * - @pMau (char(30)): Tham số đầu vào.
 * - @pMa_nt (NVARCHAR(3)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_Cty' => '',
            'pNam' => '',
            'pNgay_Ct1' => '',
            'pNgay_Ct2' => '',
            'pNgay_Ct01' => '',
            'pNgay_Ct02' => '',
            'pMau' => '',
            'pMa_nt' => '',
 * ];
 * $result = AsGLRptBCTCCR04::call($params);
 * ```
 */
class AsGLRptBCTCCR04
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCR04', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? null,
            'pNgay_Ct01' => $params['pNgay_Ct01'] ?? null,
            'pNgay_Ct02' => $params['pNgay_Ct02'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
        ], $connection);
    }
}
