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
 * Class AsARUpdTT_SoDuSo5
 * 
 * Stored procedure: asARUpdTT_SoDuSo5
 * Purpose: AsiaSoft, Sep 22 2009 10:16AM
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pStt_rec_hd (nvarchar(20)): Tham số đầu vào.
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện update).
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pStt_rec_hd' => '',
 * ];
 * $result = AsARUpdTT_SoDuSo5::call($params);
 * ```
 */
class AsARUpdTT_SoDuSo5
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdTT_SoDuSo5', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
        ], $connection);
    }
}
