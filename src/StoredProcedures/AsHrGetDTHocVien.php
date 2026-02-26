<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:04:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsHrGetDTHocVien.
 *
 * Stored procedure: asHrGetDTHocVien
 * Mục đích: Lấy danh sách nhân viên tham gia lớp đào tạo (học viên) theo mã công ty, mã khóa đào tạo, mã lớp đào tạo và ID nhân viên (có thể tìm theo prefix).
 * Procedure trả về tất cả các cột từ bảng HrDTHocVien thỏa mãn điều kiện.
 *
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định '001'): Mã công ty (NVARCHAR(3)).
 * - @pMa_kdt (string, tùy chọn, mặc định ''): Mã khóa đào tạo (NVARCHAR(20)). Nếu NULL chuyển thành chuỗi rỗng.
 * - @pMa_ldt (string, tùy chọn, mặc định ''): Mã lớp đào tạo (NVARCHAR(20)). Nếu NULL chuyển thành chuỗi rỗng.
 * - @pId (string, tùy chọn, mặc định ''): ID nhân viên (NVARCHAR(20)). Nếu NULL chuyển thành chuỗi rỗng.
 *   Điều kiện tìm kiếm: Id LIKE @pId + '%' (bắt đầu với @pId).
 *
 * Giá trị trả về:
 * - Procedure trả về resultset chứa các bản ghi học viên thỏa mãn điều kiện.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsHrGetDTHocVien::call([
 *     'pMa_cty' => '001',
 *     'pMa_kdt' => 'KDT001',
 *     'pMa_ldt' => 'LDT001',
 *     'pId' => 'NV',
 * ]);
 * // $result là tập hợp các bản ghi học viên có Id bắt đầu bằng 'NV'
 * ```
 *
 * Lưu ý:
 * - Nếu không cung cấp tham số, procedure sẽ sử dụng giá trị mặc định.
 * - Điều kiện tìm kiếm theo prefix, có thể trả về nhiều bản ghi.
 */
class AsHrGetDTHocVien
{
    /**
     * Gọi stored procedure asHrGetDTHocVien.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDTHocVien', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pMa_ldt' => $params['pMa_ldt'] ?? null,
            'pId'     => $params['pId'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDTHocVien with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_kdt = null, ?string $Ma_ldt = null, ?string $Id = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pMa_ldt' => $Ma_ldt,
            'pId'     => $Id,
        ];

        return self::call($params);
    }
}
