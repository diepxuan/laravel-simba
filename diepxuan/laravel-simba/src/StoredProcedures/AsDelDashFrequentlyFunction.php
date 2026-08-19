<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelDashFrequentlyFunction
 *
 * Stored procedure: asDelDashFrequentlyFunction
 * Mục đích: Xóa một chức năng thường dùng khỏi danh sách chức năng thường dùng của Dashlet (dashboard widget).
 * Procedure thực hiện DELETE từ bảng sysDashFrequentlyFunction với điều kiện khớp menuid, username và dashid.
 * 
 * Tham số:
 * - @pMenuID (string, bắt buộc): Mã menu/chức năng (NVARCHAR(8)).
 * - @pUserName (string, bắt buộc): Tên đăng nhập người dùng (NVARCHAR(20)).
 * - @pDashID (int, bắt buộc): ID Dashlet (INT).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysDashFrequentlyFunction WHERE menuid = @pMenuID AND username = @pUserName AND dashid = @pDashID
 * - SET @pRet = @@ERROR
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelDashFrequentlyFunction::call([
 *     'pMenuID' => 'MN001',
 *     'pUserName' => 'HIEULQ',
 *     'pDashID' => 22,
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
 * - Điều kiện xóa khớp chính xác trên ba cột.
 * - Bảng sysDashFrequentlyFunction lưu các chức năng thường dùng được người dùng gán cho từng Dashlet.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelDashFrequentlyFunction
{
    /**
     * Gọi stored procedure asDelDashFrequentlyFunction
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelDashFrequentlyFunction', $params);
    }
}