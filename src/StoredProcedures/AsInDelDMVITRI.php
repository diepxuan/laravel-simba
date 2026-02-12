<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:41:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelDMVITRI
 * 
 * Stored procedure: asINDelDMVITRI
 * Purpose: Xóa bản ghi trong bảng INDMVITRI (danh mục vị trí) dựa trên mã công ty, mã kho và mã vị trí. Kiểm tra tồn tại trước khi xóa.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_kho (nvarchar(8)): Mã kho. Bắt buộc.
 * - @pMa_vitri (nvarchar(8)): Mã vị trí. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, 50004 nếu đã tồn tại, @@error nếu có lỗi).
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
 *     'pMa_vitri' => 'VTRI01',
 * ];
 * $result = AsInDelDMVITRI::call($params);
 * ```
 */
class AsInDelDMVITRI
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelDMVITRI', [
            'pMa_cty'     => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_kho'     => $params['pMa_kho'] ?? null,
            'pMa_vitri'   => $params['pMa_vitri'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
