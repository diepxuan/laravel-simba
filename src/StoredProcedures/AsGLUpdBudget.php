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
 * Class AsGLUpdBudget
 *
 * Stored procedure: asGLUpdBudget
 * Purpose: ========================================================
 *
 * Tham số:
 * - @pStt_rec (NVARCHAR(20)): Tham số đầu vào.
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pNam (int): Tham số đầu vào.
 * - @pTk (nvarchar(20)): Tham số đầu vào.
 * - @pTk_du (nvarchar(20)): Tham số đầu vào.
 * - @pTtps_no_co (NVARCHAR(10)): Tham số đầu vào.
 * - @pMa_bp (nvarchar(20)): Tham số đầu vào.
 * - @pMa_phi (nvarchar(20)): Tham số đầu vào.
 * - @pMa_spct (nvarchar(20)): Tham số đầu vào.
 * - @pUser (nvarchar(20)): Tham số đầu vào.
 * - @pT1 (decimal(19): Tham số đầu vào.
 * - @pT2 (decimal(19): Tham số đầu vào.
 * - @pT3 (decimal(19): Tham số đầu vào.
 * - @pT4 (decimal(19): Tham số đầu vào.
 * - @pT5 (decimal(19): Tham số đầu vào.
 * - @pT6 (decimal(19): Tham số đầu vào.
 * - @pT7 (decimal(19): Tham số đầu vào.
 * - @pT8 (decimal(19): Tham số đầu vào.
 * - @pT9 (decimal(19): Tham số đầu vào.
 * - @pT10 (decimal(19): Tham số đầu vào.
 * - @pT11 (decimal(19): Tham số đầu vào.
 * - @pT12 (decimal(19): Tham số đầu vào.
 * - @pRet (INT OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Không có result set (chỉ thực hiện update).
 *
 * Example call:
 * ```php
 * $params = [
            'pStt_rec' => '',
            'pMa_cty' => '',
            'pNam' => '',
            'pTk' => '',
            'pTk_du' => '',
            'pTtps_no_co' => '',
            'pMa_bp' => '',
            'pMa_phi' => '',
            'pMa_spct' => '',
            'pUser' => '',
            'pT1' => '',
            'pT2' => '',
            'pT3' => '',
            'pT4' => '',
            'pT5' => '',
            'pT6' => '',
            'pT7' => '',
            'pT8' => '',
            'pT9' => '',
            'pT10' => '',
            'pT11' => '',
            'pT12' => '',
 * ];
 * $result = AsGLUpdBudget::call($params);
 * ```
 */
class AsGLUpdBudget
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdBudget', [
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pTtps_no_co' => $paramObj->pTtps_no_co ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pT1' => $paramObj->pT1 ?? null,
            'pT2' => $paramObj->pT2 ?? null,
            'pT3' => $paramObj->pT3 ?? null,
            'pT4' => $paramObj->pT4 ?? null,
            'pT5' => $paramObj->pT5 ?? null,
            'pT6' => $paramObj->pT6 ?? null,
            'pT7' => $paramObj->pT7 ?? null,
            'pT8' => $paramObj->pT8 ?? null,
            'pT9' => $paramObj->pT9 ?? null,
            'pT10' => $paramObj->pT10 ?? null,
            'pT11' => $paramObj->pT11 ?? null,
            'pT12' => $paramObj->pT12 ?? null,
        ], $connection);
    }
}
