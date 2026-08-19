<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelreportresx
 *
 * Stored procedure: asDelreportresx
 * Mục đích: Xóa một bản ghi từ bảng sysReportresx (bản dịch báo cáo) dựa trên mã menu và mã mẫu.
 * Procedure thực hiện DELETE từ bảng sysReportresx với điều kiện khớp Menuid và Ma_mau.
 * 
 * Tham số:
 * - @pMenuid (string, bắt buộc): Mã menu (NVARCHAR(8)).
 * - @pMa_mau (string, bắt buộc): Mã mẫu báo cáo (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysReportresx WHERE Menuid = @pMenuid AND Ma_mau = @pMa_mau
 * - SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelreportresx::call([
 *     'pMenuid' => 'MN001',
 *     'pMa_mau' => 'MAU001',
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
 * - Tham số @pMenuid và @pMa_mau bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột Menuid và Ma_mau.
 * - Bảng sysReportresx lưu các bản dịch (resource) cho thông tin báo cáo đa ngôn ngữ.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelreportresx
{
    /**
     * Gọi stored procedure asDelreportresx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelreportresx', $params);
    }
}