<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCompanyInfo
 *
 * Stored procedure: asGetCompanyInfo
 * Mục đích: Lấy thông tin chi tiết của một công ty theo mã công ty, với hỗ trợ đa ngôn ngữ.
 * Procedure trả về thông tin công ty (mã, tên, địa chỉ, điện thoại, mã thuế, fax, ngân hàng, giám đốc, kế toán trưởng, email...).
 * Chỉ trả về công ty đang hoạt động (Active = '1').
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 *   Không có giá trị mặc định.
 * - @pLanguage (string, tùy chọn): Mã ngôn ngữ (NVARCHAR(5), ví dụ 'vi-VN', 'en-US').
 *   Giá trị mặc định: 'vi-VN'
 *   Nếu không cung cấp, sẽ dùng tiếng Việt.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột (tương tự asGetAllCompanyInfo):
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
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. LEFT JOIN sysCompany b (bảng chính) với sysCompanyResx a trên điều kiện b.ma_cty = a.ma_cty và a.language = @pLanguage.
 * 2. Sử dụng ISNULL để ưu tiên giá trị dịch (a.*) nếu có, nếu không dùng giá trị gốc (b.*).
 * 3. WHERE b.ma_cty = @pMa_cty AND b.Active = '1' (chỉ công ty đang hoạt động).
 * 4. ORDER BY b.Ma_Cty (chỉ một bản ghi nhưng vẫn sắp xếp).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCompanyInfo::call([
 *     'pMa_cty' => '001',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc chỉ truyền mã công ty, ngôn ngữ mặc định:
 * $rows = AsGetCompanyInfo::call(['pMa_cty' => '001']);
 * // Kết quả là mảng một phần tử:
 * $company = $rows[0] ?? null;
 * echo "Tên công ty: {$company->ten_cty}, Địa chỉ: {$company->dia_chi}";
 * ```
 * 
 * Lưu ý:
 * - Tham số @pMa_cty là bắt buộc, không có giá trị mặc định.
 * - Ngôn ngữ mặc định là 'vi-VN'.
 * - Chỉ trả về công ty có Active = '1'. Nếu công ty không tồn tại hoặc không hoạt động, resultset rỗng.
 * - Cột Ten_Cty1 được tạo bằng cách nối mã công ty và tên công ty, dùng để hiển thị trong dropdown.
 * - Nếu có nhiều bản dịch cho cùng ngôn ngữ (hiếm), chỉ lấy một bản (LEFT JOIN).
 */
class AsGetCompanyInfo
{
    /**
     * Gọi stored procedure asGetCompanyInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCompanyInfo', $params);
    }
}