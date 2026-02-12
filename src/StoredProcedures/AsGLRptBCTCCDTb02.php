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

/**
 * Class AsGLRptBCTCCDTb02
 * 
 * Stored procedure: asGLRptBCTCCDTb02
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mô tả tham số
 * - @pTk (nvarchar(20)): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pMa_cty: 'CDT'
 * - @pTk: '441
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pMa_cty => '',
 *     @pTk => '',
 * ];
 * $result = AsGLRptBCTCCDTb02::call($params);
 * ```
 */
class AsGLRptBCTCCDTb02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCDTb02', [
            'pMa_cty' => $params['pMa_cty'] ?? 'CDT',
            'pTk' => $params['pTk'] ?? '441',
        ], $connection);
    }
}
