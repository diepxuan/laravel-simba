<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllLanguage
 *
 * Stored procedure: asGetAllLanguage
 * Mục đích: Lấy danh sách ngôn ngữ đang được sử dụng (có cờ ksd = 1) từ bảng sysLanguage.
 * Procedure trả về tên ngôn ngữ và mô tả, sắp xếp theo tên.
 * 
 * Tham số:
 * - Không có tham số.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - Name (string): Tên ngôn ngữ (ví dụ: 'vi-VN', 'en-US').
 *   - Description (string): Mô tả ngôn ngữ (ví dụ: 'Tiếng Việt', 'English').
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT l.Name, l.[Description] FROM [sysLanguage] l
 * 2. WHERE l.ksd = 1 (chỉ ngôn ngữ đang sử dụng).
 * 3. ORDER BY l.Name (sắp xếp theo tên ngôn ngữ).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllLanguage::call();
 * // Hoặc
 * $rows = AsGetAllLanguage::call([]);
 * foreach ($rows as $row) {
 *     echo "Ngôn ngữ: {$row->Name}, Mô tả: {$row->Description}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Chỉ trả về các ngôn ngữ có cờ ksd = 1 (đang kích hoạt).
 * - Bảng sysLanguage có thể chứa các ngôn ngữ được hỗ trợ trong hệ thống, dùng cho đa ngôn ngữ giao diện và dữ liệu.
 * - Tên cột [Description] được đặt trong dấu ngoặc vuông vì là từ khóa của SQL.
 */
class AsGetAllLanguage
{
    /**
     * Gọi stored procedure asGetAllLanguage
     *
     * @param array $params Mảng tham số (không cần thiết).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllLanguage', $params);
    }
}