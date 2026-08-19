<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsDashFrequentlyFunction
 *
 * Stored procedure: asInsDashFrequentlyFunction
 * Mục đích: Thêm mới một chức năng thường dùng vào bảng sysDashFrequentlyFunction.
 * Bảng này lưu danh sách các chức năng (menu) mà người dùng thường sử dụng, để hiển thị trên dashboard.
 * Procedure tự động sinh số thứ tự (Stt) mới cho người dùng bằng cách lấy max(Stt) của user đó + 1.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng (20 ký tự).
 * - @pMenuId (string, bắt buộc): Mã menu (8 ký tự). Mã chức năng trong hệ thống.
 * - @pDashID (int, bắt buộc): ID của dashlet (widget) liên kết. Có thể là dashid từ bảng sysDashBoard.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. Lấy max(Stt) từ bảng sysDashFrequentlyFunction với điều kiện username = @pUserName.
 * 2. Nếu không có bản ghi nào, max là NULL, ISNULL thành 0.
 * 3. Tăng giá trị lên 1 để có Stt mới.
 * 4. INSERT vào sysDashFrequentlyFunction với các giá trị truyền vào, stt = giá trị mới.
 * 5. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Số thứ tự Stt là duy nhất trong phạm vi một người dùng, nhưng có thể trùng giữa các user khác nhau.
 * - Có thể có ràng buộc duy nhất trên (username, menuid) hoặc (username, dashid) để tránh trùng lặp.
 * - Nên đảm bảo @pMenuId và @pDashID tồn tại trong các bảng liên quan.
 * - Việc sinh Stt tự động dựa trên max có thể gây tranh chấp nếu nhiều người cùng thêm chức năng cho cùng user.
 * - Bảng sysDashFrequentlyFunction có thể có khóa chính là (username, stt) hoặc (username, menuid).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsDashFrequentlyFunction::call([
 *     'pUserName' => 'admin',
 *     'pMenuId' => 'MN001',
 *     'pDashID' => 5,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysDashFrequentlyFunction: lưu chức năng thường dùng của người dùng.
 * - Bảng sysDashBoard: dashlet.
 * - Các procedure khác: asGetDashFrequentlyFunction, asUpdDashFrequentlyFunction, asDelDashFrequentlyFunction.
 */
class AsInsDashFrequentlyFunction
{
    /**
     * Gọi stored procedure asInsDashFrequentlyFunction
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsDashFrequentlyFunction', $params);
    }
}