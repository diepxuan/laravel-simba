<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:12:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelDMNT
 * 
 * Stored procedure: asSIDelDMNT
 * Purpose: Xoá một người thu (danh mục người thu) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã người thu cần xoá. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi:
 *     - 0: được xoá thành công.
 *     - 50004: mã người thu đã tồn tại trong các bảng dữ liệu liên quan (không được phép xoá).
 *     - @@error: mã lỗi SQL nếu có lỗi khi thực hiện delete.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_nt: không có mặc định, phải cung cấp.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_nt' => 'NT01',
 * ];
 * $result = AsDelDMNT::call($params);
 * ```
 */
class AsDelDMNT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMNT', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
