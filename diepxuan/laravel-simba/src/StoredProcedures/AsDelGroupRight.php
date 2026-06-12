<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelGroupRight
 *
 * Stored procedure: asDelGroupRight
 * Mục đích: Xóa quyền của nhóm người dùng từ bảng sysGroupRight dựa trên tên nhóm và mã menu (có thể xóa theo prefix).
 * Procedure thực hiện DELETE từ bảng sysGroupRight với điều kiện groupname và menuid LIKE prefix.
 * 
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm cần xóa quyền (NVARCHAR(20)).
 * - @pMenuID (string, tùy chọn): Mã menu (NVARCHAR(8)). Nếu truyền NULL hoặc rỗng, sẽ xóa tất cả quyền của nhóm (vì LIKE '%').
 * - @pRet (int, output): Kết quả thực thi: luôn gán 0 (thành công). Không dùng @@error.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công (luôn là 0 nếu không có lỗi runtime).
 * 
 * Logic chi tiết:
 * - Nếu @pMenuId = NULL thì SET @pMenuID = '' (chuỗi rỗng).
 * - DELETE FROM sysGroupRight WHERE groupname = @pGroupName AND menuid LIKE @pMenuID + '%'
 * - SET @pRet = 0 (luôn thành công)
 * 
 * Ví dụ gọi:
 * ```php
 * // Xóa tất cả quyền của nhóm
 * $result = AsDelGroupRight::call([
 *     'pGroupName' => 'Administrators',
 *     'pMenuID' => null,
 * ]);
 * // Hoặc xóa các quyền có mã menu bắt đầu bằng 'MN'
 * $result = AsDelGroupRight::call([
 *     'pGroupName' => 'Users',
 *     'pMenuID' => 'MN',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pGroupName bắt buộc, @pMenuID có thể truyền null hoặc chuỗi rỗng.
 * - Điều kiện xóa sử dụng LIKE với prefix, nghĩa là xóa tất cả quyền có menuid bắt đầu bằng giá trị @pMenuID.
 * - Nếu @pMenuID là chuỗi rỗng, điều kiện LIKE '%' sẽ xóa tất cả quyền của nhóm.
 * - Bảng sysGroupRight lưu quyền của nhóm người dùng trên các menu/chức năng.
 * - Procedure luôn trả về @pRet = 0, không phản ánh lỗi SQL (nếu có lỗi runtime sẽ ném exception?).
 * - Cần đảm bảo tính nhất quán phân quyền sau khi xóa.
 */
class AsDelGroupRight
{
    /**
     * Gọi stored procedure asDelGroupRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelGroupRight', $params);
    }
}