<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:50:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMNHHD
 * 
 * Stored procedure: asSIGetDMNHHD
 * Purpose: Lấy danh sách người hóa đơn (danh mục người hóa đơn) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Mặc định ''.
 * - @pMa_nhhd (nvarchar(20)): Mã người hóa đơn cần tìm (có thể '' để lấy tất cả). Mặc định ''.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: '' (empty string).
 * - pMa_nhhd: '' (empty string, lấy tất cả).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các người hóa đơn với các cột: ma_cty, ma_nhhd, ten_nhhd, ksd, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_nhhd' => 'NHHD',
 * ];
 * $result = AsGetDMNHHD::call($params);
 * ```
 */
class AsGetDMNHHD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMNHHD', [
            'pMa_cty'   => $params['pMa_cty'] ?? '',
            'pMa_nhhd'  => $params['pMa_nhhd'] ?? '',
            'pStruct'   => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
