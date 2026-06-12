<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllRightCompany
 *
 * Stored procedure: asGetAllRightCompany
 * Mục đích: Lấy danh sách quyền của User đối với các công ty.
 * Procedure trả về tất cả các công ty trong hệ thống, đánh dấu xem user có quyền truy cập công ty đó hay không.
 * Nếu user có quyền (tồn tại trong sysUserCompanyRight), cột Username sẽ chứa tên user; ngược lại Username = @pUserName và Active = 0.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của user (NVARCHAR(20)).
 *   Không có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - ten_cty (string): Tên công ty.
 *   - Username (string): Tên user (nếu có quyền) hoặc chính @pUserName (nếu không có quyền).
 *   - Active (bit): Trạng thái hoạt động (1 nếu user có quyền, 0 nếu không có quyền).
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. Tạo bảng tạm #temp với tất cả công ty từ sysCompany, cột Username rỗng và Active = 1.
 * 2. Cập nhật #temp từ sysUserCompanyRight: gán Username = u.Username nếu user có quyền với công ty đó.
 * 3. Đối với các công ty user không có quyền (Username IS NULL), gán Username = @pUserName và Active = 0.
 * 4. SELECT * FROM #temp ORDER BY ma_cty, ten_cty.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllRightCompany::call([
 *     'pUserName' => 'admin',
 * ]);
 * foreach ($rows as $row) {
 *     echo "Mã công ty: {$row->ma_cty}, Tên: {$row->ten_cty}, Quyền: " . ($row->Active ? 'Có' : 'Không');
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName là bắt buộc, không có giá trị mặc định.
 * - Kết quả trả về bao gồm tất cả công ty trong sysCompany, không lọc theo Active của công ty.
 * - Cột Active = 1 nếu user có quyền truy cập công ty đó (tồn tại bản ghi trong sysUserCompanyRight), ngược lại Active = 0.
 * - Cột Username luôn chứa giá trị (không rỗng): nếu có quyền thì là tên user từ bảng quyền, nếu không có quyền thì là chính @pUserName.
 * - Bảng tạm #temp được tạo và xóa tự động trong phiên thực thi.
 */
class AsGetAllRightCompany
{
    /**
     * Gọi stored procedure asGetAllRightCompany
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllRightCompany', $params);
    }
}