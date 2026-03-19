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
 * Class AsGLRptBCT03_dieuchinh
 *
 * Stored procedure: asGLRptBCT03_dieuchinh
 * Purpose: =============================================
 *
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Mô tả tham số
 * - @pThang1 (INT): Mô tả tham số
 * - @pThang2 (INT): Mô tả tham số
 * - @pNam (INT): Mô tả tham số
 * - @pStt_rec (DECIMAL(18): Mô tả tham số
 * - @pDoanh_so (DECIMAL(19): Mô tả tham số
 * - @pThue (DECIMAL(19): Mô tả tham số
 * - @pRet (INT): Mô tả tham số
 *
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pThang1: null
 * - @pThang2: null
 * - @pNam: null
 * - @pStt_rec: null
 * - @pDoanh_so: null
 * - @pThue: null
 * - @pRet: null
 *
 * Kết quả trả về: Collection kết quả truy vấn.
 *
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pThang1 => '',
 *     @pThang2 => '',
 *     @pNam => '',
 *     @pStt_rec => '',
 *     @pDoanh_so => '',
 *     @pThue => '',
 *     @pRet => '',
 * ];
 * $result = AsGLRptBCT03_dieuchinh::call($params);
 * ```
 */
class AsGLRptBCT03_dieuchinh
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCT03_dieuchinh', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang1' => $paramObj->pThang1 ?? null,
            'pThang2' => $paramObj->pThang2 ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pDoanh_so' => $paramObj->pDoanh_so ?? null,
            'pThue' => $paramObj->pThue ?? null,
            'pRet' => $paramObj->pRet ?? null,
        ], $connection);
    }
}
