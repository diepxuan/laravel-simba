<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLGetCt1
 * 
 * Stored procedure: asGLGetCt1
 * Purpose: Lấy thông tin chi tiết chứng từ GLCT1 (có join các danh mục liên quan).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu. Mặc định: NULL.
 * - @pStruct (nvarchar(1)): Cấu trúc? Mặc định: '0'.
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * - pStruct: '0'.
 * 
 * Kết quả trả về: Result set chứa các trường từ GLCT1 và các danh mục liên quan.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'CT2023001',
 *     'pStruct' => '0',
 * ];
 * $result = AsGLGetCt1::call($params);
 * ```
 */
class AsGLGetCt1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLGetCt1', [
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStruct'  => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
