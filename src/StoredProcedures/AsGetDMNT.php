<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:55:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMNT
 * 
 * Stored procedure: asSIGetDMNT
 * Purpose: Lấy danh sách người thu (danh mục người thu) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty (có thể null để lấy tất cả). Mặc định null.
 * - @pMa_nt (nvarchar(3)): Mã người thu cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (lấy tất cả công ty).
 * - pMa_nt: null (lấy tất cả người thu).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các người thu với các cột: ma_cty, ma_nt, ten_nt, ksd, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_nt' => 'NT01',
 * ];
 * $result = AsGetDMNT::call($params);
 * ```
 */
class AsGetDMNT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMNT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
            'pStruct' => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
