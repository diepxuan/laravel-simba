<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:35:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMHD
 * 
 * Stored procedure: asSIGetDMHD
 * Purpose: Lấy danh sách hóa đơn (danh mục hóa đơn) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty (có thể null để lấy tất cả). Mặc định null.
 * - @pMa_hd (nvarchar(20)): Mã hóa đơn cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (lấy tất cả công ty).
 * - pMa_hd: null (lấy tất cả hóa đơn).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các hóa đơn với các cột: ma_cty, ma_hd, so_hd, ma_nhhd, ten_nhhd, loai, ten_loai, ngay_hd, ngay_hh, ten_hd, ma_kh, ten_kh, noi_dung, ma_nt, tien, tien_nt, ksd, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_hd' => 'HD001',
 * ];
 * $result = AsGetDMHD::call($params);
 * ```
 */
class AsGetDMHD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMHD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_hd'  => $params['pMa_hd'] ?? null,
            'pStruct' => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
