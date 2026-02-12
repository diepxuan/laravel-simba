<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelDMTGNT
 * 
 * Stored procedure: asSIDelDMTGNT
 * Purpose: Xoá một tiêu thức người thu (danh mục tiêu thức người thu) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã người thu cần xoá tiêu thức. Bắt buộc.
 * - @pNgay_tg (smalldatetime): Ngày tiêu thức. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi:
 *     - 0: được xoá thành công.
 *     - @@error: mã lỗi SQL nếu có lỗi khi thực hiện delete.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_nt: không có mặc định, phải cung cấp.
 * - pNgay_tg: không có mặc định, phải cung cấp (định dạng Y-m-d).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_nt' => 'NT01',
 *     'pNgay_tg' => '2023-12-31',
 * ];
 * $result = AsDelDMTGNT::call($params);
 * ```
 */
class AsDelDMTGNT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelDMTGNT', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_nt'    => $params['pMa_nt'] ?? null,
            'pNgay_tg'  => $params['pNgay_tg'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
