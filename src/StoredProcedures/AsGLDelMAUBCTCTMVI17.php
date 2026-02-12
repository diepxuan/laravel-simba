<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:40:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLDelMAUBCTCTMVI17
 * 
 * Stored procedure: asGLDelMAUBCTCTMVI17
 * Purpose: Xoá bản ghi trong bảng glmaubctctmVI17 (mẫu báo cáo tài chính) theo mã công ty, mẫu, mã số.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMau (nvarchar(10)): Mẫu báo cáo. Bắt buộc.
 * - @pMa_so (nvarchar(10)): Mã số. Bắt buộc.
 * - @ret (int): Tham số output trả về mã lỗi (@@ERROR).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMau' => 'B01',
 *     'pMa_so' => '100',
 * ];
 * $result = AsGLDelMAUBCTCTMVI17::call($params);
 * ```
 */
class AsGLDelMAUBCTCTMVI17
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelMAUBCTCTMVI17', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau'    => $params['pMau'] ?? null,
            'pMa_so'  => $params['pMa_so'] ?? null,
            // ret là output parameter, không truyền vào.
        ], $connection);
    }
}
