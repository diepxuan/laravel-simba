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

        foreach ($params as $key => $value) {
            // Nếu là OUTPUT param
            if (\is_array($value) && ($value['output'] ?? false)) {
                $type = $value['type'] ?? 'INT';

                $declareSql[] = "DECLARE @{$key} {$type}";
                $execParts[]  = "@{$key} = @{$key} OUTPUT";
                $selectOut[]  = "@{$key} as {$key}";
            } else {
                $execParts[]    = "@{$key} = :{$key}";
                $bindings[$key] = $value;
            }
        }
        $sql = '';
        if (!empty($declareSql)) {
            $sql .= implode(";\n", $declareSql) . ";\n";
        }
        $sql .= "EXEC {$name}\n    " . implode(",\n    ", $execParts);
        if (!empty($selectOut)) {
            $sql .= ";\nSELECT " . implode(', ', $selectOut);
        }
        $conn = $connection ? DB::connection($connection) : DB::connection();
        $rows = $conn->select($sql, $bindings);

        return collect($rows);
        // Lấy giá trị của các tham số theo thứ tự
        // $bindings = array_values($params);

        // Thực thi stored procedure
        // return DB::select($sql, $bindings);
    }
}
