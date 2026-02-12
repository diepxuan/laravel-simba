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
 * Class AsApGetPH4
 * 
 * Stored procedure: asApGetPH4
 * Purpose: ================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pStt_rec (nvarchar(20)): Tham số đầu vào.
 * - @pMa_ct (nvarchar(3)): Tham số đầu vào.
 * - @pStruct (nvarchar(1)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pStt_rec' => '',
            'pMa_ct' => '',
            'pStruct' => '',
 * ];
 * $result = AsApGetPH4::call($params);
 * ```
 */
class AsApGetPH4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asApGetPH4', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
        ], $connection);
    }
}
