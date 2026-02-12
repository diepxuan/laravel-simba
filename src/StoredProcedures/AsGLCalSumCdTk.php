<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:40:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCalSumCdTk
 * 
 * Stored procedure: asGLCalSumCdTk
 * Purpose: Tính tổng theo tài khoản từ bảng GLCDTK.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản (có thể dùng wildcard '%' ở cuối). Bắt buộc.
 * - @pNam (int): Năm cần tính tổng. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ (có thể dùng wildcard '%' ở cuối). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pNam: năm hiện tại.
 * - pMa_nt: 'VND' (Việt Nam Đồng).
 * 
 * Kết quả trả về: Một bản ghi chứa các tổng:
 * - du_no_nt00: tổng dư nợ đầu kỳ ngoại tệ.
 * - du_co_nt00: tổng dư có đầu kỳ ngoại tệ.
 * - du_no00: tổng dư nợ đầu kỳ nội tệ.
 * - du_co00: tổng dư có đầu kỳ nội tệ.
 * - du_no_nt: tổng dư nợ trong kỳ ngoại tệ.
 * - du_co_nt: tổng dư có trong kỳ ngoại tệ.
 * - du_no: tổng dư nợ trong kỳ nội tệ.
 * - du_co: tổng dư có trong kỳ nội tệ.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pTk' => '111',
 *     'pNam' => 2023,
 *     'pMa_nt' => 'VND',
 * ];
 * $result = AsGLCalSumCdTk::call($params);
 * $sums = $result->first();
 * echo $sums->du_no_nt00;
 * ```
 */
class AsGLCalSumCdTk
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLCalSumCdTk', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pTk'     => $params['pTk'] ?? null,
            'pNam'    => $params['pNam'] ?? date('Y'),
            'pMa_nt'  => $params['pMa_nt'] ?? 'VND',
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
