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
 * Class AsGLRptBCTCCR02
 * 
 * Stored procedure: asGLRptBCTCCR02
 * Purpose: =======================================================
 * 
 * Tham số:
 * - @pma_cty (nvarchar(3)): Mô tả tham số
 * - @pNam (int): Mô tả tham số
 * - @pNgay (smalldatetime): Mô tả tham số
 * - @pChiTieuCoSoLieu (bit): Mô tả tham số
 * - @pMau (nvarchar(10)): Mô tả tham số
 * - @pDest (nvarchar(50)): Mô tả tham số
 * 
 * Giá trị mặc định:
 * - @pma_cty: 'CR' 
 * - @pNam: 2013
 * - @pNgay: '08/23/2013'
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
 *     @pNam => '',
 *     @pNgay => '',
 *     @pChiTieuCoSoLieu => '',
 *     @pMau => '',
 *     @pDest => '',
 * ];
 * $result = AsGLRptBCTCCR02::call($params);
 * ```
 */
class AsGLRptBCTCCR02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCTCCR02', [
            'pma_cty' => $params['pma_cty'] ?? ''CR' ',
            'pNam' => $params['pNam'] ?? 2013,
            'pNgay' => $params['pNgay'] ?? '08/23/2013',
            'pChiTieuCoSoLieu' => $params['pChiTieuCoSoLieu'] ?? 0,
            'pMau' => $params['pMau'] ?? '01',
            'pDest' => $params['pDest'] ?? '',
        ], $connection);
    }
}
