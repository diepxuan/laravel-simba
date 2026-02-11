<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllRightGroupCompany
 *
 * Stored procedure: asGetAllRightGroupCompany
 * Mục đích: Lấy danh sách các quyền của Group đối với các công ty.
 * Procedure trả về tất cả công ty đang hoạt động (active = '1'), đánh dấu nhóm có quyền hay không.
 * 
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm (NVARCHAR(20)).
 *   Không có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - ten_cty (string): Tên công ty.
 *   - active (string): Trạng thái quyền ('1' nếu nhóm có quyền, '0' nếu không có quyền).
 *     Lưu ý: cột này là chuỗi, không phải bit.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. LEFT JOIN sysCompany a (công ty) với sysGroupCompanyRight b (quyền nhóm) trên điều kiện a.ma_cty = b.ma_cty AND b.GroupName = @pGroupName.
 * 2. WHERE a.active = '1' (chỉ công ty đang hoạt động).
 * 3. Tính active bằng CASE: nếu b.GroupName không NULL (có quyền) thì active = '1', ngược lại active = '0'.
 * 4. Sử dụng LTRIM(RTRIM(...)) để loại bỏ khoảng trắng.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllRightGroupCompany::call([
 *     'pGroupName' => 'Administrators',
 * ]);
 * foreach ($rows as $row) {
 *     echo "Mã công ty: {$row->ma_cty}, Tên: {$row->ten_cty}, Quyền: {$row->active}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pGroupName là bắt buộc, không có giá trị mặc định.
 * - Chỉ trả về các công ty có active = '1' trong bảng sysCompany.
 * - Cột active là chuỗi '0' hoặc '1', không phải bit.
 * - Nếu nhóm không có quyền đối với công ty, b.GroupName sẽ NULL và active = '0'.
 */
class AsGetAllRightGroupCompany
{
    /**
     * Gọi stored procedure asGetAllRightGroupCompany
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllRightGroupCompany', $params);
    }
}