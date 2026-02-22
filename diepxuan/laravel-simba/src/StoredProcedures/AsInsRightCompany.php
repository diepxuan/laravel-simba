<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsRightCompany
 *
 * Stored procedure: asInsRightCompany
 * Mục đích: Thêm quyền sử dụng công ty cho user vào bảng sysUserCompanyRight.
 * Procedure này xóa quyền cũ (nếu có) của user đối với công ty đó, sau đó chèn quyền mới chỉ khi @pActive = '1' (kích hoạt).
 * Nếu @pActive khác '1', procedure return ngay (không chèn) và không thay đổi quyền (đã xóa quyền cũ).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Công ty được cấp quyền.
 * - @pUsername (string, bắt buộc): Tên đăng nhập của user (20 ký tự).
 * - @pActive (bool, bắt buộc): Cờ kích hoạt (bit). 1 = cấp quyền, 0 (hoặc khác 1) = không cấp quyền (chỉ xóa quyền cũ).
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
 * 1. Xóa bản ghi trong sysUserCompanyRight có Username = @pUsername và Ma_cty = @pMa_cty (nếu có).
 * 2. Nếu @pActive <> '1' (không kích hoạt) thì RETURN (thoát) và gán @pRet = 0 (nhưng RETURN có thể thực hiện trước khi gán, nên @pRet có thể không được thiết lập? Trong code có SET @pRet = 0 sau RETURN, nhưng RETURN ngay lập tức nên không chạy đến dòng đó. Tuy nhiên, output parameter đã khởi tạo với giá trị NULL? Cần kiểm tra).
 * 3. Nếu @pActive = '1', INSERT vào sysUserCompanyRight với username và ma_cty.
 * 4. Gán @pRet = @@ERROR (lỗi của INSERT hoặc DELETE? @@ERROR sẽ lấy lỗi của câu lệnh SQL trước đó).
 * 
 * Lưu ý:
 * - Bảng sysUserCompanyRight có khóa chính có thể là (username, ma_cty).
 * - Nếu @pActive <> '1', procedure chỉ xóa quyền cũ và không chèn quyền mới (user mất quyền với công ty đó).
 * - Việc so sánh @pActive với '1' (chuỗi) có thể do truyền từ client dạng chuỗi. Kiểu dữ liệu của @pActive là BIT, nhưng SQL Server có thể so sánh với chuỗi '1' được.
 * - Nên đảm bảo username và ma_cty tồn tại trong các bảng liên quan.
 * - Nếu có lỗi trong DELETE, @@ERROR sẽ bắt lỗi đó, nhưng procedure vẫn tiếp tục thực hiện.
 * - Output parameter @pRet có thể không được thiết lập trong trường hợp RETURN sớm (có thể giữ giá trị NULL). Tuy nhiên, trong code có SET @pRet = 0 sau RETURN nhưng không được thực thi. Có thể cần điều chỉnh logic.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsRightCompany::call([
 *     'pMa_cty' => '001',
 *     'pUsername' => 'admin',
 *     'pActive' => true,
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
 * - Bảng sysUserCompanyRight: lưu quyền user được truy cập công ty.
 * - Các procedure khác: asGetRightCompany, asUpdRightCompany, asDelRightCompany.
 */
class AsInsRightCompany
{
    /**
     * Gọi stored procedure asInsRightCompany
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsRightCompany', $params);
    }
}