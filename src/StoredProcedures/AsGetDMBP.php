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
 * Class AsGetDMBP
 * 
 * Stored procedure: asSIGetDMBP
 * Purpose: Lấy danh sách bộ phận (danh mục bộ phận) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_bp (nvarchar(20)): Mã bộ phận cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pMa_bp: null (lấy tất cả bộ phận).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các bộ phận với các cột: ma_cty, ma_bp, ten_bp, ksd, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_bp' => 'BP',
 * ];
 * $result = AsGetDMBP::call($params);
 * ```
 */
class AsGetDMBP
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMBP', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pStruct' => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
