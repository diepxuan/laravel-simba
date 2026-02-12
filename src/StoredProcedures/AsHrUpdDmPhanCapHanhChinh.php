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

/**
 * Class AsHrUpdDmPhanCapHanhChinh
 * 
 * Stored procedure: asHrUpdDmPhanCapHanhChinh
 * Purpose: =============================================
 * 
 * Tham số:
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pMa_pchc (NVARCHAR(20)): Tham số đầu vào.
 * - @pTen_pchc (NVARCHAR(100)): Tham số đầu vào.
 * - @pCap (INT): Tham số đầu vào.
 * - @pParent (NVARCHAR(20)): Tham số đầu vào.
 * - @pStt (NVARCHAR(20)): Tham số đầu vào.
 * - @pKsd (BIT): Tham số đầu vào.
 * - @pLuser (NVARCHAR(20)): Tham số đầu vào.
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
            'pMa_pchc' => '',
            'pTen_pchc' => '',
            'pCap' => '',
            'pParent' => '',
            'pStt' => '',
            'pKsd' => '',
            'pLuser' => '',
 * ];
 * $result = AsHrUpdDmPhanCapHanhChinh::call($params);
 * ```
 */
class AsHrUpdDmPhanCapHanhChinh
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmPhanCapHanhChinh', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_pchc' => $params['pMa_pchc'] ?? null,
            'pTen_pchc' => $params['pTen_pchc'] ?? null,
            'pCap' => $params['pCap'] ?? null,
            'pParent' => $params['pParent'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
        ], $connection);
    }
}
