<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelCt3
 * 
 * Stored procedure: asINDelCt3
 * Purpose: Xóa bản ghi trong bảng InCt3 dựa trên mã công ty và số chứng từ.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số chứng từ (stt_rec). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, 1 nếu không xóa được).
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
 *     'pStt_rec' => 'CT3001',
 * ];
 * $result = AsInDelCt3::call($params);
 * ```
 */
class AsInDelCt3
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelCt3', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
