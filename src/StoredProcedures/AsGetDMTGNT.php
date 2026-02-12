<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 14:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGetDMTGNT
 * 
 * Stored procedure: asSIGetDMTGNT
 * Purpose: Lấy danh sách tiêu thức người thu (danh mục tiêu thức người thu) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Mặc định null (có thể null nhưng sẽ không trả về dữ liệu nếu null).
 * 
 * Giá trị mặc định:
 * - pMa_cty: null (nên cung cấp mã công ty cụ thể).
 * 
 * Kết quả trả về: Collection các tiêu thức người thu với các cột: ma_cty, ma_nt, ngay_tg, ty_gia, cdate, cuser, ldate, luser.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 * ];
 * $result = AsGetDMTGNT::call($params);
 * ```
 */
class AsGetDMTGNT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMTGNT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
        ], $connection);
    }
}
