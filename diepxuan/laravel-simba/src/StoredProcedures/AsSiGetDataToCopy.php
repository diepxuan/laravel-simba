<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSiGetDataToCopy
 *
 * Stored procedure: asSiGetDataToCopy
 * Mục đích: Lấy thông tin dữ liệu từ một bảng cụ thể với điều kiện lọc, phục vụ cho việc copy dữ liệu.
 * Procedure thực hiện:
 *   1. Xây dựng câu truy vấn động: SELECT * FROM @pTable_name WHERE @pWhere AND ma_cty = @pMa_Cty.
 *   2. In câu truy vấn ra log (print).
 *   3. Thực thi câu truy vấn và trả về kết quả.
 * Dùng để kiểm tra dữ liệu trước khi copy hoặc lấy dữ liệu để xử lý tiếp.
 * 
 * Tham số:
 * - @pMa_Cty (string, bắt buộc): Mã công ty (3 ký tự). Điều kiện bắt buộc trên cột ma_cty.
 * - @pTable_name (string, optional, mặc định ''): Tên bảng cần lấy dữ liệu. Nếu để trống, câu truy vấn sẽ bị lỗi vì thiếu tên bảng.
 * - @pWhere (string, bắt buộc): Điều kiện WHERE (không bao gồm từ khóa WHERE). Sẽ được nối trực tiếp vào câu truy vấn.
 * 
 * Giá trị trả về:
 * - Procedure trả về resultset của câu SELECT * từ bảng chỉ định.
 * - Kết quả là tập các bản ghi thỏa mãn điều kiện.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSiGetDataToCopy::call([
 *     'pMa_Cty' => '001',
 *     'pTable_name' => 'APCT',
 *     'pWhere' => "ngay_ct >= '2025-01-01'",
 * ]);
 * // $result sẽ chứa các dòng dữ liệu từ bảng APCT có mã công ty 001 và ngay_ct >= '2025-01-01'.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng dynamic SQL với sp_executesql, nối trực tiếp tham số @pWhere vào câu truy vấn mà không có validation, có nguy cơ SQL injection. Chỉ sử dụng với @pWhere từ nguồn tin cậy.
 * - Tham số @pTable_name có giá trị mặc định là chuỗi rỗng, nếu không truyền hoặc truyền rỗng sẽ gây lỗi cú pháp SQL.
 * - Điều kiện ma_cty được thêm tự động sau @pWhere, cần đảm bảo @pWhere không chứa mệnh đề ma_cty trùng lặp.
 * - Câu truy vấn được in ra console qua PRINT, có thể xem trong log SQL Server.
 */
class AsSiGetDataToCopy
{
    /**
     * Gọi stored procedure asSiGetDataToCopy
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (resultset của SELECT).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSiGetDataToCopy', $params);
    }
}