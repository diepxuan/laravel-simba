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
 * Class AsGLRptNKC06
 * 
 * Stored procedure: asGLRptNKC06
 * Purpose: ==================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pNgay_ct1 (smalldatetime): Tham số đầu vào.
 * - @pNgay_ct2 (smalldatetime): Tham số đầu vào.
 * - @pTk (nvarchar(20)): Tham số đầu vào.
 * - @pMa_Nt (nvarchar(3)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pNgay_ct1' => '',
            'pNgay_ct2' => '',
            'pTk' => '',
            'pMa_Nt' => '',
 * ];
 * $result = AsGLRptNKC06::call($params);
 * ```
 */
class AsGLRptNKC06
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKC06', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ct1' => $params['pNgay_ct1'] ?? null,
            'pNgay_ct2' => $params['pNgay_ct2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
        ], $connection);
    }
}
