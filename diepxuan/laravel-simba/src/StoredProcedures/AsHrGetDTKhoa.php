<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsHrGetDTKhoa
 *
 * Stored procedure: asHrGetDTKhoa
 * Mục đích: Lấy danh sách khóa đào tạo theo mã công ty và mã khóa đào tạo (có thể tìm theo prefix).
 * Procedure trả về tất cả các cột từ bảng HrDTKhoa thỏa mãn điều kiện.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định '001'): Mã công ty (NVARCHAR(3)).
 * - @pMa_kdt (string, tùy chọn, mặc định ''): Mã khóa đào tạo (NVARCHAR(20)). Nếu NULL chuyển thành chuỗi rỗng.
 *   Điều kiện tìm kiếm: Ma_kdt LIKE @pMa_kdt + '%' (bắt đầu với @pMa_kdt).
 * 
 * Giá trị trả về:
 * - Procedure trả về resultset chứa các bản ghi khóa đào tạo thỏa mãn điều kiện.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsHrGetDTKhoa::call([
 *     'pMa_cty' => '001',
 *     'pMa_kdt' => 'KDT',
 * ]);
 * // $result là tập hợp các bản ghi khóa đào tạo có mã bắt đầu bằng 'KDT'
 * ```
 * 
 * Lưu ý:
 * - Nếu không cung cấp tham số, procedure sẽ sử dụng giá trị mặc định.
 * - Điều kiện tìm kiếm theo prefix, có thể trả về nhiều bản ghi.
 */
class AsHrGetDTKhoa
{
    /**
     * Gọi stored procedure asHrGetDTKhoa
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asHrGetDTKhoa', $params);
    }
}