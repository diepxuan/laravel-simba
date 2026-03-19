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
 * Class AsGLRptBCTC02_CheckSL
 *
 * Stored procedure: asGLRptBCTC02_CheckSL
 * Purpose: ========================================================================
 *
 * Tham số:
 * - @pma_cty (nvarchar(3)): Tham số đầu vào.
 * - @pQd_cdkt (nvarchar(10)): Tham số đầu vào.
 * - @pNgay (smalldatetime): Tham số đầu vào.
 * - @pChiTieuCoSoLieu (bit): Tham số đầu vào.
 * - @pMau (nvarchar(10)): Tham số đầu vào.
 * - @pDest (nvarchar(50)): Tham số đầu vào.
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Collection kết quả truy vấn.
 *
 * Example call:
 * ```php
 * $params = [
            'pma_cty' => '',
            'pQd_cdkt' => '',
            'pNgay' => '',
            'pChiTieuCoSoLieu' => '',
            'pMau' => '',
            'pDest' => '',
 * ];
 * $result = AsGLRptBCTC02_CheckSL::call($params);
 * ```
 */
class AsGLRptBCTC02_CheckSL
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTC02_CheckSL', [
            'pma_cty' => $paramObj->pma_cty ?? null,
            'pQd_cdkt' => $paramObj->pQd_cdkt ?? null,
            'pNgay' => $paramObj->pNgay ?? null,
            'pChiTieuCoSoLieu' => $paramObj->pChiTieuCoSoLieu ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pDest' => $paramObj->pDest ?? null,
        ], $connection);
    }
}
