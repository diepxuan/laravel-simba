<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:18:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLDelBudget
 * 
 * Stored procedure: asGLDelBudget
 * Purpose: Xoá một bản ghi của DMBudget (ngân sách).
 * 
 * Tham số:
 * - @pStt_rec (nvarchar(20)): Số tham chiếu. Bắt buộc.
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pStt_rec' => 'BG2023001',
 *     'pMa_cty' => '001',
 * ];
 * $result = AsGLDelBudget::call($params);
 * ```
 */
class AsGLDelBudget
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelBudget', [
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
        ], $connection);
    }
}
