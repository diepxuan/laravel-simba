<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllUserRights
 *
 * Stored procedure: asGetAllUserRights
 * Mục đích: Lấy tất cả các quyền của một người dùng để phân quyền.
 * Procedure trả về danh sách menu cùng các quyền view/update/delete/insert/limitedprint của user, kết hợp bản dịch theo ngôn ngữ.
 * Chỉ các menu có bar khác rỗng và hai ký tự cuối mã menu (vị trí 7-8) khác '00' được trả về.
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
 *   - MenuID (string): Mã menu.
 *   - bar (string): Tên hiển thị menu (ưu tiên bản dịch nếu có).
 *   - BasicRight (string?): Quyền cơ bản (từ sysMenu).
 *   - LinkDetail (string): Hai ký tự từ vị trí 4-5 của MenuID (dùng để liên kết chi tiết).
 *   - Link (string): Hai ký tự đầu của MenuID (dùng để liên kết nhóm).
 *   - ViewRight (bit): Quyền xem (1 nếu có, 0 nếu không).
 *   - UpdateRight (bit): Quyền cập nhật.
 *   - DeleteRight (bit): Quyền xóa.
 *   - InsertRight (bit): Quyền thêm mới.
 *   - LimitedPrint (bit): Quyền in giới hạn.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. RIGHT JOIN sysUserRight b (quyền user) với sysMenu a (danh sách menu) trên điều kiện a.MenuID = b.MenuID AND b.UserName = @pUserName.
 *    RIGHT JOIN đảm bảo lấy tất cả menu, kể cả user không có quyền (khi đó b.* là NULL).
 * 2. LEFT JOIN sysmenuResx c để lấy bản dịch bar theo ngôn ngữ.
 * 3. ISNULL(c.bar, a.bar) ưu tiên bản dịch.
 * 4. ISNULL(b.ViewRight, 0) ...: nếu user không có quyền (b.* NULL) thì gán 0.
 * 5. WHERE SUBSTRING(a.MenuId, 7, 2) <> '00' (loại bỏ menu có hai ký tự cuối là '00', thường là menu gốc).
 * 6. WHERE a.bar <> '' (loại bỏ menu không có tên hiển thị).
 * 7. ORDER BY a.MenuID.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllUserRights::call([
 *     'pUserName' => 'admin',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc chỉ truyền user:
 * $rows = AsGetAllUserRights::call(['pUserName' => 'admin']);
 * foreach ($rows as $row) {
 *     echo "Menu: {$row->MenuID}, Tên: {$row->bar}, Quyền xem: {$row->ViewRight}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName là bắt buộc, không có giá trị mặc định.
 * - Ngôn ngữ mặc định là 'vi-VN'.
 * - Các quyền ViewRight, UpdateRight, DeleteRight, InsertRight, LimitedPrint là kiểu bit (0/1).
 * - Chỉ các menu có bar khác rỗng và hai ký tự cuối mã menu khác '00' được trả về (loại bỏ menu gốc).
 * - Cột LinkDetail và Link được trích từ MenuID để hỗ trợ phân nhóm quyền trong giao diện.
 */
class AsGetAllUserRights
{
    /**
     * Gọi stored procedure asGetAllUserRights
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllUserRights', $params);
    }
}