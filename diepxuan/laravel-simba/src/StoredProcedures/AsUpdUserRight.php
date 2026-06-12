<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdUserRight
 *
 * Stored procedure: asUpdUserRight
 * Mục đích: Cập nhật tên người dùng trong bảng quyền người dùng (sysUserRight).
 * Procedure thay đổi tên người dùng (username) từ giá trị cũ sang giá trị mới trong bảng phân quyền.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên người dùng mới (NVARCHAR(20)).
 * - @pUserName_Old (string, bắt buộc): Tên người dùng cũ (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - Khởi tạo @pRet = 0.
 * - UPDATE bảng sysUserRight: cập nhật cột username = @pUserName với điều kiện username = @pUserName_Old.
 * - Bắt lỗi: SET @pRet = @@error.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdUserRight::call([
 *     'pUserName' => 'newuser',
 *     'pUserName_Old' => 'olduser',
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
 * - Tham số @pUserName_Old là tên người dùng hiện tại trong bảng sysUserRight, dùng làm điều kiện WHERE.
 * - Tham số @pUserName là tên mới sẽ thay thế.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Procedure không cập nhật các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Bảng sysUserRight lưu trữ phân quyền chi tiết cho từng người dùng (có thể là quyền trên menu, chức năng, báo cáo...). Việc thay đổi tên người dùng cần đồng bộ với các bảng khác như sysUserInfo, sysUserGroup.
 * - Nên đảm bảo tên người dùng mới đã tồn tại trong bảng sysUserInfo trước khi thực hiện.
 */
class AsUpdUserRight
{
    /**
     * Gọi stored procedure asUpdUserRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdUserRight', $params);
    }
}