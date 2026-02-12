<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:06:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelDMHD
 * 
 * Stored procedure: asSIDelDMHD
 * Purpose: Xoá một loại hóa đơn (danh mục hóa đơn) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_hd (nvarchar(20)): Mã hóa đơn cần xoá. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi:
 *     - 0: được xoá thành công.
 *     - 50004: mã hóa đơn đã tồn tại trong các bảng dữ liệu liên quan (không được phép xoá).
 *     - @@error: mã lỗi SQL nếu có lỗi khi thực hiện delete.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_hd: không có mặc định, phải cung cấp.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_hd' => 'HD001',
 * ];
 * $result = AsDelDMHD::call($params);
 * ```
 */
class AsDelDMHD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMHD', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_hd'  => $params['pMa_hd'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
