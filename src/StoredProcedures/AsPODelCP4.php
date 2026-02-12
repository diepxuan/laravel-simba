<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:36:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPODelCP4
 * 
 * Stored procedure: asPODelCP4
 * Purpose: ================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pStt_rec (nvarchar(20)): Tham số đầu vào.
 * - @pRet (int OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pStt_rec' => '',
 * ];
 * $result = AsPODelCP4::call($params);
 * ```
 */
class AsPODelCP4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPODelCP4', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }
}
