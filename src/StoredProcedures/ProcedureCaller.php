<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-07 13:49:23
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
     *
     * @note UTF-8 Support: Build trực tiếp Unicode literals (N'...') vào SQL
     *       Tránh lỗi partial match khi replace placeholders
     *       Tham khảo: docs/SQLSRV-UTF8-ROOT-CAUSE.md
     */
    public static function call(string $name, array $params = [], ?string $connection = null)
    {
        $declareSql  = [];
        $execParts   = [];
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
                // INPUT param - Build trực tiếp Unicode literal vào SQL (không dùng placeholder)
                $literal     = self::toUnicodeLiteral($value);
                $execParts[] = "@{$key} = {$literal}";
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

        // Execute trực tiếp (không cần bindings vì đã build Unicode literal vào SQL)
        $rows = $conn->select($sql);

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
     * Build trực tiếp vào SQL, không qua parameter binding.
     *
     * @param mixed $value Giá trị cần convert
     *
     * @return string Unicode literal (N'...' cho strings, NULL cho null, v.v.)
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
}
