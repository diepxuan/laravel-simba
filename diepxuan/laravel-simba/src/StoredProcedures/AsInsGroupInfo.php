<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsGroupInfo
 *
 * Stored procedure: asInsGroupInfo
 * Mục đích: Tạo mới một nhóm người dùng trong bảng sysGroupInfo.
 * Bảng này lưu thông tin nhóm người dùng trong hệ thống, dùng để phân quyền.
 * Procedure tự động gán thời gian tạo/cập nhật (cdate, ldate) và người tạo/cập nhật (cuser, luser).
 * 
 * Tham số:
 * - @pGroupname (string, bắt buộc): Tên nhóm (20 ký tự, Unicode). Tên đăng nhập của nhóm.
 * - @pFullname (string, bắt buộc): Tên đầy đủ của nhóm (50 ký tự, Unicode). Tên hiển thị.
 * - @pKsd (bool, bắt buộc): Cờ sử dụng (bit). 1 = nhóm đang hoạt động, 0 = không sử dụng.
 * - @pGrand (bool, bắt buộc): Cờ quyền lớn (bit). Có thể chỉ định nhóm có quyền đặc biệt (admin). 1 = có quyền grand.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện thao tác (20 ký tự). Sẽ được lưu vào cuser và luser.
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả gọi có thể là số dòng bị ảnh hưởng (rows affected) hoặc empty.
 * 
 * Logic chi tiết:
 * 1. INSERT vào sysGroupInfo với các giá trị truyền vào.
 * 2. Các cột cuser, luser = @pUser.
 * 3. Các cột cdate, ldate = GETDATE() (thời gian hiện tại).
 * 
 * Lưu ý:
 * - Bảng sysGroupInfo có khóa chính có thể là GroupName.
 * - Cờ ksd (có thể là viết tắt của "kích hoạt sử dụng") dùng để vô hiệu hóa nhóm mà không xóa.
 * - Cờ Grand có thể cấp quyền đặc biệt cho nhóm (như quyền truy cập tất cả chức năng).
 * - Nên đảm bảo Groupname không trùng với nhóm đã tồn tại.
 * - Procedure không kiểm tra trùng lặng trước khi INSERT, nếu trùng sẽ báo lỗi vi phạm khóa chính.
 * - Thời gian cdate và ldate được lấy từ máy chủ SQL Server (GETDATE()).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsGroupInfo::call([
 *     'pGroupname' => 'ADMIN',
 *     'pFullname' => 'Quản trị hệ thống',
 *     'pKsd' => true,
 *     'pGrand' => true,
 *     'pUser' => 'sysadmin',
 * ]);
 * // $result có thể là số dòng affected hoặc empty
 * ```
 * 
 * Liên quan:
 * - Bảng sysGroupInfo: lưu thông tin nhóm người dùng.
 * - Các procedure khác: asGetGroupInfo, asUpdGroupInfo, asDelGroupInfo.
 */
class AsInsGroupInfo
{
    /**
     * Gọi stored procedure asInsGroupInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là số dòng affected hoặc empty).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsGroupInfo', $params);
    }
}