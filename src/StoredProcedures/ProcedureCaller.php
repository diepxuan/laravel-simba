<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-07 12:39:39
 */

namespace Diepxuan\Simba\StoredProcedures;

use Illuminate\Support\Collection;
use Illuminate\Support\Facades\DB;

/**
 * Class ProcedureCaller.
 *
 * Cung cấp phương thức tĩnh để gọi stored procedures của Simba SQL Server.
 * Sử dụng Laravel DB facade để thực thi câu lệnh SQL.
 *
 * @note FIX UTF-8: Tự động CAST string parameters thành NVARCHAR để hỗ trợ tiếng Việt có dấu
 *       Vấn đề: PDO SQLSRV không tự động thêm N'...' prefix cho parameter binding
 *       Giải pháp: Dùng positional parameters (?) với CAST thay vì named parameters (:)
 *       Tham khảo: docs/SQLSRV-UTF8-ROOT-CAUSE.md
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
                $execParts[]    = "@{$key} = :{$key}";
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
        if (empty($bindings)) {
            $rows = $conn->select($sql);
        } else {
            // Replace ? với Unicode literal
            $processedQuery = self::replacePlaceholders($sql, $bindings);
            $rows           = $conn->select($processedQuery);
        }

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
     * Escape single quote cho SQL Server.
     */
    public static function escape(string $value): string
    {
        return str_replace("'", "''", $value);
    }

    /**
     * Chuyển giá trị sang dạng Unicode literal (N'...')
     * Dùng cho parameter binding bị lỗi UTF-8.
     */
    public static function toUnicodeLiteral(mixed $value): string
    {
        if (null === $value) {
            return 'NULL';
        }

        if (\is_bool($value)) {
            return $value ? '1' : '0';
        }

        if (\is_int($value) || \is_float($value)) {
            return (string) $value;
        }

        if ($value instanceof \DateTimeInterface) {
            return "N'" . self::escape($value->format('Y-m-d H:i:s')) . "'";
        }

        return "N'" . self::escape((string) $value) . "'";
    }

    /**
     * Replace ? placeholders với Unicode literals.
     */
    private static function replacePlaceholders(string $query, array $bindings): string
    {
        $count = 0;

        return preg_replace_callback('/\?/', static function () use ($bindings, &$count) {
            $value = $bindings[$count] ?? null;
            ++$count;

            return self::toUnicodeLiteral($value);
        }, $query);
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
