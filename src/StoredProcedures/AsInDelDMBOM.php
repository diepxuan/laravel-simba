<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:33:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelDMBOM
 * 
 * Stored procedure: asINDelDMBOM
 * Purpose: Xóa bản ghi trong bảng INDMBOM (danh mục BOM - Bill of Materials) dựa trên mã công ty, mã vật tư và mã liên kết.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_vt (nvarchar(20)): Mã vật tư. Bắt buộc.
 * - @pMa_lk (nvarchar(20)): Mã liên kết (vật tư thành phần). Bắt buộc.
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
 *     'pMa_vt' => 'VT001',
 *     'pMa_lk' => 'VT002',
 * ];
 * $result = AsInDelDMBOM::call($params);
 * ```
 */
class AsInDelDMBOM
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelDMBOM', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_vt'    => $params['pMa_vt'] ?? null,
            'pMa_lk'    => $params['pMa_lk'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
