<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsGLDelDMCTGS
 * 
 * Stored procedure: asGLDelDMCTGS
 * Purpose: Xoá một bản ghi của GLDMCTGS (danh mục chứng từ ghi sổ).
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, 50004 nếu đã tồn tại, @@error nếu có lỗi).
 * 
 * Giá trị mặc định:
 * - pMa_cty: mã công ty mặc định (SModel::CTY).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'GL1',
 * ];
 * $result = AsGLDelDMCTGS::call($params);
 * ```
 */
class AsGLDelDMCTGS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLDelDMCTGS', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
