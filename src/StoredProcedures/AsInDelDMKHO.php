<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:36:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelDMKHO
 * 
 * Stored procedure: asINDelDMKHO
 * Purpose: Xóa bản ghi trong bảng INDMKHO (danh mục kho) dựa trên mã công ty và mã kho.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_kho (nvarchar(8)): Mã kho. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_kho' => 'KHO01',
 * ];
 * $result = AsInDelDMKHO::call($params);
 * ```
 */
class AsInDelDMKHO
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelDMKHO', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_kho'   => $params['pMa_kho'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
