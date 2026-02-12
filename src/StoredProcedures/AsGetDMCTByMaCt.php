<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMCTByMaCt
 * 
 * Stored procedure: asSIGetDMCTByMa_Ct
 * Purpose: Lấy thông tin chi tiết một loại chứng từ theo mã chứng từ cụ thể trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ cần lấy. Bắt buộc.
 * - @pLanguage (nvarchar(5)): Ngôn ngữ cho tên chứng từ (ví dụ: 'vi-VN'). Mặc định 'vi-VN'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (phải cung cấp).
 * - pMa_ct: null (phải cung cấp).
 * - pLanguage: 'vi-VN'.
 * 
 * Kết quả trả về: Collection một dòng chứa thông tin chi tiết của chứng từ.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'SI01',
 * ];
 * $result = AsGetDMCTByMaCt::call($params);
 * ```
 */
class AsGetDMCTByMaCt
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMCTByMa_Ct', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_ct'    => $params['pMa_ct'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? 'vi-VN',
        ], $connection);
    }
}
