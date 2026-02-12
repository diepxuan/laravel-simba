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
 * Class AsGLRptBCTC04
 * 
 * Stored procedure: asGLRptBCTC04
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pMa_Cty (nvarchar(3)): Mô tả tham số
 * - @pQd_cdkt (nvarchar(10)): Mô tả tham số
 * - @pNgay_Ct1 (smalldatetime): Mô tả tham số
 * - @pNgay_Ct2 (smalldatetime): Mô tả tham số
 * - @pNgay_Ct01 (smalldatetime): Mô tả tham số
 * - @pNgay_Ct02 (smalldatetime): Mô tả tham số
 * - @pMau (char(30)): Mô tả tham số
 * - @pMa_nt (NVARCHAR(3)): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_Cty: null
 * - @pQd_cdkt: null
 * - @pNgay_Ct1: null
 * - @pNgay_Ct2: null
 * - @pNgay_Ct01: null
 * - @pNgay_Ct02: null
 * - @pMau: ''
 * - @pMa_nt: ''
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_Cty => '',
 *     @pQd_cdkt => '',
 *     @pNgay_Ct1 => '',
 *     @pNgay_Ct2 => '',
 *     @pNgay_Ct01 => '',
 *     @pNgay_Ct02 => '',
 *     @pMau => '',
 *     @pMa_nt => '',
 * ];
 * $result = AsGLRptBCTC04::call($params);
 * ```
 */
class AsGLRptBCTC04
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTC04', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pQd_cdkt' => $params['pQd_cdkt'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? null,
            'pNgay_Ct01' => $params['pNgay_Ct01'] ?? null,
            'pNgay_Ct02' => $params['pNgay_Ct02'] ?? null,
            'pMau' => $params['pMau'] ?? '',
            'pMa_nt' => $params['pMa_nt'] ?? '',
        ], $connection);
    }
}
