<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:58:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMPHI
 * 
 * Stored procedure: asSIGetDMPHI
 * Purpose: Lấy danh sách phí (danh mục phí) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty (có thể null để lấy tất cả). Mặc định null.
 * - @pMa_phi (nvarchar(20)): Mã phí cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (lấy tất cả công ty).
 * - pMa_phi: null (lấy tất cả phí).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các phí với các cột: ma_cty, ma_phi, ten_phi, ksd, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_phi' => 'PHI001',
 * ];
 * $result = AsGetDMPHI::call($params);
 * ```
 */
class AsGetDMPHI
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMPHI', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pStruct' => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
