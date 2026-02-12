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
 * Class AsGLRptBCTC04_CheckSL
 * 
 * Stored procedure: asGLRptBCTC04_CheckSL
 * Purpose: Thu tuc lay du lieu va ho tro kiem tra bao cao luu chuyen tien te
 * 
 * Tham số:
 * - @pMa_cty (nvarchar): Mô tả tham số
 * - @pNgay_Ct1 (nvarchar): Mô tả tham số
 * - @pNgay_Ct2 (nvarchar): Mô tả tham số
 * - @pNgay_Ct01 (nvarchar): Mô tả tham số
 * - @pNgay_Ct02 (nvarchar): Mô tả tham số
 * - @pMau (nvarchar): Mô tả tham số
 * - @pMa_nt (nvarchar): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pNgay_Ct1: null
 * - @pNgay_Ct2: null
 * - @pNgay_Ct01: null
 * - @pNgay_Ct02: null
 * - @pMau: null
 * - @pMa_nt: null
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pNgay_Ct1 => '',
 *     @pNgay_Ct2 => '',
 *     @pNgay_Ct01 => '',
 *     @pNgay_Ct02 => '',
 *     @pMau => '',
 *     @pMa_nt => '',
 * ];
 * $result = AsGLRptBCTC04_CheckSL::call($params);
 * ```
 */
class AsGLRptBCTC04_CheckSL
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTC04_CheckSL', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? null,
            'pNgay_Ct01' => $params['pNgay_Ct01'] ?? null,
            'pNgay_Ct02' => $params['pNgay_Ct02'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
        ], $connection);
    }
}
