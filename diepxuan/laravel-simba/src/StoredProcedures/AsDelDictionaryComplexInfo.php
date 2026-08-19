<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelDictionaryComplexInfo
 *
 * Stored procedure: asDelDictionaryComplexInfo
 * Mục đích: Xóa một bản ghi từ bảng sysDictionaryComplexInfo dựa trên mã code_name.
 * Procedure thực hiện DELETE từ bảng sysDictionaryComplexInfo với điều kiện khớp Code_name.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Mã code cần xóa (NVARCHAR(50)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR). Ghi chú comment gốc: 0: được xóa, 1 - không xóa (nhưng thực tế gán @@error).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysDictionaryComplexInfo WHERE Code_name = @pCode_name
 * - SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelDictionaryComplexInfo::call([
 *     'pCode_name' => 'COMPLEX001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, có lỗi SQL
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pCode_name bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột Code_name.
 * - Bảng sysDictionaryComplexInfo lưu thông tin từ điển phức tạp (có thể là danh mục nhiều cấp, cấu trúc phức tạp).
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelDictionaryComplexInfo
{
    /**
     * Gọi stored procedure asDelDictionaryComplexInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelDictionaryComplexInfo', $params);
    }
}