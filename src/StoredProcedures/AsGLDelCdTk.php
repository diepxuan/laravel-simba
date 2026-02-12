<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:25:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLDelCdTk
 * 
 * Stored procedure: asGLDelCdTk
 * Purpose: Xoá một bản ghi của GLCDTK (số dư tài khoản).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản. Bắt buộc.
 * - @pNam (int): Năm. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pNam: năm hiện tại.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pTk' => '111',
 *     'pNam' => 2023,
 * ];
 * $result = AsGLDelCdTk::call($params);
 * ```
 */
class AsGLDelCdTk
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelCdTk', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pTk'     => $params['pTk'] ?? null,
            'pNam'    => $params['pNam'] ?? (int) date('Y'),
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
