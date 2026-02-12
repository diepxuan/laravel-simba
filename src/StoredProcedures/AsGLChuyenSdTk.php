<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLChuyenSdTk
 * 
 * Stored procedure: asGLChuyenSdTk
 * Purpose: Chuyển số dư khách hàng và tài khoản sang năm sau.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNgay_cnt (smalldatetime): Ngày cuối năm trước (ví dụ: '31/12/2022'). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, 50012 nếu ngày đầu năm sau nhỏ hơn hoặc bằng ngày khóa sổ, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pNgay_cnt: null (phải cung cấp).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện chuyển số dư).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pNgay_cnt' => '2022-12-31',
 * ];
 * $result = AsGLChuyenSdTk::call($params);
 * ```
 */
class AsGLChuyenSdTk
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLChuyenSdTk', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pNgay_cnt' => $params['pNgay_cnt'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
