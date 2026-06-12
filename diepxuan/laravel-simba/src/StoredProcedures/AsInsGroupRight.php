<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsGroupRight
 *
 * Stored procedure: asInsGroupRight
 * Mục đích: Thêm mới một bản ghi quyền nhóm vào bảng sysGroupRight.
 * Bảng này lưu quyền của nhóm người dùng đối với các menu/chức năng (view, insert, update, delete).
 * Procedure tự động gán thời gian tạo/cập nhật (Cdate, Ldate) là GETDATE().
 * 
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm (20 ký tự, Unicode). Phải tồn tại trong sysGroupInfo.
 * - @pMenuID (string, bắt buộc): Mã menu (8 ký tự). Menu/chức năng cần cấp quyền.
 * - @pViewRight (string, bắt buộc): Quyền xem (1 ký tự). Có thể là 'Y' (cho phép) hoặc 'N' (không cho phép).
 * - @pInsertRight (string, bắt buộc): Quyền thêm mới (1 ký tự). 'Y' hoặc 'N'.
 * - @pUpdateRight (string, bắt buộc): Quyền sửa (1 ký tự). 'Y' hoặc 'N'.
 * - @pDeleteRight (string, bắt buộc): Quyền xóa (1 ký tự). 'Y' hoặc 'N'.
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
 * 1. Gán @pRet = 0 (khởi tạo).
 * 2. INSERT vào sysGroupRight với các giá trị truyền vào, Cdate = GETDATE(), Ldate = GETDATE().
 * 3. Gán @pRet = @@ERROR (nếu có lỗi sẽ ghi đè giá trị 0).
 * 
 * Lưu ý:
 * - Bảng sysGroupRight có khóa chính có thể là (groupname, menuid).
 * - Các quyền được lưu dưới dạng ký tự 'Y'/'N' (có thể là '1'/'0' nhưng kiểu NVARCHAR(1)).
 * - Nên đảm bảo groupname tồn tại trong sysGroupInfo và menuid tồn tại trong sysMenu.
 * - Nếu đã có bản ghi quyền cho cùng nhóm và menu, INSERT sẽ gây lỗi vi phạm khóa chính.
 * - Procedure không kiểm tra trùng lặp trước khi INSERT.
 * - Thời gian Cdate, Ldate được lấy từ máy chủ SQL Server (GETDATE()).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsGroupRight::call([
 *     'pGroupName' => 'ADMIN',
 *     'pMenuID' => 'MN001',
 *     'pViewRight' => 'Y',
 *     'pInsertRight' => 'Y',
 *     'pUpdateRight' => 'Y',
 *     'pDeleteRight' => 'Y',
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
 * - Bảng sysGroupRight: lưu quyền nhóm người dùng.
 * - Bảng sysGroupInfo: thông tin nhóm.
 * - Các procedure khác: asGetGroupRight, asUpdGroupRight, asDelGroupRight.
 */
class AsInsGroupRight
{
    /**
     * Gọi stored procedure asInsGroupRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsGroupRight', $params);
    }
}