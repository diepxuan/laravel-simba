<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:48:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLCopyMauBs
 * 
 * Stored procedure: asGLCopyMauBs
 * Purpose: Copy cách tính giữa 2 công ty (từ công ty nguồn sang công ty đích).
 * 
 * Tham số:
 * - @pMa_cty1 (nvarchar(3)): Mã công ty đích (nơi copy đến). Bắt buộc.
 * - @pMa_cty2 (nvarchar(3)): Mã công ty nguồn (nơi copy từ). Bắt buộc.
 * - @pMau (nvarchar(10)): Mã mẫu báo cáo. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty1: mã công ty mặc định (SModel::CTY).
 * - pMa_cty2: null (phải cung cấp).
 * - pMau: null (phải cung cấp).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện copy).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty1' => '001',
 *     'pMa_cty2' => '002',
 *     'pMau' => 'B01',
 * ];
 * $result = AsGLCopyMauBs::call($params);
 * ```
 */
class AsGLCopyMauBs
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLCopyMauBs', [
            'pMa_cty1' => $params['pMa_cty1'] ?? SModel::CTY,
            'pMa_cty2' => $params['pMa_cty2'] ?? null,
            'pMau'     => $params['pMau'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
