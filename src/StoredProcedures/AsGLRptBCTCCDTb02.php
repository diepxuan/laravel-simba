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
 * Class AsGLRptBCTCCDTb02
 *
 * Stored procedure: asGLRptBCTCCDTb02
 * Purpose: =======================================================
 *
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty.
 * - @Ngay_ct1 (smalldatetime): Từ ngày. Default '2010-01-01'.
 * - @Ngay_ct2 (smalldatetime): Đến ngày. Default '2010-10-31'.
 * - @pTk (nvarchar(20)): Tài khoản. Default '441'.
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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCDTb02', [
            'pMa_cty' => $paramObj->pMa_cty ?? 'CDT',
            'Ngay_ct1' => $paramObj->Ngay_ct1 ?? '2010-01-01',
            'Ngay_ct2' => $paramObj->Ngay_ct2 ?? '2010-10-31',
            'pTk' => $paramObj->pTk ?? '441',
        ], $connection);
    }
}
