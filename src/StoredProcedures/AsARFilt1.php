<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:18:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsARFilt1
 * 
 * Stored procedure: asARFilt1
 * Purpose: Lọc danh sách phiếu thu/chi và chi tiết theo điều kiện.
 * 
 * Tham số:
 * - @pKeyPh (nvarchar(1000)): Điều kiện lọc trên bảng ARPH1 (phiếu). 
 *   Ví dụ: "ma_kh = 'KH001' AND ngay_ct >= '2023-01-01'"
 * - @pKeyCt (nvarchar(1000)): Điều kiện lọc trên bảng ARCT1 (chi tiết).
 *   Ví dụ: "tk LIKE '131%'"
 * 
 * Giá trị mặc định: Không có (bắt buộc nhập).
 * 
 * Kết quả trả về: Hai result sets.
 * - Result set 1: Danh sách phiếu (ARPH1) kèm thông tin khách hàng, tài khoản nợ.
 * - Result set 2: Danh sách chi tiết (ARCT1) kèm thông tin tài khoản, lo, bộ phận, hợp đồng, phí, sản phẩm.
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pKeyPh' => "ma_kh = 'KH001'",
 *     'pKeyCt' => "tk LIKE '131%'",
 * ];
 * $result = AsARFilt1::call($params);
 * ```
 */
class AsARFilt1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARFilt1', [
            'pKeyPh' => $params['pKeyPh'] ?? null,
            'pKeyCt' => $params['pKeyCt'] ?? null,
        ], $connection);
    }
}
