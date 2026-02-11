<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelDictionaryResx
 *
 * Stored procedure: asDelDictionaryResx
 * Mục đích: Xóa một bản dịch (resource) từ bảng sysDictionaryResx dựa trên mã code_name và ngôn ngữ.
 * Procedure thực hiện DELETE từ bảng sysDictionaryResx với điều kiện khớp Code_name và Language.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Mã code cần xóa (NVARCHAR(50)).
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ (ví dụ: 'vi', 'en') (NVARCHAR(5)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR). Ghi chú comment gốc: 0: được xóa, 1 - không xóa (nhưng thực tế gán @@error).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysDictionaryResx WHERE Code_name = @pCode_name AND Language = @pLanguage
 * - SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelDictionaryResx::call([
 *     'pCode_name' => 'DICT001',
 *     'pLanguage' => 'en',
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
 * - Tham số @pCode_name và @pLanguage bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột Code_name và Language.
 * - Bảng sysDictionaryResx lưu các bản dịch (resource) cho từ điển đa ngôn ngữ.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelDictionaryResx
{
    /**
     * Gọi stored procedure asDelDictionaryResx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelDictionaryResx', $params);
    }
}