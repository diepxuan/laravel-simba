<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:40:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMHTTT
 * 
 * Stored procedure: asSIGetDMHTTT
 * Purpose: Lấy danh sách hình thức thanh toán (danh mục hình thức thanh toán) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty (có thể null để lấy tất cả). Mặc định null.
 * - @pMa_httt (nvarchar(20)): Mã hình thức thanh toán cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pModuleid (nvarchar(2)): Mã module (ví dụ: 'SI'). Có thể null để lấy tất cả. Mặc định null.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (lấy tất cả công ty).
 * - pMa_httt: null (lấy tất cả hình thức thanh toán).
 * - pModuleid: null (lấy tất cả module).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các hình thức thanh toán với các cột: ma_cty, ma_httt, moduleid, ten_httt, tk, tk_thue_gtgt_mua, tk_thue_gtgt_ban, tk_thue_nk, tk_thue_xk, tk_gtgt_nk_no, tk_gtgt_nk_co, tk_thue_gtgt_xk, tk_thue_ttdb, tk_ck, ksd, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_httt' => 'CK',
 *     'pModuleid' => 'SI',
 * ];
 * $result = AsGetDMHTTT::call($params);
 * ```
 */
class AsGetDMHTTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMHTTT', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pMa_httt'   => $params['pMa_httt'] ?? null,
            'pModuleid'  => $params['pModuleid'] ?? null,
            'pStruct'    => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
