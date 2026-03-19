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
 * Class AsFaUpdBHCC
 *
 * Stored procedure: asFaUpdBHCC
 * Purpose: ========================================================
 *
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pMa_cc (nvarchar(20)): Tham số đầu vào.
 * - @pSo_luong (decimal): Tham số đầu vào.
 * - @pNgay_giam (smalldatetime): Tham số đầu vào.
 * - @pUser (nvarchar(20)): Tham số đầu vào.
 * - @pID (int): Tham số đầu vào.
 * - @ptk_cp (nvarchar(20)): Tham số đầu vào.
 * - @pMa_bpsd (nvarchar(8)): Tham số đầu vào.
 * - @pGt_da_Kh (decimal(19): Tham số đầu vào.
 * - @pRet (int OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Không có result set (chỉ thực hiện update).
 *
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMa_cc' => '',
            'pSo_luong' => '',
            'pNgay_giam' => '',
            'pUser' => '',
            'pID' => '',
            'ptk_cp' => '',
            'pMa_bpsd' => '',
            'pGt_da_Kh' => '',
 * ];
 * $result = AsFaUpdBHCC::call($params);
 * ```
 */
class AsFaUpdBHCC
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdBHCC', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_cc' => $paramObj->pMa_cc ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pNgay_giam' => $paramObj->pNgay_giam ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pID' => $paramObj->pID ?? null,
            'ptk_cp' => $paramObj->ptk_cp ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pGt_da_Kh' => $paramObj->pGt_da_Kh ?? null,
        ], $connection);
    }
}
