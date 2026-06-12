<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdDashLocation
 *
 * Stored procedure: asUpdDashLocation
 * Mục đích: Di chuyển các Dashlet trên dashboard (cập nhật vị trí và kích thước).
 * Procedure cập nhật thông tin vị trí (location, x, y) và kích thước (h, w) của một dashlet cho người dùng cụ thể.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên người dùng (NVARCHAR(20)).
 * - @pDashIdSrc (int, bắt buộc): ID dashlet nguồn (INT). Dashlet cần di chuyển.
 * - @pLocationTar (int, bắt buộc): Vị trí đích (location) (INT). Có thể là chỉ số cột hoặc khu vực.
 * - @pXTar (int, bắt buộc): Tọa độ X đích (INT). Vị trí pixel hoặc thứ tự trong location.
 * - @pYTar (int, bắt buộc): Tọa độ Y đích (INT). Vị trí pixel hoặc thứ tự trong location.
 * - @pHSrc (int, bắt buộc): Chiều cao (height) của dashlet (INT).
 * - @pWSrc (int, bắt buộc): Chiều rộng (width) của dashlet (INT).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - UPDATE bảng sysDashBoard: cập nhật các cột location, x, y, h, w với điều kiện username = @pUserName AND dashid = @pDashIdSrc.
 * - Bắt lỗi: SET @pRet = @@ERROR.
 * 
 * Ví dụ gọi (theo comment trong SQL):
 * ```php
 * $result = AsUpdDashLocation::call([
 *     'pUserName' => 'HIEULQ',
 *     'pDashIdSrc' => 1,
 *     'pLocationTar' => 1,
 *     'pXTar' => 1,
 *     'pYTar' => '1', // SQL truyền string '1' nhưng kiểu INT, có thể tự convert
 *     'pHSrc' => 0,
 *     'pWSrc' => 0,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pYTar trong ví dụ gốc được truyền là chuỗi '1' nhưng kiểu dữ liệu là INT. Trong PHP có thể truyền số nguyên.
 * - Điều kiện WHERE gồm username và dashid (có thể là khóa chính phức hợp).
 * - Bảng sysDashBoard lưu cấu hình dashboard của từng người dùng: vị trí, kích thước các dashlet (widget).
 * - Các trường location, x, y có thể dùng để sắp xếp dashlet trong giao diện grid.
 * - Lỗi @@ERROR có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 */
class AsUpdDashLocation
{
    /**
     * Gọi stored procedure asUpdDashLocation
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdDashLocation', $params);
    }
}