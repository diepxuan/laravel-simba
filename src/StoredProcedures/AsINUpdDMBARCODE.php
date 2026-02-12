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
 * Class AsINUpdDMBARCODE
 * 
 * Stored procedure: asINUpdDMBARCODE
 * Purpose: ================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pMa_vt (nvarchar(20)): Tham số đầu vào.
 * - @pMa_vach (nvarchar(128)): Tham số đầu vào.
 * - @pKsd (bit): Tham số đầu vào.
 * - @pLUser (nvarchar(20)): Tham số đầu vào.
 * - @pRet (int OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện update).
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMa_vt' => '',
            'pMa_vach' => '',
            'pKsd' => '',
            'pLUser' => '',
 * ];
 * $result = AsINUpdDMBARCODE::call($params);
 * ```
 */
class AsINUpdDMBARCODE
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdDMBARCODE', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_vach' => $params['pMa_vach'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
