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
 * Class AsGLRptBCTCTMVI25a
 * 
 * Stored procedure: asGLRptBCTCTMVI25a
 * Purpose: 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mô tả tham số
 * - @pMau (nvarchar(10)): Mô tả tham số
 * - @pNgay1 (smalldatetime): Mô tả tham số
 * - @pNgay2 (smalldatetime): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pMau: null
 * - @pNgay1: null
 * - @pNgay2: null
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pMau => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 * ];
 * $result = AsGLRptBCTCTMVI25a::call($params);
 * ```
 */
class AsGLRptBCTCTMVI25a
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTMVI25a', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
        ], $connection);
    }
}
