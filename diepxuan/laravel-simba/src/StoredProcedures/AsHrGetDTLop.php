<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsHrGetDTLop
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
     * Gọi stored procedure asHrGetDTLop
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asHrGetDTLop', $params);
    }
}