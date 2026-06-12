<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdSysVar
 *
 * Stored procedure: asUpdSysVar
 * Mục đích: Cập nhật dữ liệu của bảng phân hệ + 'setup'.
 * Procedure này cập nhật giá trị của một trường cụ thể trong bảng cấu hình (setup) của phân hệ.
 * Bảng động được xác định bởi tên phân hệ (pPhan_he) thêm chuỗi 'setup'.
 * Giá trị được chuyển đổi kiểu dữ liệu phù hợp với cột đích.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pPhan_he (string, bắt buộc): Mã phân hệ (NVARCHAR(2)). Ví dụ: 'AR', 'AP', 'CA', ...
 * - @pFieldName (string, bắt buộc): Tên trường cần cập nhật (NVARCHAR(100)).
 * - @pValue (sql_variant, bắt buộc): Giá trị mới (có thể là bất kỳ kiểu dữ liệu nào).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, nhưng thực thi câu lệnh UPDATE động.
 * - Không có output parameter, kết quả thực thi có thể kiểm tra qua số dòng ảnh hưởng.
 * 
 * Logic chi tiết:
 * - Xác định tên bảng: @tblName = @pPhan_he + 'setup'
 * - Truy vấn information_schema.columns để lấy kiểu dữ liệu, độ dài, precision, scale của cột @pFieldName.
 * - Xây dựng câu lệnh SQL động: UPDATE @tblName SET @pFieldName = CAST(@Value AS <datatype>) WHERE ma_cty = @pMa_cty
 * - Thực thi bằng sp_executesql với tham số @Value.
 * - In ra câu lệnh SQL và tên bảng (có thể cho mục đích debug).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdSysVar::call([
 *     'pMa_cty' => '001',
 *     'pPhan_he' => 'AR',
 *     'pFieldName' => 'CurPeriod',
 *     'pValue' => 202401,
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Tham số @pValue là sql_variant, có thể truyền giá trị kiểu số, chuỗi, ngày tháng.
 * - Kiểu dữ liệu sẽ được ép kiểu cho phù hợp với cột đích; nếu không tương thích sẽ gây lỗi.
 * - Điều kiện WHERE chỉ dựa trên mã công ty (ma_cty). Nếu bảng có khóa phức hợp, cần đảm bảo chỉ cập nhật một dòng.
 * - Procedure có lệnh SELECT @sql, @tblName ở cuối, có thể trả về resultset với thông tin debug.
 * - Nên kiểm tra kết quả thực thi qua số dòng bị ảnh hưởng (affected rows).
 */
class AsUpdSysVar
{
    /**
     * Gọi stored procedure asUpdSysVar
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa resultset debug).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asUpdSysVar', $params);
    }
}