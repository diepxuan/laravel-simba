<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelGroupInfo
 *
 * Stored procedure: asDelGroupInfo
 * Mục đích: Xóa một nhóm người dùng khỏi danh mục nhóm người dùng (sysGroupInfo) dựa trên tên nhóm.
 * Procedure thực hiện DELETE từ bảng sysGroupInfo với điều kiện khớp groupname.
 * 
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm cần xóa (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: luôn gán 0 (thành công). Khác với các procedure khác, không dùng @@error.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công (luôn là 0 nếu không có lỗi runtime).
 * 
 * Logic chi tiết:
 * - DELETE FROM sysGroupInfo WHERE groupname = @pGroupName
 * - SET @pRet = 0 (luôn thành công)
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelGroupInfo::call([
 *     'pGroupName' => 'Administrators',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công (hoặc không có bản ghi nào bị xóa)
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pGroupName bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột groupname.
 * - Bảng sysGroupInfo lưu danh mục nhóm người dùng (phân quyền).
 * - Procedure luôn trả về @pRet = 0, không phản ánh lỗi SQL (nếu có lỗi runtime sẽ ném exception?).
 * - Cần đảm bảo không còn người dùng thuộc nhóm này trước khi xóa (ràng buộc khóa ngoại).
 */
class AsDelGroupInfo
{
    /**
     * Gọi stored procedure asDelGroupInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelGroupInfo', $params);
    }
}