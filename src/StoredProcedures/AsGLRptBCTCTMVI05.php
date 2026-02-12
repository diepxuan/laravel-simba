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
 * Class AsGLRptBCTCTMVI05
 * 
 * Stored procedure: asGLRptBCTCTMVI05
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
 * - @pMau: ''
 * - @pNgay1: '01/01/2014'
 * - @pNgay2: '01/31/2014'
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
 * $result = AsGLRptBCTCTMVI05::call($params);
 * ```
 */
class AsGLRptBCTCTMVI05
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTMVI05', [
            'pMa_cty' => $params['pMa_cty'] ?? '999',
            'pMau' => $params['pMau'] ?? '',
            'pNgay1' => $params['pNgay1'] ?? '01/01/2014',
            'pNgay2' => $params['pNgay2'] ?? '01/31/2014',
        ], $connection);
    }
}
