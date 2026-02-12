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
 * Class AsInsRightgroupCompany
 * 
 * Stored procedure: asInsRightgroupCompany
 * Purpose: =============================================
 * 
 * Tham số:
 * - @pGroupName (NVARCHAR(20)): Tham số đầu vào.
 * - @pMa_cty (NVARCHAR(3)): Tham số đầu vào.
 * - @pActive (NVARCHAR(1)): Tham số đầu vào.
 * - @pRet (INT OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 * 
 * Example call:
 * ```php
 * $params = [
            'pGroupName' => '',
            'pMa_cty' => '',
            'pActive' => '',
 * ];
 * $result = AsInsRightgroupCompany::call($params);
 * ```
 */
class AsInsRightgroupCompany
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsRightgroupCompany', [
            'pGroupName' => $params['pGroupName'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pActive' => $params['pActive'] ?? null,
        ], $connection);
    }
}
