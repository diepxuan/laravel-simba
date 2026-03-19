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
 * Class AsGLRptBCTCTMVI13
 *
 * Stored procedure: asGLRptBCTCTMVI13
 * Purpose: =============================================
 *
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Mô tả tham số
 * - @pMau (NVARCHAR(10)): Mô tả tham số
 * - @pNgay1 (SMALLDATETIME): Mô tả tham số
 * - @pNgay2 (SMALLDATETIME): Mô tả tham số
 *
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pMau: null
 * - @pNgay1: null
 * - @pNgay2: null
 *
 * Kết quả trả về: Collection kết quả truy vấn.
 *
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pMau => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 * ];
 * $result = AsGLRptBCTCTMVI13::call($params);
 * ```
 */
class AsGLRptBCTCTMVI13
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCTMVI13', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
        ], $connection);
    }
}
