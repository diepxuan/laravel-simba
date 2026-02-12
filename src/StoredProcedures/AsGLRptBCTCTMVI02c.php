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
 * Class AsGLRptBCTCTMVI02c
 * 
 * Stored procedure: asGLRptBCTCTMVI02c
 * Purpose: 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Mô tả tham số
 * - @pMau (NVARCHAR(10)): Mô tả tham số
 * - @pNgay1 (SMALLDATETIME): Mô tả tham số
 * - @pNgay2 (SMALLDATETIME): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: '999' 
 * - @pMau: N'15' 
 * - @pNgay1: '2014-01-01 00:00:00' 
 * - @pNgay2: '2014-12-31 00:00:00'
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
 * $result = AsGLRptBCTCTMVI02c::call($params);
 * ```
 */
class AsGLRptBCTCTMVI02c
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTMVI02c', [
            'pMa_cty' => $params['pMa_cty'] ?? '999' ',
            'pMau' => $params['pMau'] ?? 'N'15' ',
            'pNgay1' => $params['pNgay1'] ?? ''2014-01-01 00:00:00' ',
            'pNgay2' => $params['pNgay2'] ?? '2014-12-31 00:00:00',
        ], $connection);
    }
}
