<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:25:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInDelCT2
 * 
 * Stored procedure: asINDelCT2
 * Purpose: Xóa bản ghi trong bảng INCT2 (chi tiết phiếu xuất kho?) dựa trên mã công ty và số chứng từ.
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số chứng từ (stt_rec). Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi).
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
 *     'pStt_rec' => 'XK20230001',
 * ];
 * $result = AsInDelCT2::call($params);
 * ```
 */
class AsInDelCT2
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINDelCT2', [
            'pMa_cty'   => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec'  => $params['pStt_rec'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
