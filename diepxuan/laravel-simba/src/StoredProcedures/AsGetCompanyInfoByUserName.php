<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCompanyInfoByUserName
 *
 * Stored procedure: asGetCompanyInfoByUserName
 * Mục đích: Lấy thông tin công ty mà user có quyền truy cập, với hỗ trợ đa ngôn ngữ.
 * Procedure trả về danh sách công ty đang hoạt động (Active = '1') mà user được phân quyền trong sysUserCompanyRight.
 * Kèm thông tin user (fullname từ sysUserInfo) cho mỗi công ty (lưu ý: nếu user có quyền nhiều công ty, fullname lặp lại).
 * 
 * Tham số:
 * - @pUserName (string, tùy chọn): Tên đăng nhập user (NVARCHAR(20)).
 *   Giá trị mặc định: '' (chuỗi rỗng).
 *   Nếu truyền rỗng, subquery WHERE Username = '' sẽ không trả về mã công ty nào, do đó kết quả rỗng.
 *   Nên truyền tên user hợp lệ.
 * - @pLanguage (string, tùy chọn): Mã ngôn ngữ (NVARCHAR(5), ví dụ 'vi-VN', 'en-US').
 *   Giá trị mặc định: 'vi-VN'
 *   Nếu không cung cấp, sẽ dùng tiếng Việt.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột (tương tự asGetCompanyInfo, thêm fullname):
 *   - ma_cty (string): Mã công ty.
 *   - ten_cty (string): Tên công ty (ưu tiên bản dịch nếu có).
 *   - ten_tcty (string): Tên tắt công ty.
 *   - dia_chi (string): Địa chỉ.
 *   - tel (string): Số điện thoại.
 *   - ma_thue (string): Mã số thuế.
 *   - fax (string): Số fax.
 *   - ten_nh (string): Tên ngân hàng.
 *   - so_tk_nh (string): Số tài khoản ngân hàng.
 *   - tinh_tp_nh (string): Tỉnh/thành phố ngân hàng.
 *   - Ten_Cty1 (string): Chuỗi kết hợp "Mã_Cty - Ten_Cty" dùng cho hiển thị.
 *   - ten_qd_cdkt (string): Tên quyết định chế độ kế toán.
 *   - qd_cdkt (string): Số quyết định chế độ kế toán.
 *   - giam_doc (string): Giám đốc.
 *   - ktt (string): Kế toán trưởng.
 *   - email (string): Email liên hệ.
 *   - fullname (string): Họ tên đầy đủ của user (lấy từ sysUserInfo).
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. LEFT JOIN sysCompany b với sysUserInfo ui trên ui.username = @pUserName (lấy fullname).
 * 2. LEFT JOIN sysCompanyResx a trên b.ma_cty = a.ma_cty và a.language = @pLanguage (bản dịch).
 * 3. WHERE b.ma_cty IN (SELECT ma_cty FROM sysUserCompanyRight WHERE Username = @pUserName) (chỉ công ty user có quyền).
 * 4. AND b.Active = '1' (chỉ công ty đang hoạt động).
 * 5. ORDER BY b.Ma_Cty.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCompanyInfoByUserName::call([
 *     'pUserName' => 'admin',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc chỉ truyền user:
 * $rows = AsGetCompanyInfoByUserName::call(['pUserName' => 'admin']);
 * foreach ($rows as $row) {
 *     echo "Công ty: {$row->ma_cty}, Tên: {$row->ten_cty}, User: {$row->fullname}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName mặc định rỗng, nhưng nếu không truyền hoặc truyền rỗng, kết quả sẽ rỗng (vì không có công ty nào thỏa subquery).
 * - Ngôn ngữ mặc định là 'vi-VN'.
 * - Chỉ trả về các công ty có Active = '1' và user có quyền truy cập.
 * - Nếu user có quyền nhiều công ty, mỗi công ty một dòng, fullname lặp lại (cùng một user).
 * - Nếu user không có quyền công ty nào, resultset rỗng.
 * - Nếu sysUserInfo không có bản ghi cho username, fullname sẽ NULL.
 * - Cột Ten_Cty1 dùng cho hiển thị dropdown.
 */
class AsGetCompanyInfoByUserName
{
    /**
     * Gọi stored procedure asGetCompanyInfoByUserName
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCompanyInfoByUserName', $params);
    }
}