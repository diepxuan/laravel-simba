<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelCDVT
 * 
 * Stored procedure: asINDelCDVT
 * Purpose: Xóa bản ghi trong bảng INCDVT (tồn kho chi tiết) dựa trên các khóa chính.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNam (int): Năm tài chính. Bắt buộc.
 * - @pMa_vt (nvarchar(20)): Mã vật tư. Bắt buộc.
 * - @pMa_kho (nvarchar(8)): Mã kho. Bắt buộc.
 * - @pMa_vitri (nvarchar(8)): Mã vị trí. Bắt buộc.
 * - @pMa_lo (nvarchar(20)): Mã lô. Bắt buộc.
 * - @pTk_vt (nvarchar(20)): Tài khoản vật tư. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã người thu. Bắt buộc.
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
 *     'pNam' => 2023,
 *     'pMa_vt' => 'VT001',
 *     'pMa_kho' => 'KHO01',
 *     'pMa_vitri' => 'VTRI01',
 *     'pMa_lo' => 'LO001',
 *     'pTk_vt' => '1561',
 *     'pMa_nt' => 'USD',
 * ];
 * $result = AsInDelCDVT::call($params);
 * ```
 */
class AsInDelCDVT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelCDVT', [
            'pMa_cty'    => $params['pMa_cty'] ?? SModel::CTY,
            'pNam'       => $params['pNam'] ?? null,
            'pMa_vt'     => $params['pMa_vt'] ?? null,
            'pMa_kho'    => $params['pMa_kho'] ?? null,
            'pMa_vitri'  => $params['pMa_vitri'] ?? null,
            'pMa_lo'     => $params['pMa_lo'] ?? null,
            'pTk_vt'     => $params['pTk_vt'] ?? null,
            'pMa_nt'     => $params['pMa_nt'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
