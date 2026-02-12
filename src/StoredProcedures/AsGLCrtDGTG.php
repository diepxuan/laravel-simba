<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:52:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCrtDGTG
 * 
 * Stored procedure: asGLCrtDGTG
 * Purpose: Tạo bút toán đánh giá tỷ giá.
 * 
 * Tham số:
 * - @pma_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pma_ct (nvarchar(3)): Mã chứng từ (ví dụ: 'GL5'). Bắt buộc.
 * - @pma_nt (nvarchar(3)): Mã ngoại tệ. Bắt buộc.
 * - @pstt (int): Số thứ tự đánh giá tỷ giá (tham chiếu bảng gldmdgtg). Bắt buộc.
 * - @pngay1 (smalldatetime): Ngày bắt đầu kỳ đánh giá. Bắt buộc.
 * - @pngay2 (smalldatetime): Ngày kết thúc kỳ đánh giá. Bắt buộc.
 * - @puser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pma_cty: mã công ty mặc định (SModel::CTY).
 * - pma_ct: null (phải cung cấp).
 * - pma_nt: 'VND'.
 * - pstt: 1.
 * - pngay1: ngày đầu tháng hiện tại.
 * - pngay2: ngày cuối tháng hiện tại.
 * - puser: null (phải cung cấp).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện tạo bút toán).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pma_cty' => '001',
 *     'pma_ct' => 'GL5',
 *     'pma_nt' => 'USD',
 *     'pstt' => 1,
 *     'pngay1' => '2023-01-01',
 *     'pngay2' => '2023-01-31',
 *     'puser' => 'admin',
 * ];
 * $result = AsGLCrtDGTG::call($params);
 * ```
 */
class AsGLCrtDGTG
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        // Tính ngày đầu tháng và cuối tháng hiện tại nếu không cung cấp
        $pngay1 = $params['pngay1'] ?? date('Y-m-01');
        $pngay2 = $params['pngay2'] ?? date('Y-m-t');

        return ProcedureCaller::call('asGLCrtDGTG', [
            'pma_cty' => $params['pma_cty'] ?? SModel::CTY,
            'pma_ct'  => $params['pma_ct'] ?? null,
            'pma_nt'  => $params['pma_nt'] ?? 'VND',
            'pstt'    => $params['pstt'] ?? 1,
            'pngay1'  => $pngay1,
            'pngay2'  => $pngay2,
            'puser'   => $params['puser'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
