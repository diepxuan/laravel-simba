<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsUserGroup
 *
 * Stored procedure: asInsUserGroup
 * Mục đích: Thêm user vào nhóm (bảng sysUserGroup) với điều kiện kiểm tra user có phải admin không.
 * Procedure này có tham số @pDel để điều khiển hành động: xóa user khỏi tất cả nhóm cũ, sau đó chèn vào nhóm mới nếu @pDel <> 0.
 * Nếu user là admin (isadmin = 1), procedure return ngay mà không làm gì.
 * 
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm (20 ký tự). Nhóm cần thêm user vào.
 * - @pUserName (string, bắt buộc): Tên đăng nhập của user (20 ký tự).
 * - @pDel (int, bắt buộc): Cờ điều khiển (integer). Ý nghĩa:
 *   - Nếu @pDel = 1 hoặc 0: xóa tất cả bản ghi của user trong sysUserGroup (DELETE WHERE UserName = @pUserName).
 *   - Nếu @pDel <> 0: sau khi xóa (nếu có), INSERT user vào nhóm mới.
 *   - Nếu @pDel = 0 và không phải 1? Logic: IF @pDel = 1 OR @pDel = 0 => DELETE, sau đó IF @pDel <> 0 => INSERT. Vậy:
 *     - @pDel = 0: chỉ DELETE, không INSERT (user bị xóa khỏi tất cả nhóm).
 *     - @pDel = 1: DELETE rồi INSERT (user được chuyển sang nhóm mới).
 *     - @pDel khác 0 và khác 1: không DELETE? Thực tế điều kiện DELETE chỉ xảy ra khi @pDel = 1 hoặc 0, còn @pDel khác 0 và khác 1 thì không DELETE, nhưng vẫn INSERT vì @pDel <> 0. Có thể là thiết kế kỳ lạ.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu thành công, khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. Khởi tạo @pRet = 0.
 * 2. Kiểm tra EXISTS: SELECT isadmin FROM sysUserInfo WHERE username = @pUserName AND isadmin = 1.
 * 3. Nếu user là admin (isadmin = 1), RETURN @pRet (không làm gì, @pRet vẫn 0).
 * 4. Nếu @pDel = 1 hoặc @pDel = 0, DELETE từ sysUserGroup WHERE UserName = @pUserName (xóa tất cả nhóm của user).
 * 5. Nếu @pDel <> 0, INSERT vào sysUserGroup với groupname và username.
 * 6. Gán @pRet = @@ERROR (lỗi của lệnh DELETE ho INSERT cuối cùng).
 * 
 * Lưu ý:
 * - Bảng sysUserGroup có khóa chính có thể là (username, groupname) hoặc chỉ username? DELETE xóa tất cả nhóm của user, sau đó chỉ thêm một nhóm duy nhất (có thể mỗi user chỉ thuộc một nhóm?).
 * - User admin (isadmin = 1) không bị thay đổi nhóm (procedure bỏ qua). Điều này bảo vệ tài khoản admin khỏi bị sửa nhóm.
 * - Tham số @pDel có logic phức tạp, cần hiểu rõ khi gọi. Có thể thiết kế ban đầu dùng @pDel như cờ "delete old" (0: không xóa, 1: xóa và thêm, 2: chỉ thêm?). Nhưng hiện tại có vẻ không rõ ràng.
 * - Nên đảm bảo groupname tồn tại trong sysGroupInfo và username tồn tại trong sysUserInfo.
 * - Nếu user không phải admin và @pDel = 0, user sẽ bị xóa khỏi tất cả nhóm (không thuộc nhóm nào). Điều này có thể dùng để xóa user khỏi nhóm.
 * - Nếu @pDel khác 0 và khác 1 (ví dụ 2), DELETE không được thực hiện (vì không thỏa @pDel = 1 OR @pDel = 0), nhưng INSERT vẫn được thực hiện (vì @pDel <> 0). Điều này có thể dẫn đến trùng lặp nếu user đã có nhóm đó.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsUserGroup::call([
 *     'pGroupName' => 'ADMIN',
 *     'pUserName' => 'user1',
 *     'pDel' => 1,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thao tác thành công (đã xóa nhóm cũ và thêm vào nhóm mới)
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysUserGroup: lưu user thuộc nhóm.
 * - Bảng sysUserInfo: thông tin user.
 * - Các procedure khác: asGetUserGroup, asUpdUserGroup, asDelUserGroup.
 */
class AsInsUserGroup
{
    /**
     * Gọi stored procedure asInsUserGroup
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsUserGroup', $params);
    }
}