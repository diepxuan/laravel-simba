<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelDashForm
 *
 * Stored procedure: asDelDashForm
 * Mục đích: Xóa form Dashlet (dashboard widget) của người dùng và cập nhật vị trí các Dashlet còn lại.
 * Procedure thực hiện:
 * 1. Xóa các chức năng thường dùng liên quan đến dashid và username từ sysDashFrequentlyFunction.
 * 2. Xóa các tham số liên quan từ sysDashParameter.
 * 3. Cập nhật tọa độ Y của các Dashlet nằm phía sau Dashlet bị xóa (dịch lên trên) để tránh khoảng trống.
 * 4. Xóa thông tin Dashlet từ sysDashBoard.
 * 5. Xóa biểu đồ báo cáo liên quan từ sysReportChart (nếu có).
 * 
 * Tham số:
 * - @pDashid (int, bắt buộc): ID của Dashlet cần xóa (INT).
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng sở hữu Dashlet (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - Xác định vị trí (location) và tọa độ Y, chiều cao H của Dashlet cần xóa từ sysDashBoard.
 * - Nếu location = 0 (có lẽ là vị trí mặc định), duyệt qua các Dashlet có Y lớn hơn Y của Dashlet bị xóa, cập nhật Y của chúng thành Y hiện tại, sau đó tăng Y lên (H + 15) cho Dashlet tiếp theo.
 * - Nếu location != 0, chỉ xử lý các Dashlet cùng location và Y lớn hơn.
 * - Cuối cùng xóa Dashlet khỏi sysDashBoard và xóa biểu đồ liên quan từ sysReportChart.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelDashForm::call([
 *     'pDashid' => 22,
 *     'pUserName' => 'HIEULQ',
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
 * - Tham số @pDashid và @pUserName bắt buộc, không có giá trị mặc định.
 * - Procedure này thực hiện nhiều thao tác DELETE và UPDATE, cần đảm bảo quyền và tính toàn vẹn dữ liệu.
 * - Việc cập nhật vị trí Y đảm bảo giao diện dashboard không bị khoảng trống sau khi xóa.
 * - Có sử dụng cursor để duyệt qua các Dashlet, có thể ảnh hưởng hiệu năng nếu số lượng lớn.
 */
class AsDelDashForm
{
    /**
     * Gọi stored procedure asDelDashForm
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelDashForm', $params);
    }
}