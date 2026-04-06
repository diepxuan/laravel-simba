<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 23:16:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class ProcedureCaller.
 *
 * Cung cấp phương thức tĩnh để gọi stored procedures của Simba SQL Server.
 * Sử dụng Laravel DB facade để thực thi câu lệnh SQL.
 */
class ProcedureCaller
{
    /**
     * Gọi stored procedure với các tham số và return results as a Collection.
     *
     * @param array       $params     mảng tham số với khóa là tên tham số (có hoặc không có tiền tố '@')
     * @param null|string $connection Optional connection name
     *
     * @return mixed kết quả trả về từ procedure (tùy thuộc vào procedure)
     *
     * @note TỰ ĐỘNG CAST string parameters thành NVARCHAR để hỗ trợ tiếng Việt có dấu
     *       Vấn đề: PDO SQLSRV không tự động thêm N'...' prefix cho parameter binding
     *       Giải pháp: CAST(? AS NVARCHAR(500)) để đảm bảo encoding đúng
     *       Tham khảo: docs/SQLSRV-UTF8-ROOT-CAUSE.md
     */
    public static function call(string $name, array $params = [], ?string $connection = null)
    {
        $declareSql  = [];
        $execParts   = [];
        $bindings    = [];
        $selectOut   = [];
        $hasOutput   = false;
        $outputTypes = [];

        \Debugbar::info("ProcedureCaller {$name} params: ", $params);

        foreach ($params as $key => $value) {
            // Nếu là OUTPUT param
            if (\is_array($value) && ($value['output'] ?? false)) {
                $type              = $value['type'] ?? 'INT';
                $hasOutput         = true;
                $outputTypes[$key] = strtoupper($type);

                $declareSql[] = "DECLARE @{$key} {$type}";
                $execParts[]  = "@{$key} = @{$key} OUTPUT";
                $selectOut[]  = "@{$key} as {$key}";
            } else {
                // FIX UTF-8: Cast string parameters thành NVARCHAR để hỗ trợ tiếng Việt
                // Nguyên nhân: PDO SQLSRV không tự động thêm N'...' prefix cho parameter binding
                // Khi không có N'...', SQL Server treat parameter như VARCHAR → mất dấu tiếng Việt
                //
                // LƯU Ý: Chỉ CAST khi value là string thuần (không phải date, numeric, null)
                // Date/datetime/numeric đã được PDO xử lý đúng kiểu
                if (\is_string($value) && !empty($value) && !self::isDateOrDatetime($value)) {
                    // String thuần → CAST thành NVARCHAR để giữ dấu tiếng Việt
                    $execParts[] = "@{$key} = CAST(:{$key} AS NVARCHAR(500))";
                } else {
                    // Null, int, float, bool, date, datetime, empty string → không CAST
                    $execParts[] = "@{$key} = :{$key}";
                }
                $bindings[$key] = $value;
            }
        }
        $sql = '';
        // Thêm SET NOCOUNT ON để tránh multiple result sets từ procedure
        $sql .= "SET NOCOUNT ON;\n";
        if (!empty($declareSql)) {
            $sql .= implode(";\n", $declareSql) . ";\n";
        }
        $sql .= "EXEC {$name}\n    " . implode(",\n    ", $execParts);

        // Thêm SELECT để fetch output values (phải cùng batch với DECLARE)
        if (!empty($selectOut)) {
            $sql .= ";\nSELECT " . implode(', ', $selectOut);
        } else {
            // Thêm dummy SELECT để tránh lỗi "The active result for the query contains no fields"
            // khi stored procedure không trả về result set
            $sql .= ";\nSELECT 1 AS [dummy]";
        }

        $conn = $connection ? DB::connection($connection) : DB::connection();

        // Dùng select() để execute toàn bộ batch và fetch kết quả
        $rows = $conn->select($sql, $bindings);

        // Tự động ép kiểu các giá trị output trả về dựa trên type đã khai báo
        if ($hasOutput && !empty($rows)) {
            foreach ($rows as $row) {
                foreach ($outputTypes as $col => $type) {
                    if (property_exists($row, $col)) {
                        if (str_contains($type, 'INT')) {
                            $row->{$col} = (int) $row->{$col};
                        } elseif (str_contains($type, 'DECIMAL') || str_contains($type, 'FLOAT') || str_contains($type, 'NUMERIC')) {
                            $row->{$col} = (float) $row->{$col};
                        }
                    }
                }
            }
        }

        \Debugbar::info('ProcedureCaller result:', $rows);

        return collect($rows);
    }

    /**
     * Kiểm tra xem value có phải là date/datetime format không.
     */
    private static function isDateOrDatetime(string $value): bool
    {
        // Check các format date/datetime phổ biến
        // YYYY-MM-DD, YYYY-MM-DD HH:MM:SS, DD/MM/YYYY, v.v.
        $datePatterns = [
            '/^\d{4}-\d{2}-\d{2}$/',                    // 2026-04-06
            '/^\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}$/',  // 2026-04-06 12:30:45
            '/^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}$/',  // 2026-04-06T12:30:45 (ISO 8601)
            '/^\d{2}\/\d{2}\/\d{4}$/',                  // 06/04/2026
            '/^\d{2}-\d{2}-\d{4}$/',                    // 06-04-2026
        ];

        foreach ($datePatterns as $pattern) {
            if (preg_match($pattern, $value)) {
                return true;
            }
        }

        return false;
    }
}
