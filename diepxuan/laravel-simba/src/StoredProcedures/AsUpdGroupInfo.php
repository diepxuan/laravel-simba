<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdGroupInfo
 *
 * Stored procedure: asUpdGroupInfo
 * Mục đích: Cập nhật thông tin nhóm người dùng trong hệ thống.
 * Procedure cập nhật thông tin cơ bản của nhóm người dùng (tên đầy đủ, quyền grand, trạng thái sử dụng) trong bảng sysGroupInfo.
 * 
 * Tham số:
 * - @pGroupname (string, bắt buộc): Tên nhóm (NVARCHAR(20)). Đây cũng là khóa điều kiện WHERE.
 * - @pFullname (string, bắt buộc): Tên đầy đủ của nhóm (NVARCHAR(50)).
 * - @pGrand (bool, bắt buộc): Cờ chỉ định nhóm có quyền grand (BIT). Ý nghĩa tùy hệ thống.
 * - @pKSD (bool, bắt buộc): Cờ chỉ định nhóm đang sử dụng (KSD = Keep Using?) (BIT). 1 = đang sử dụng, 0 = ngừng sử dụng.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện cập nhật (NVARCHAR(20)).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả thực thi có thể kiểm tra qua số dòng bị ảnh hưởng (affected rows).
 * 
 * Logic chi tiết:
 * - SET NOCOUNT ON (ngăn thông báo số dòng bị ảnh hưởng trả về client).
 * - UPDATE bảng sysGroupInfo: cập nhật các cột Fullname, Grand, KSD, Luser, Ldate (ngày hiện tại) với điều kiện Groupname = @pGroupname.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdGroupInfo::call([
 *     'pGroupname' => 'Admins',
 *     'pFullname' => 'Administrators Group',
 *     'pGrand' => true,
 *     'pKSD' => true,
 *     'pUser' => 'admin',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Tham số @pGroupname là tên nhóm cần cập nhật, đồng thời là khóa điều kiện. Nếu nhóm không tồn tại, không có dòng nào bị ảnh hưởng.
 * - Các cờ BIT trong PHP có thể truyền true/false hoặc 1/0.
 * - Ngày cập nhật (Ldate) được tự động đặt bằng thời gian hiện tại của server (GETDATE()).
 * - Procedure không cập nhật các cột khác như Description (nếu có).
 * - Không có output parameter @pRet, lỗi SQL sẽ ném exception (tùy vào cấu hình kết nối).
 * - Bảng sysGroupInfo lưu thông tin nhóm người dùng dùng để phân quyền theo nhóm.
 * - Nên đảm bảo nhóm tồn tại trước khi cập nhật.
 */
class AsUpdGroupInfo
{
    /**
     * Gọi stored procedure asUpdGroupInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa resultset nếu có SELECT).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asUpdGroupInfo', $params);
    }
}