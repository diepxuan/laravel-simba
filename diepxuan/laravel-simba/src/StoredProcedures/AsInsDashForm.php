<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsDashForm
 *
 * Stored procedure: asInsDashForm
 * Mục đích: Thêm mới một dashlet (widget) vào bảng sysDashBoard (dashboard người dùng).
 * Dashlet là một thành phần giao diện người dùng, hiển thị chức năng thường dùng, menu, báo cáo, v.v.
 * Procedure tự động sinh ID mới bằng cách lấy max(dashid) hiện có + 1.
 * 
 * Tham số:
 * - @pUsername (string, bắt buộc): Tên đăng nhập của người dùng (20 ký tự).
 * - @pTitle (string, bắt buộc): Tiêu đề dashlet (50 ký tự, Unicode).
 * - @pFunctionID (string, bắt buộc): Mã chức năng (8 ký tự). Có thể là mã menu hoặc mã báo cáo.
 * - @pFormat (string, bắt buộc): Định dạng dashlet (20 ký tự). Ví dụ: 'MENU', 'REPORT', 'CHART'.
 * - @pLocation (int, bắt buộc): Vị trí dashlet trên dashboard (số nguyên). Có thể là chỉ số cột, vùng.
 * - @pX (int, bắt buộc): Tọa độ X (số nguyên). Tham số này không được sử dụng trong INSERT (có thể dự phòng).
 * - @pY (int, bắt buộc): Tọa độ Y (số nguyên). Được lưu vào cột Y.
 * - @pH (int, bắt buộc): Chiều cao (height) dashlet (số nguyên). Được lưu vào cột H.
 * - @pW (int, bắt buộc): Chiều rộng (width) dashlet (số nguyên). Được lưu vào cột W.
 * - @pType (string, bắt buộc): Loại dashlet (1 ký tự). Kiểu NCHAR(1). Ví dụ: 'M' cho menu, 'R' cho báo cáo.
 * - @pDashId (int, output): ID mới của dashlet vừa được thêm.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameters @pDashId và @pRet.
 * - @pDashId = ID mới (integer >0) nếu thêm thành công.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. Lấy max(dashid) từ bảng sysDashBoard, gán vào @pDashId. Nếu không có bản ghi nào, max là NULL, ISNULL thành 0.
 * 2. Tăng @pDashId lên 1.
 * 3. INSERT vào sysDashBoard với các giá trị truyền vào, dashid = @pDashId.
 * 4. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Tham số @pX không được sử dụng trong INSERT (không có cột X trong bảng sysDashBoard). Có thể là tham số dự phòng cho tương lai.
 * - Cột Y, H, W tương ứng với @pY, @pH, @pW. Có thể đại diện cho vị trí và kích thước pixel hoặc đơn vị grid.
 * - Việc sinh ID tự động dựa trên max(dashid) có thể gây tranh chấp trong môi trường multi-user. Có thể cần transaction.
 * - Bảng sysDashBoard có thể có khóa chính là dashid hoặc kết hợp với username.
 * - Nên đảm bảo username tồn tại trong hệ thống.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsDashForm::call([
 *     'pUsername' => 'admin',
 *     'pTitle' => 'Chức năng thường dùng',
 *     'pFunctionID' => 'MENU001',
 *     'pFormat' => 'MENU',
 *     'pLocation' => 2,
 *     'pX' => 0,  // không dùng
 *     'pY' => 100,
 *     'pH' => 200,
 *     'pW' => 300,
 *     'pType' => 'M',
 * ]);
 * $dashId = $result['pDashId'] ?? null;
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công, dashlet ID = $dashId
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysDashBoard: lưu cấu hình dashboard của người dùng.
 * - Các procedure khác: asGetDashForm, asUpdDashForm, asDelDashForm (nếu có).
 */
class AsInsDashForm
{
    /**
     * Gọi stored procedure asInsDashForm
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameters @pDashId và @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsDashForm', $params);
    }
}