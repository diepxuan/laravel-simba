<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:40:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLDelKC
 * 
 * Stored procedure: asGLDelKC
 * Purpose: Xoá các bút toán kết chuyển tự động đã post sổ cái.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pngay1 (smalldatetime): Ngày bắt đầu kỳ. Bắt buộc.
 * - @pngay2 (smalldatetime): Ngày kết thúc kỳ. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản nguồn (có thể dùng wildcard '%'). Bắt buộc.
 * - @pTk_du (nvarchar(20)): Tài khoản đích (có thể dùng wildcard '%'). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pngay1: ngày đầu tháng hiện tại.
 * - pngay2: ngày cuối tháng hiện tại.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'GL3',
 *     'pngay1' => '2023-01-01',
 *     'pngay2' => '2023-01-31',
 *     'pTk' => '511',
 *     'pTk_du' => '911',
 * ];
 * $result = AsGLDelKC::call($params);
 * ```
 */
class AsGLDelKC
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Tính ngày đầu tháng và cuối tháng hiện tại nếu không cung cấp
        $pngay1 = $params['pngay1'] ?? date('Y-m-01');
        $pngay2 = $params['pngay2'] ?? date('Y-m-t');

        return ProcedureCaller::call('asGLDelKC', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            'pngay1'  => $pngay1,
            'pngay2'  => $pngay2,
            'pTk'     => $params['pTk'] ?? null,
            'pTk_du'  => $params['pTk_du'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
