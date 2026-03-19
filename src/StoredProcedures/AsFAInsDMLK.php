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
 * Class AsFAInsDMLK
 *
 * Stored procedure: asFAInsDMLK
 * Purpose: ================================================
 *
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pMa_ts (NVARCHAR(20)): Tham số đầu vào.
 * - @pMa_lk (NVARCHAR(20)): Tham số đầu vào.
 * - @pTg (BIT): Tham số đầu vào.
 * - @pTen_lk (NVARCHAR(50)): Tham số đầu vào.
 * - @pDvt (NVARCHAR(50)): Tham số đầu vào.
 * - @pSo_luong (DECIMAL(18): Tham số đầu vào.
 * - @pGia_tri (DECIMAL(18): Tham số đầu vào.
 * - @pGhi_chu (NVARCHAR(255)): Tham số đầu vào.
 * - @pKsd (BIT): Tham số đầu vào.
 * - @pLUser (NVARCHAR(20)): Tham số đầu vào.
 * - @pRet (INT OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 *
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMa_ts' => '',
            'pMa_lk' => '',
            'pTg' => '',
            'pTen_lk' => '',
            'pDvt' => '',
            'pSo_luong' => '',
            'pGia_tri' => '',
            'pGhi_chu' => '',
            'pKsd' => '',
            'pLUser' => '',
 * ];
 * $result = AsFAInsDMLK::call($params);
 * ```
 */
class AsFAInsDMLK
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAInsDMLK', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pMa_lk' => $paramObj->pMa_lk ?? null,
            'pTg' => $paramObj->pTg ?? null,
            'pTen_lk' => $paramObj->pTen_lk ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pGia_tri' => $paramObj->pGia_tri ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
