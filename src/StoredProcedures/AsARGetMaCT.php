<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:04:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARGetMaCT
 * 
 * Stored procedure: asARGetMaCT
 * Purpose: Tìm kiếm mã loại chứng từ được phân bổ cho module công nợ phải thu.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * 
 * Kết quả trả về: Danh sách các loại chứng từ (ma_ct, ten_ct) thuộc các mã: 'CA1', 'CA3', 'AR4', 'AP4'.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 * ];
 * $result = AsARGetMaCT::call($params);
 * ```
 */
class AsARGetMaCT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetMaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
        ], $connection);
    }
}
