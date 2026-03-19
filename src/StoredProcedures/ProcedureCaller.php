<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-27 22:02:42
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
     */
    public static function call(string $name, array $params = [], ?string $connection = null)
    {
        $declareSql = [];
        $execParts  = [];
        $bindings   = [];
        $selectOut  = [];
        $hasOutput  = false;

        foreach ($params as $key => $value) {
            // Nếu là OUTPUT param
            if (\is_array($value) && ($value['output'] ?? false)) {
                $type = $value['type'] ?? 'INT';
                $hasOutput = true;

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
        }
        
        $conn = $connection ? DB::connection($connection) : DB::connection();
        
        // Dùng select() để execute toàn bộ batch và fetch kết quả
        $rows = $conn->select($sql, $bindings);

        \Debugbar::info('ProcedureCaller result:', $rows);

        return collect($rows);
    }
}
