<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:08:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelDMHTTT
 * 
 * Stored procedure: asSIDelDMHTTT
 * Purpose: Xoá một hình thức thanh toán (danh mục hình thức thanh toán) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_httt (nvarchar(20)): Mã hình thức thanh toán cần xoá. Bắt buộc.
 * - @pModuleid (nvarchar(2)): Mã module (ví dụ: 'SI'). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi:
 *     - 0: được xoá thành công.
 *     - 50004: mã hình thức thanh toán đã tồn tại trong các bảng dữ liệu liên quan (không được phép xoá).
 *     - @@error: mã lỗi SQL nếu có lỗi khi thực hiện delete.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_httt: không có mặc định, phải cung cấp.
 * - pModuleid: không có mặc định, phải cung cấp (thường là 'SI').
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_httt' => 'CK',
 *     'pModuleid' => 'SI',
 * ];
 * $result = AsDelDMHTTT::call($params);
 * ```
 */
class AsDelDMHTTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMHTTT', [
            'pMa_cty'    => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_httt'   => $params['pMa_httt'] ?? null,
            'pModuleid'  => $params['pModuleid'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
