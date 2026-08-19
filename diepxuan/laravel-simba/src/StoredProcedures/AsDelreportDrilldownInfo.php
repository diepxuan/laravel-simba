<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelreportDrilldownInfo
 *
 * Stored procedure: asDelreportDrilldownInfo
 * Mục đích: Xóa một bản ghi từ bảng sysreportDrilldownInfo (thông tin drilldown báo cáo) dựa trên mã menu, mã mẫu và tên phím bấm.
 * Procedure thực hiện DELETE từ bảng sysreportDrilldownInfo với điều kiện khớp Menuid, Ma_mau và Press_key_name.
 * 
 * Tham số:
 * - @pMenuid (string, bắt buộc): Mã menu (NVARCHAR(8)).
 * - @pMa_mau (string, bắt buộc): Mã mẫu báo cáo (NVARCHAR(8)).
 * - @pPress_key_name (string, bắt buộc): Tên phím bấm (key) để kích hoạt drilldown (NVARCHAR(50)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysreportDrilldownInfo WHERE Menuid = @pMenuid AND Ma_mau = @pMa_mau AND Press_key_name = @pPress_key_name
 * - SET @pRet = @@ERROR
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelreportDrilldownInfo::call([
 *     'pMenuid' => 'MN001',
 *     'pMa_mau' => 'MAU001',
 *     'pPress_key_name' => 'F2',
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
 * - Điều kiện xóa khớp chính xác trên ba cột Menuid, Ma_mau và Press_key_name.
 * - Bảng sysreportDrilldownInfo lưu cấu hình drilldown (chi tiết sâu) cho báo cáo: khi nhấn phím nào trên báo cáo nào sẽ mở chi tiết gì.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelreportDrilldownInfo
{
    /**
     * Gọi stored procedure asDelreportDrilldownInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelreportDrilldownInfo', $params);
    }
}