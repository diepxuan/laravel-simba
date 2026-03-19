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
 * Class AsGLUpdMAUBCTCTMVI02a
 *
 * Stored procedure: asGLUpdMAUBCTCTMVI02a
 * Purpose: No description
 *
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pMau (NVARCHAR(10)): Tham số đầu vào.
 * - @pMa_so (NVARCHAR(10)): Tham số đầu vào.
 * - @pChi_tieu (NVARCHAR(255)): Tham số đầu vào.
 * - @pNd_chtieu (NVARCHAR(MAX)): Tham số đầu vào.
 * - @pCach_tinh (NVARCHAR(50)): Tham số đầu vào.
 * - @pIsPrint (BIT): Tham số đầu vào.
 * - @pIsItalic (BIT): Tham số đầu vào.
 * - @pTk_01 (NVARCHAR(10)): Tham số đầu vào.
 * - @pBold (BIT): Tham số đầu vào.
 * - @pRet (INT OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Không có result set (chỉ thực hiện update).
 *
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMau' => '',
            'pMa_so' => '',
            'pChi_tieu' => '',
            'pNd_chtieu' => '',
            'pCach_tinh' => '',
            'pIsPrint' => '',
            'pIsItalic' => '',
            'pTk_01' => '',
            'pBold' => '',
 * ];
 * $result = AsGLUpdMAUBCTCTMVI02a::call($params);
 * ```
 */
class AsGLUpdMAUBCTCTMVI02a
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI02a', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? null,
            'pIsItalic' => $paramObj->pIsItalic ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pBold' => $paramObj->pBold ?? null,
        ], $connection);
    }
}
