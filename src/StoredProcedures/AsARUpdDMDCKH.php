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
 * Class AsARUpdDMDCKH
 *
 * Stored procedure: asARUpdDMDCKH
 * Purpose: ================================================================================================
 *
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pMa_kh (nvarchar(20)): Tham số đầu vào.
 * - @pMa_dckh (nvarchar(1)): Tham số đầu vào.
 * - @pTen_kh (nvarchar(100)): Tham số đầu vào.
 * - @pDia_chi (nvarchar(255)): Tham số đầu vào.
 * - @pTel (nvarchar(30)): Tham số đầu vào.
 * - @pFax (nvarchar(30)): Tham số đầu vào.
 * - @pNguoi_gd (nvarchar(30)): Tham số đầu vào.
 * - @pKsd (bit): Tham số đầu vào.
 * - @pDc_md (bit): Tham số đầu vào.
 * - @pLUser (nvarchar(20)): Tham số đầu vào.
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
            'pMa_kh' => '',
            'pMa_dckh' => '',
            'pTen_kh' => '',
            'pDia_chi' => '',
            'pTel' => '',
            'pFax' => '',
            'pNguoi_gd' => '',
            'pKsd' => '',
            'pDc_md' => '',
            'pLUser' => '',
 * ];
 * $result = AsARUpdDMDCKH::call($params);
 * ```
 */
class AsARUpdDMDCKH
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdDMDCKH', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_dckh' => $paramObj->pMa_dckh ?? null,
            'pTen_kh' => $paramObj->pTen_kh ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pTel' => $paramObj->pTel ?? null,
            'pFax' => $paramObj->pFax ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pDc_md' => $paramObj->pDc_md ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
