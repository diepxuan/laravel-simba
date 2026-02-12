<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:38:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelDMNHVAT
 * 
 * Stored procedure: asINDelDMNHVAT
 * Purpose: Xóa bản ghi trong bảng INDMNHVAT (danh mục nhóm vật tư) dựa trên mã công ty và mã nhóm vật tư. Kiểm tra tồn tại trước khi xóa.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_nhvat (nvarchar(8)): Mã nhóm vật tư. Bắt buộc.
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
 *     'pMa_nhvat' => 'NHVAT01',
 * ];
 * $result = AsInDelDMNHVAT::call($params);
 * ```
 */
class AsInDelDMNHVAT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelDMNHVAT', [
            'pMa_cty'     => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_nhvat'   => $params['pMa_nhvat'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
