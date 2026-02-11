<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllMenus
 *
 * Stored procedure: asGetAllMenus
 * Mục đích: Lấy danh sách đầy đủ các menu hệ thống với hỗ trợ đa ngôn ngữ.
 * Procedure trả về thông tin menu từ bảng sysmenu, kết hợp với bản dịch sysmenuResx theo ngôn ngữ chỉ định.
 * Các menu được sắp xếp theo stt và menuid.
 * 
 * Tham số:
 * - @pLanguage (string, tùy chọn): Mã ngôn ngữ (định dạng NVARCHAR(5), ví dụ 'vi-VN', 'en-US').
 *   Giá trị mặc định: 'vi-VN'
 *   Nếu không cung cấp, sẽ dùng tiếng Việt.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - stt (int?): Số thứ tự sắp xếp menu.
 *   - moduleid (string): Mã module (ví dụ 'CO', 'FA').
 *   - bar (string): Tên hiển thị của menu (ưu tiên bản dịch nếu có).
 *   - short_name (string): Tên ngắn của menu.
 *   - menuid (string): Mã menu (khóa).
 *   - dllName (string): Tên DLL chứa form.
 *   - command (string): Lệnh thực thi.
 *   - code_name (string): Tên mã (dùng trong code).
 *   - report (string?): Báo cáo liên kết.
 *   - basicright (string?): Quyền cơ bản.
 *   - form (string?): Tên form.
 *   - opt (string?): Tùy chọn.
 *   - par1 đến par8 (string?): Tham số bổ sung 1-8.
 *   - picture1 (string?): Đường dẫn hình ảnh 1.
 *   - picture2 (string?): Đường dẫn hình ảnh 2.
 *   - rowid (int?): ID dòng (có thể identity).
 *   - developer (string?): Người phát triển.
 *   - maintainer (string?): Người bảo trì.
 *   - used (bit?): Cờ sử dụng.
 *   - active (bit?): Cờ hoạt động.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. LEFT JOIN sysmenu a (bảng chính) với sysmenuResx b trên điều kiện a.menuid = b.menuid và b.language = @pLanguage.
 * 2. Sử dụng ISNULL(b.bar, a.bar) để ưu tiên giá trị dịch (b.bar) nếu có, nếu không dùng giá trị gốc (a.bar).
 * 3. ORDER BY stt, a.menuid (sắp xếp theo số thứ tự, sau đó theo mã menu).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllMenus::call([
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc sử dụng giá trị mặc định:
 * $rows = AsGetAllMenus::call([]);
 * foreach ($rows as $row) {
 *     echo "Menu ID: {$row->menuid}, Tên: {$row->bar}, Module: {$row->moduleid}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Ngôn ngữ mặc định là 'vi-VN'. Nếu muốn lấy bản dịch cho ngôn ngữ khác, cần đảm bảo bảng sysmenuResx có dữ liệu tương ứng.
 * - Chỉ trả về tất cả menu, không lọc theo active hay used. Nếu muốn chỉ menu đang hoạt động, cần lọc thêm ở ứng dụng.
 * - Cột bar là tên hiển thị, có thể được dịch.
 */
class AsGetAllMenus
{
    /**
     * Gọi stored procedure asGetAllMenus
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllMenus', $params);
    }
}