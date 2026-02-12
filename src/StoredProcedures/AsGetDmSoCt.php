<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 14:05:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDmSoCt
 * 
 * Stored procedure: asSIGetDmSo_ct
 * Purpose: Lấy danh sách loại chứng từ (danh mục số chứng từ) trong module Sales & Inventory, theo phân hệ và ngôn ngữ.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pPhan_he (nvarchar(2)): Phân hệ (ví dụ: 'SO'). Mặc định 'SO'.
 * - @pStruct (nvarchar(1)): Cấu trúc dữ liệu (0: danh sách). Mặc định '0'.
 * - @pLanguageId (nvarchar(5)): Ngôn ngữ (ví dụ: 'vi-VN'). Bắt buộc.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (phải cung cấp).
 * - pPhan_he: 'SO'.
 * - pStruct: '0'.
 * - pLanguageId: null (phải cung cấp).
 * 
 * Kết quả trả về: Collection các loại chứng từ với các cột: ma_ct, ten_ct.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pPhan_he' => 'SO',
 *     'pLanguageId' => 'vi-VN',
 * ];
 * $result = AsGetDmSoCt::call($params);
 * ```
 */
class AsGetDmSoCt
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDmSo_ct', [
            'pMa_cty'      => $params['pMa_cty'] ?? null,
            'pPhan_he'     => $params['pPhan_he'] ?? 'SO',
            'pStruct'      => $params['pStruct'] ?? '0',
            'pLanguageId'  => $params['pLanguageId'] ?? null,
        ], $connection);
    }
}
