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
 * Class AsGLRptBCT04
 *
 * Stored procedure: asGLRptBCT04
 * Purpose: =======================================================
 *
 * Tham số:
 * - @pMa_Cty (nvarchar): Mô tả tham số
 * - @pNgay1 (nvarchar): Mô tả tham số
 * - @pNgay2 (nvarchar): Mô tả tham số
 * - @pMau (nvarchar): Mô tả tham số
 *
 * Giá trị mặc định:
 * - @pMa_Cty: null
 * - @pNgay1: null
 * - @pNgay2: null
 * - @pMau: null
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
 * $result = AsGLRptBCT04::call($params);
 * ```
 */
class AsGLRptBCT04
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCT04', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMau' => $paramObj->pMau ?? null,
        ], $connection);
    }
}
