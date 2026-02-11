<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsUserRight
 *
 * Stored procedure: asInsUserRight
 * Mục đích: Thêm mới một bản ghi quyền user vào bảng sysUserRight.
 * Bảng này lưu quyền chi tiết của user đối với các menu/chức năng (view, insert, update, delete) và giới hạn in (LimitedPrint).
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của user (20 ký tự). Phải tồn tại trong sysUserInfo.
 * - @pMenuID (string, bắt buộc): Mã menu (8 ký tự). Menu/chức năng cần cấp quyền.
 * - @pViewRight (string, bắt buộc): Quyền xem (1 ký tự). 'Y' = cho phép, 'N' = không.
 * - @pInsertRight (string, bắt buộc): Quyền thêm mới (1 ký tự). 'Y' hoặc 'N'.
 * - @pUpdateRight (string, bắt buộc): Quyền sửa (1 ký tự). 'Y' hoặc 'N'.
 * - @pDeleteRight (string, bắt buộc): Quyền xóa (1 ký tự). 'Y' hoặc 'N'.
 * - @pLimitedPrint (int, bắt buộc): Giới hạn in (integer). Số lần in tối đa? Có thể là số lượng bản in cho phép, 0 = không giới hạn.
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
 * 1. Khởi tạo @pRet = 0.
 * 2. INSERT vào sysUserRight với các giá trị truyền vào.
 * 3. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Bảng sysUserRight có khóa chính có thể là (username, menuid).
 * - Các quyền được lưu dưới dạng ký tự 'Y'/'N' (có thể là '1'/'0' nhưng kiểu NVARCHAR(1)).
 * - LimitedPrint có thể dùng để giới hạn số lần in chứng từ cho user đối với menu đó. Giá trị nguyên, ý nghĩa tùy hệ thống.
 * - Nên đảm bảo username tồn tại trong sysUserInfo và menuid tồn tại trong sysMenu.
 * - Nếu đã có bản ghi quyền cho cùng user và menu, INSERT sẽ gây lỗi vi phạm khóa chính.
 * - Procedure không kiểm tra trùng lặp trước khi INSERT.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsUserRight::call([
 *     'pUserName' => 'user1',
 *     'pMenuID' => 'MN001',
 *     'pViewRight' => 'Y',
 *     'pInsertRight' => 'N',
 *     'pUpdateRight' => 'Y',
 *     'pDeleteRight' => 'N',
 *     'pLimitedPrint' => 10,
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
 * - Bảng sysUserRight: lưu quyền chi tiết của user.
 * - Bảng sysUserInfo: thông tin user.
 * - Các procedure khác: asGetUserRight, asUpdUserRight, asDelUserRight.
 */
class AsInsUserRight
{
    /**
     * Gọi stored procedure asInsUserRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsUserRight', $params);
    }
}