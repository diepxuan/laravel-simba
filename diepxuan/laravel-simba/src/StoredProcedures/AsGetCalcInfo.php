<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCalcInfo
 *
 * Stored procedure: asGetCalcInfo
 * Mục đích: Lấy thông tin tính toán (sysCalcInfo) theo MenuID.
 * Procedure trả về tất cả các cột của bảng sysCalcInfo cho menu chỉ định.
 * Nếu @pMenuID là chuỗi rỗng (mặc định), sẽ trả về tất cả bản ghi (vì a.MenuID = '').
 * 
 * Tham số:
 * - @pMenuID (string, tùy chọn): Mã menu (NVARCHAR(8)).
 *   Giá trị mặc định: '' (chuỗi rỗng).
 *   Nếu truyền rỗng, điều kiện WHERE a.MenuID = '' sẽ lấy các bản ghi có MenuID rỗng (có thể không có).
 *   Thực tế nên truyền mã menu hợp lệ.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với tất cả các cột của bảng sysCalcInfo.
 *   Cấu trúc bảng có thể bao gồm:
 *   - MenuID (string): Mã menu.
 *   - CalcID (string): Mã tính toán.
 *   - CalcName (string): Tên tính toán.
 *   - Formula (string): Công thức.
 *   - Description (string): Mô tả.
 *   - Các cột khác tùy thiết kế.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT a.* FROM sysCalcInfo a WHERE a.MenuID = @pMenuID.
 * 2. Không có ORDER BY.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCalcInfo::call([
 *     'pMenuID' => 'CO',
 * ]);
 * // Hoặc không truyền tham số (sẽ dùng mặc định rỗng, có thể không trả về bản ghi nào):
 * $rows = AsGetCalcInfo::call([]);
 * foreach ($rows as $row) {
 *     echo "MenuID: {$row->MenuID}, CalcID: {$row->CalcID}, Tên: {$row->CalcName}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số tùy chọn, mặc định là chuỗi rỗng. Nên truyền mã menu cụ thể để lấy thông tin tính toán liên quan đến menu đó.
 * - Bảng sysCalcInfo lưu cấu hình các phép tính, công thức cho từng menu (ví dụ tính giá vốn, tính khấu hao...).
 * - Nếu muốn lấy tất cả bản ghi (không lọc theo MenuID), cần sửa stored procedure (thêm điều kiện OR @pMenuID = ''), nhưng hiện tại không có.
 */
class AsGetCalcInfo
{
    /**
     * Gọi stored procedure asGetCalcInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCalcInfo', $params);
    }
}