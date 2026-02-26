<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:05:26
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsHrGetDTLop.
 *
 * Stored procedure: asHrGetDTLop
 * Mục đích: Lấy danh sách lớp đào tạo theo mã công ty, mã khóa đào tạo và mã lớp đào tạo (có thể tìm theo prefix).
 * Procedure trả về tất cả các cột từ bảng HrDTLop thỏa mãn điều kiện.
 *
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định '001'): Mã công ty (NVARCHAR(3)).
 * - @pMa_kdt (string, tùy chọn, mặc định ''): Mã khóa đào tạo (NVARCHAR(20)). Nếu NULL chuyển thành chuỗi rỗng.
 *   Điều kiện tìm kiếm: Ma_kdt LIKE @pMa_kdt + '%' (bắt đầu với @pMa_kdt).
 * - @pMa_ldt (string, tùy chọn, mặc định ''): Mã lớp đào tạo (NVARCHAR(20)). Nếu NULL chuyển thành chuỗi rỗng.
 *   Điều kiện tìm kiếm: Ma_ldt LIKE @pMa_ldt + '%' (bắt đầu với @pMa_ldt).
 *
 * Giá trị trả về:
 * - Procedure trả về resultset chứa các bản ghi lớp đào tạo thỏa mãn điều kiện.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsHrGetDTLop::call([
 *     'pMa_cty' => '001',
 *     'pMa_kdt' => 'KDT',
 *     'pMa_ldt' => 'LDT',
 * ]);
 * // $result là tập hợp các bản ghi lớp đào tạo có mã khóa đào tạo bắt đầu bằng 'KDT' và mã lớp đào tạo bắt đầu bằng 'LDT'
 * ```
 *
 * Lưu ý:
 * - Nếu không cung cấp tham số, procedure sẽ sử dụng giá trị mặc định.
 * - Điều kiện tìm kiếm theo prefix, có thể trả về nhiều bản ghi.
 */
class AsHrGetDTLop
{
    /**
     * Gọi stored procedure asHrGetDTLop.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDTLop', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pMa_ldt' => $params['pMa_ldt'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDTLop with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_kdt = null, ?string $Ma_ldt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pMa_ldt' => $Ma_ldt,
        ];

        return self::call($params);
    }
}
