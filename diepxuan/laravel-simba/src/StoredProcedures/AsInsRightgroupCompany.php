<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsRightgroupCompany
 *
 * Stored procedure: asInsRightgroupCompany
 * Mục đích: Thêm quyền sử dụng công ty cho nhóm vào bảng sysGroupCompanyRight.
 * Procedure này xóa quyền cũ (nếu có) của nhóm đối với công ty đó, sau đó chèn quyền mới chỉ khi @pActive = '1' (kích hoạt).
 * Nếu @pActive khác '1', procedure chỉ xóa quyền cũ và return (không chèn).
 * 
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm (20 ký tự). Nhóm được cấp quyền.
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Công ty được cấp quyền.
 * - @pActive (string, bắt buộc): Cờ kích hoạt (1 ký tự). '1' = cấp quyền, khác '1' = không cấp quyền (chỉ xóa quyền cũ).
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu thành công (kể cả khi không chèn do @pActive <> '1'), khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. Khởi tạo @pRet = 1 (có vẻ mặc định lỗi?).
 * 2. Xóa bản ghi trong sysGroupCompanyRight có GroupName = @pGroupName và Ma_cty = @pMa_cty (nếu có).
 * 3. Nếu @pActive <> '1' (không kích hoạt) thì gán @pRet = @@ERROR (lỗi của DELETE) và RETURN.
 * 4. Nếu @pActive = '1', INSERT vào sysGroupCompanyRight với GroupName và ma_cty.
 * 5. Gán @pRet = @@ERROR (lỗi của INSERT).
 * 
 * Lưu ý:
 * - Bảng sysGroupCompanyRight có khóa chính có thể là (GroupName, ma_cty).
 * - Nếu @pActive <> '1', procedure xóa quyền cũ và return với @pRet = lỗi của DELETE (nếu có). Nếu DELETE thành công, @pRet = 0.
 * - Tham số @pActive kiểu NVARCHAR(1) (chuỗi) thay vì BIT. So sánh với '1' chuỗi.
 * - Nên đảm bảo GroupName và ma_cty tồn tại trong các bảng liên quan.
 * - Việc khởi tạo @pRet = 1 có thể là giá trị mặc định nếu có lỗi, nhưng sau đó được gán lại bằng @@ERROR.
 * - Nếu có lỗi trong DELETE, @@ERROR sẽ bắt lỗi đó, và nếu @pActive <> '1' thì trả về lỗi đó. Nếu @pActive = '1' thì vẫn tiếp tục INSERT (có thể gây lỗi khóa ngoại nếu đã xóa thành công?).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsRightgroupCompany::call([
 *     'pGroupName' => 'ADMIN',
 *     'pMa_cty' => '001',
 *     'pActive' => '1',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thao tác thành công (đã xóa và chèn nếu active)
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysGroupCompanyRight: lưu quyền nhóm được truy cập công ty.
 * - Các procedure khác: asGetRightgroupCompany, asUpdRightgroupCompany, asDelRightgroupCompany.
 */
class AsInsRightgroupCompany
{
    /**
     * Gọi stored procedure asInsRightgroupCompany
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsRightgroupCompany', $params);
    }
}