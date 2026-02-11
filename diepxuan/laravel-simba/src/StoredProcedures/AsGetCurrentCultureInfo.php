<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCurrentCultureInfo
 *
 * Stored procedure: asGetCurrentCultureInfo
 * Mục đích: Lấy ngôn ngữ hiện tại được chọn (selected = '1') từ bảng sysLanguage.
 * Procedure trả về tên ngôn ngữ (cột Name) của ngôn ngữ được đánh dấu là đang chọn (có thể dùng làm ngôn ngữ mặc định của hệ thống).
 * 
 * Tham số:
 * - Không có tham số.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với một cột:
 *   - Name (string): Tên ngôn ngữ được chọn (ví dụ: 'vi-VN').
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT TOP 1 [Name] FROM [sysLanguage] WHERE selected = '1'.
 * 2. Nếu có nhiều ngôn ngữ được chọn, chỉ lấy bản ghi đầu tiên (theo thứ tự không xác định).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCurrentCultureInfo::call();
 * // Hoặc
 * $rows = AsGetCurrentCultureInfo::call([]);
 * if (!empty($rows)) {
 *     $currentLanguage = $rows[0]->Name;
 *     echo "Ngôn ngữ hiện tại: {$currentLanguage}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Chỉ trả về một bản ghi (TOP 1). Nếu không có ngôn ngữ nào được chọn, resultset rỗng.
 * - Cột selected = '1' là cờ đánh dấu ngôn ngữ được chọn (có thể do người dùng chọn hoặc mặc định).
 * - Không có ORDER BY, nếu có nhiều ngôn ngữ selected, bản ghi nào được trả về là không xác định.
 */
class AsGetCurrentCultureInfo
{
    /**
     * Gọi stored procedure asGetCurrentCultureInfo
     *
     * @param array $params Mảng tham số (không cần thiết).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCurrentCultureInfo', $params);
    }
}