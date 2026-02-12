<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:40:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCODelDMCoBomPH
 * 
 * Stored procedure: asCODelDMCoBomPH
 * Purpose: Xoá định mức nguyên vật liệu
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Mã công ty
 * - @pMa_spct (NVARCHAR(20)): Mã sản phẩm chi tiết
 * - @pRet (INT OUTPUT): 0: được xoá, 1 - không xoá (tham số output, không được xử lý bởi ProcedureCaller hiện tại)
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => 'A07',
 *     'pMa_spct' => '',
 * ];
 * $result = AsCODelDMCoBomPH::call($params);
 * ```
 */
class AsCODelDMCoBomPH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCODelDMCoBomPH', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
