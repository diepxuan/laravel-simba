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
 * Class AsGLRptBCTCCDTf03B
 *
 * Stored procedure: asGLRptBCTCCDTf03B
 * Purpose: ================================================================================
 *
 * Tham số:
 * - @pMa_cty (nvarchar): Mô tả tham số
 * - @pNgay1 (nvarchar): Mô tả tham số
 * - @pNgay2 (nvarchar): Mô tả tham số
 * - @pTk_xl (nvarchar): Mô tả tham số
 * - @pTk_tb (nvarchar): Mô tả tham số
 * - @pTk_bt (nvarchar): Mô tả tham số
 * - @pTk_ql (nvarchar): Mô tả tham số
 * - @pTk_tv (nvarchar): Mô tả tham số
 * - @pTk_khac (nvarchar): Mô tả tham số
 * - @pMa_spct (nvarchar): Mô tả tham số
 *
 * Giá trị mặc định:
 * - @pMa_cty: null
 * - @pNgay1: null
 * - @pNgay2: null
 * - @pTk_xl: null
 * - @pTk_tb: null
 * - @pTk_bt: null
 * - @pTk_ql: null
 * - @pTk_tv: null
 * - @pTk_khac: null
 * - @pMa_spct: null
 *
 * Kết quả trả về: Collection kết quả truy vấn.
 *
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pNgay1 => '',
 *     @pNgay2 => '',
 *     @pTk_xl => '',
 *     @pTk_tb => '',
 *     @pTk_bt => '',
 *     @pTk_ql => '',
 *     @pTk_tv => '',
 *     @pTk_khac => '',
 *     @pMa_spct => '',
 * ];
 * $result = AsGLRptBCTCCDTf03B::call($params);
 * ```
 */
class AsGLRptBCTCCDTf03B
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCDTf03B', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pTk_xl' => $paramObj->pTk_xl ?? null,
            'pTk_tb' => $paramObj->pTk_tb ?? null,
            'pTk_bt' => $paramObj->pTk_bt ?? null,
            'pTk_ql' => $paramObj->pTk_ql ?? null,
            'pTk_tv' => $paramObj->pTk_tv ?? null,
            'pTk_khac' => $paramObj->pTk_khac ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
        ], $connection);
    }
}
