<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;
/**
 * Class AsGLRptBCT05
 *
 * Stored procedure: asGLRptBCT05
 * Purpose: =======================================================
 *
 * Tham số:
 * - @pMa_Cty (NVARCHAR(3)): Mô tả tham số
 * - @pNgay1 (SMALLDATETIME): Mô tả tham số
 * - @pNgay2 (SMALLDATETIME): Mô tả tham số
 * - @pMau (CHAR(3)): Mô tả tham số
 *
 * Giá trị mặc định:
 * - @pMa_Cty: null
 * - @pNgay1: null
 * - @pNgay2: null
 * - @pMau: '01'
 *
 * Kết quả trả về: Collection kết quả truy vấn.
 *
 * Example call:
 * ```php
 * $params = [
 *     @pMa_Cty => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 *     @pMau => '',
 * ];
 * $result = AsGLRptBCT05::call($params);
 * ```
 */
class AsGLRptBCT05
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCT05', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMau' => $paramObj->pMau ?? '01',
        ], $connection);
    }
}
