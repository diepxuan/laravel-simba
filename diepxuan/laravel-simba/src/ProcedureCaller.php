<?php

namespace Diepxuan\LaravelSimba;

use Illuminate\Support\Facades\DB;

/**
 * Class ProcedureCaller
 *
 * Cung cấp phương thức tĩnh để gọi stored procedures của Simba SQL Server.
 * Sử dụng Laravel DB facade để thực thi câu lệnh SQL.
 */
class ProcedureCaller
{
    /**
     * Gọi stored procedure với các tham số.
     *
     * @param string $procedureName Tên stored procedure (không bao gồm schema, mặc định dbo).
     * @param array $params Mảng tham số với khóa là tên tham số (có hoặc không có tiền tố '@').
     * @return mixed Kết quả trả về từ procedure (tùy thuộc vào procedure).
     */
    public static function call(string $procedureName, array $params = [])
    {
        // Xây dựng câu lệnh EXEC với các tham số
        $paramStrings = [];
        foreach ($params as $key => $value) {
            // Loại bỏ tiền tố '@' nếu có trong khóa
            $paramName = ltrim($key, '@');
            $paramStrings[] = "@{$paramName} = ?";
        }

        $sql = "EXEC dbo.{$procedureName} " . implode(', ', $paramStrings);

        // Lấy giá trị của các tham số theo thứ tự
        $bindings = array_values($params);

        // Thực thi stored procedure
        return DB::select($sql, $bindings);
    }
}