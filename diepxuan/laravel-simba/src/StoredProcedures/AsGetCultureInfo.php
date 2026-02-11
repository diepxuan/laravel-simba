<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCultureInfo
 *
 * Stored procedure: asGetCultureInfo
 * Mục đích: Lấy danh sách ngôn ngữ (culture) từ bảng [Language], loại bỏ trùng lặp.
 * Procedure trả về tên ngôn ngữ và mô tả, thường dùng để lấy danh sách ngôn ngữ hỗ trợ trong hệ thống.
 * 
 * Tham số:
 * - Không có tham số.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - Name (string): Tên ngôn ngữ (ví dụ: 'vi-VN', 'en-US').
 *   - Description (string): Mô tả ngôn ngữ (ví dụ: 'Vietnamese', 'English').
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT DISTINCT [Name], [Description] FROM [Language].
 * 2. Không có ORDER BY (thứ tự không xác định).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCultureInfo::call();
 * // Hoặc
 * $rows = AsGetCultureInfo::call([]);
 * foreach ($rows as $row) {
 *     echo "Ngôn ngữ: {$row->Name}, Mô tả: {$row->Description}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Sử dụng DISTINCT để loại bỏ các bản ghi trùng lặp (nếu bảng Language có nhiều bản ghi cùng Name, Description).
 * - Không lọc theo trạng thái ksd (khác với asGetAllLanguage). Bảng [Language] có thể chứa tất cả ngôn ngữ được cài đặt, không chỉ ngôn ngữ đang dùng.
 * - Thứ tự kết quả không được đảm bảo, nếu cần sắp xếp phải tự sắp ở ứng dụng.
 */
class AsGetCultureInfo
{
    /**
     * Gọi stored procedure asGetCultureInfo
     *
     * @param array $params Mảng tham số (không cần thiết).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCultureInfo', $params);
    }
}