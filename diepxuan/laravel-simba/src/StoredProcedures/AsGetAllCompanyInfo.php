<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllCompanyInfo
 *
 * Stored procedure: asGetAllCompanyInfo
 * Mục đích: Lấy thông tin tất cả công ty đang hoạt động, với hỗ trợ đa ngôn ngữ.
 * Procedure trả về danh sách công ty kèm thông tin chi tiết (mã, tên, địa chỉ, điện thoại, mã thuế, fax, ngân hàng, giám đốc, kế toán trưởng, email...).
 * Dữ liệu được lấy từ bảng sysCompany, kết hợp với bảng dịch sysCompanyResx theo ngôn ngữ chỉ định.
 * Chỉ các công ty có Active='1' được trả về.
 * 
 * Tham số:
 * - @pLanguage (string, tùy chọn): Mã ngôn ngữ (định dạng nvarchar(5), ví dụ 'vi-VN', 'en-US').
 *   Giá trị mặc định: 'vi-VN'
 *   Nếu không cung cấp, sẽ dùng tiếng Việt.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty (từ sysCompany).
 *   - ten_cty (string): Tên công ty (ưu tiên bản dịch nếu có, nếu không dùng từ sysCompany).
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
 * 3. WHERE b.Active='1' (chỉ công ty đang hoạt động).
 * 4. ORDER BY b.Ma_Cty (sắp xếp theo mã công ty).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllCompanyInfo::call([
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc sử dụng giá trị mặc định (không truyền tham số):
 * $rows = AsGetAllCompanyInfo::call([]);
 * foreach ($rows as $row) {
 *     echo "Mã công ty: {$row->ma_cty}, Tên: {$row->ten_cty}, Địa chỉ: {$row->dia_chi}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Ngôn ngữ mặc định là 'vi-VN'. Nếu muốn lấy bản dịch cho ngôn ngữ khác, cần đảm bảo bảng sysCompanyResx có dữ liệu tương ứng.
 * - Chỉ các công ty có Active='1' mới được trả về.
 * - Cột Ten_Cty1 được tạo bằng cách nối mã công ty và tên công ty, dùng để hiển thị trong dropdown.
 */
class AsGetAllCompanyInfo
{
    /**
     * Gọi stored procedure asGetAllCompanyInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllCompanyInfo', $params);
    }
}