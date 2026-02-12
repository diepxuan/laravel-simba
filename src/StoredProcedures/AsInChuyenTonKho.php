<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInChuyenTonKho
 * 
 * Stored procedure: asINChuyenTonKho
 * Purpose: Chuyển tồn kho sang năm sau. Xóa dữ liệu tồn kho của năm tiếp theo và chèn dữ liệu tồn kho cuối năm trước.
 * 
 * Tham số:
 * - @pma_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pngay_cnt (smalldatetime): Ngày cuối năm trước (ngày kết thúc năm tài chính trước). Bắt buộc.
 * - @pma_kho (nvarchar(8)): Mã kho (có thể để rỗng để áp dụng cho tất cả kho). Mặc định: ''.
 * - @pRet (int output): Tham số output trả về mã lỗi (0 nếu thành công, @@error nếu có lỗi, 50012 nếu ngày đầu năm mới nhỏ hơn ngày khóa sổ).
 * 
 * Giá trị mặc định:
 * - pma_cty: mã công ty mặc định (SModel::CTY).
 * - pma_kho: '' (rỗng).
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete và insert).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pma_cty' => '001',
 *     'pngay_cnt' => '2023-12-31',
 *     'pma_kho' => 'KHO01',
 * ];
 * $result = AsInChuyenTonKho::call($params);
 * ```
 */
class AsInChuyenTonKho
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINChuyenTonKho', [
            'pma_cty'   => $params['pma_cty'] ?? SModel::CTY,
            'pngay_cnt' => $params['pngay_cnt'] ?? null,
            'pma_kho'   => $params['pma_kho'] ?? '',
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
