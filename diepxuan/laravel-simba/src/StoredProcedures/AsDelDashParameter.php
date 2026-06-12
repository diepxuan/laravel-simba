<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelDashParameter
 *
 * Stored procedure: asDelDashParameter
 * Mục đích: Xóa danh sách tham số của Dashlet (dashboard widget) theo dashid và username.
 * Procedure thực hiện DELETE từ bảng sysDashParameter với điều kiện khớp dashid và username.
 * 
 * Tham số:
 * - @pDashID (int, bắt buộc): ID Dashlet (INT).
 * - @pUsername (string, bắt buộc): Tên đăng nhập người dùng (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysDashParameter WHERE dashid = @pDashID AND username = @pUsername
 * - SET @pRet = @@ERROR
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelDashParameter::call([
 *     'pDashID' => 22,
 *     'pUsername' => 'HIEULQ',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, có lỗi SQL
 * }
 * ```
 * 
 * Lưu ý:
 * - Tất cả tham số đầu vào đều bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột.
 * - Bảng sysDashParameter lưu các tham số cấu hình cho Dashlet (ví dụ: tham số báo cáo, filter).
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelDashParameter
{
    /**
     * Gọi stored procedure asDelDashParameter
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelDashParameter', $params);
    }
}