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
 * Class AsGLRptBCTC02
 * 
 * Stored procedure: asGLRptBCTC02
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pma_cty (nvarchar(3)): Mô tả tham số
 * - @pQd_cdkt (nvarchar(10)): Mô tả tham số
 * - @pNgay (smalldatetime): Mô tả tham số
 * - @pChiTieuCoSoLieu (bit): Mô tả tham số
 * - @pMau (nvarchar(10)): Mô tả tham số
 * - @pDest (nvarchar(50)): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pma_cty: '111'
 * - @pQd_cdkt: '200'
 * - @pNgay: '20151231'
 * - @pChiTieuCoSoLieu: 0
 * - @pMau: '01'
 * - @pDest: ''
 * 
 * Kết quả trả về: Collection kết quả truy vấn.
 * 
 * Example call:
 * ```php
 * $params = [
 *     @pma_cty => '',
 *     @pQd_cdkt => '',
 *     @pNgay => '',
 *     @pChiTieuCoSoLieu => '',
 *     @pMau => '',
 *     @pDest => '',
 * ];
 * $result = AsGLRptBCTC02::call($params);
 * ```
 */
class AsGLRptBCTC02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTC02', [
            'pma_cty' => $params['pma_cty'] ?? '111',
            'pQd_cdkt' => $params['pQd_cdkt'] ?? '200',
            'pNgay' => $params['pNgay'] ?? '20151231',
            'pChiTieuCoSoLieu' => $params['pChiTieuCoSoLieu'] ?? 0,
            'pMau' => $params['pMau'] ?? '01',
            'pDest' => $params['pDest'] ?? '',
        ], $connection);
    }
}
