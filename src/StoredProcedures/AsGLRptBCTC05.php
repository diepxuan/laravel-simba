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
 * Class AsGLRptBCTC05
 * 
 * Stored procedure: asGLRptBCTC05
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pMa_Cty (nvarchar): Mô tả tham số
 * - @pNgay_Ct1 (nvarchar): Mô tả tham số
 * - @pNgay_Ct2 (nvarchar): Mô tả tham số
 * - @pNgay_Ct01 (nvarchar): Mô tả tham số
 * - @pNgay_Ct02 (nvarchar): Mô tả tham số
 * - @pMau (nvarchar): Mô tả tham số
 * - @pMa_bp (nvarchar): Mô tả tham số
 * - @pMa_Nt (nvarchar): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_Cty: null
 * - @pNgay_Ct1: null
 * - @pNgay_Ct2: null
 * - @pNgay_Ct01: null
 * - @pNgay_Ct02: null
 * - @pMau: null
 * - @pMa_bp: null
 * - @pMa_Nt: null
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_Cty => '',
 *     @pNgay_Ct1 => '',
 *     @pNgay_Ct2 => '',
 *     @pNgay_Ct01 => '',
 *     @pNgay_Ct02 => '',
 *     @pMau => '',
 *     @pMa_bp => '',
 *     @pMa_Nt => '',
 * ];
 * $result = AsGLRptBCTC05::call($params);
 * ```
 */
class AsGLRptBCTC05
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTC05', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? null,
            'pNgay_Ct01' => $params['pNgay_Ct01'] ?? null,
            'pNgay_Ct02' => $params['pNgay_Ct02'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
        ], $connection);
    }
}
