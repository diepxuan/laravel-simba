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
 * Class AsGLRptBCTCTMVI12
 * 
 * Stored procedure: asGLRptBCTCTMVI12
 * Purpose: Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pMau (NVARCHAR(10)): Tham số đầu vào.
 * - @pNgay1 (SMALLDATETIME): Tham số đầu vào.
 * - @pNgay2 (SMALLDATETIME): Tham số đầu vào.
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
 * ];
 * $result = AsGLRptBCTCTMVI12::call($params);
 * ```
 */
class AsGLRptBCTCTMVI12
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTMVI12', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
        ], $connection);
    }
}
