<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:25:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMCT
 * 
 * Stored procedure: asSIGetDMCT
 * Purpose: Lấy danh sách loại chứng từ (danh mục chứng từ) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty (có thể null để lấy tất cả). Mặc định null.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ cần tìm (có thể null để lấy tất cả). Mặc định null.
 * - @pPhan_he (nvarchar(2)): Phân hệ (ví dụ: 'SI'). Mặc định null.
 * - @pLanguage (nvarchar(5)): Ngôn ngữ cho tên chứng từ (ví dụ: 'vi-VN'). Mặc định 'vi-VN'.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (lấy tất cả công ty).
 * - pMa_ct: null (lấy tất cả loại chứng từ).
 * - pPhan_he: null (lấy tất cả phân hệ).
 * - pLanguage: 'vi-VN'.
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Collection các loại chứng từ với nhiều cột, bao gồm ma_cty, ma_ct, phan_he, ma_ct_me, ten_ct, ...
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'SI01',
 *     'pPhan_he' => 'SI',
 * ];
 * $result = AsGetDMCT::call($params);
 * ```
 */
class AsGetDMCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMCT', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_ct'    => $params['pMa_ct'] ?? null,
            'pPhan_he'  => $params['pPhan_he'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? 'vi-VN',
            'pStruct'   => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
