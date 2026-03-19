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
use Diepxuan\Simba\Helper\ParamHelper;
/**
 * Class AsFAGetKHTS
 *
 * Stored procedure: asFAGetKHTS
 * Purpose: ----------------------------------------------------------------*/
 *
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pNam (INT): Tham số đầu vào.
 * - @pThang (INT): Tham số đầu vào.
 * - @pMa_ts (NVARCHAR(20)): Tham số đầu vào.
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Collection kết quả truy vấn.
 *
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pNam' => '',
            'pThang' => '',
            'pMa_ts' => '',
 * ];
 * $result = AsFAGetKHTS::call($params);
 * ```
 */
class AsFAGetKHTS
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAGetKHTS', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
        ], $connection);
    }
}
