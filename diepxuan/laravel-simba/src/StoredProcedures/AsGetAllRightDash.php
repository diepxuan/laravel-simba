<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllRightDash
 *
 * Stored procedure: asGetAllRightDash
 * Mục đích: Lấy danh sách quyền của User trên màn hình chủ (dashboard).
 * Procedure trả về các chức năng dashboard cùng quyền view/update/delete/insert của user, kết hợp bản dịch theo ngôn ngữ.
 * Chỉ các chức năng có description khác rỗng được trả về.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của user (NVARCHAR(20)).
 *   Không có giá trị mặc định.
 * - @pLanguage (string, tùy chọn): Mã ngôn ngữ (NVARCHAR(5), ví dụ 'vi-VN', 'en-US').
 *   Giá trị mặc định: 'vi-VN'
 *   Nếu không cung cấp, sẽ dùng tiếng Việt.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - username (string): Tên user (luôn là @pUserName).
 *   - functionId (string): Mã chức năng dashboard.
 *   - stt (int?): Số thứ tự sắp xếp.
 *   - description (string): Mô tả chức năng (ưu tiên bản dịch nếu có).
 *   - viewright (bit): Quyền xem (1 nếu có, 0 nếu không).
 *   - updateright (bit): Quyền cập nhật.
 *   - deleteright (bit): Quyền xóa.
 *   - insertright (bit): Quyền thêm mới.
 *   - cuser (string): Người tạo.
 *   - luser (string): Người sửa.
 *   - cdate (string): Ngày tạo (chuỗi).
 *   - ldate (string): Ngày sửa (chuỗi).
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. RIGHT JOIN sysUserDashRight b (quyền user) với sysDashFunction a (danh sách chức năng) trên điều kiện a.FunctionId = b.FunctionId AND b.UserName = @pUserName.
 *    RIGHT JOIN đảm bảo lấy tất cả chức năng, kể cả user không có quyền (khi đó b.* là NULL).
 * 2. LEFT JOIN sysDashFunctionResX c để lấy bản dịch description theo ngôn ngữ.
 * 3. ISNULL(c.[description], a.[description]) ưu tiên bản dịch.
 * 4. ISNULL(b.ViewRight, 0) ...: nếu user không có quyền (b.* NULL) thì gán 0.
 * 5. WHERE a.[description] <> '' (loại bỏ chức năng không có mô tả).
 * 6. ORDER BY a.stt, a.functionId.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllRightDash::call([
 *     'pUserName' => 'admin',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc chỉ truyền user, ngôn ngữ mặc định:
 * $rows = AsGetAllRightDash::call(['pUserName' => 'admin']);
 * foreach ($rows as $row) {
 *     echo "Chức năng: {$row->functionId}, Mô tả: {$row->description}, Quyền xem: {$row->viewright}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName là bắt buộc, không có giá trị mặc định.
 * - Ngôn ngữ mặc định là 'vi-VN'.
 * - Các quyền viewright, updateright, deleteright, insertright là kiểu bit (0/1).
 * - Chỉ các chức năng có description khác rỗng được trả về.
 * - Nếu user không có quyền đối với một chức năng, các cột quyền sẽ là 0, cuser/luser/cdate/ldate sẽ là chuỗi rỗng.
 */
class AsGetAllRightDash
{
    /**
     * Gọi stored procedure asGetAllRightDash
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllRightDash', $params);
    }
}