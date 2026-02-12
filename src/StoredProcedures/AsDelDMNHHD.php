<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:10:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelDMNHHD
 * 
 * Stored procedure: asSIDelDMNHHD
 * Purpose: Xoá một người hóa đơn (danh mục người hóa đơn) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_nhhd (nvarchar(8)): Mã người hóa đơn cần xoá. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi:
 *     - 0: được xoá thành công.
 *     - 50004: mã người hóa đơn đã tồn tại trong các bảng dữ liệu liên quan (không được phép xoá).
 *     - @@error: mã lỗi SQL nếu có lỗi khi thực hiện delete.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_nhhd: không có mặc định, phải cung cấp.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_nhhd' => 'NHHD001',
 * ];
 * $result = AsDelDMNHHD::call($params);
 * ```
 */
class AsDelDMNHHD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMNHHD', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_nhhd'  => $params['pMa_nhhd'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
