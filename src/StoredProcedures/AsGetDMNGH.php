<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMNGH
 * 
 * Stored procedure: asSIGetDMNGH
 * Purpose: Lấy danh sách ngành hàng (danh mục ngành hàng) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty (có thể null để lấy tất cả). Mặc định null.
 * - @pMa_ngh (nvarchar(20)): Mã ngành hàng cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (lấy tất cả công ty).
 * - pMa_ngh: null (lấy tất cả ngành hàng).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các ngành hàng với các cột: ma_cty, ma_ngh, ten_ngh, ghi_chu, ksd, ldate, cdate, luser, cuser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ngh' => 'NGH001',
 * ];
 * $result = AsGetDMNGH::call($params);
 * ```
 */
class AsGetDMNGH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMNGH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ngh' => $params['pMa_ngh'] ?? null,
            'pStruct' => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
