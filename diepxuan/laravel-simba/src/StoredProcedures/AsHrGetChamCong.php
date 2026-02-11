<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsHrGetChamCong
 *
 * Stored procedure: asHrGetChamCong
 * Mục đích: Lấy dữ liệu chấm công nhân viên theo mã công ty, năm, tháng và ID nhân viên (có thể tìm theo prefix).
 * Procedure trả về tất cả các cột từ bảng HrChamCong thỏa mãn điều kiện.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định '001'): Mã công ty (NVARCHAR(3)).
 * - @pNam (int, tùy chọn, mặc định 2014): Năm chấm công (INT). Nếu NULL sẽ lấy năm hiện tại.
 * - @pThang (int, tùy chọn, mặc định 7): Tháng chấm công (INT). Nếu NULL sẽ lấy tháng hiện tại.
 * - @pId (string, tùy chọn, mặc định ''): ID nhân viên (NVARCHAR(20)). Nếu NULL sẽ chuyển thành chuỗi rỗng.
 *   Điều kiện tìm kiếm: Id LIKE @pId + '%' (bắt đầu với @pId).
 * 
 * Giá trị trả về:
 * - Procedure trả về resultset chứa các bản ghi chấm công thỏa mãn điều kiện.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsHrGetChamCong::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pThang' => 2,
 *     'pId' => 'NV',
 * ]);
 * // $result là tập hợp các bản ghi chấm công có Id bắt đầu bằng 'NV'
 * ```
 * 
 * Lưu ý:
 * - Nếu không cung cấp tham số, procedure sẽ sử dụng giá trị mặc định.
 * - Điều kiện tìm kiếm theo prefix, có thể trả về nhiều bản ghi.
 */
class AsHrGetChamCong
{
    /**
     * Gọi stored procedure asHrGetChamCong
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asHrGetChamCong', $params);
    }
}