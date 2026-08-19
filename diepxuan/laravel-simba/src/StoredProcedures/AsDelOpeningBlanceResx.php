<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelOpeningBlanceResx
 *
 * Stored procedure: asDelOpeningBlanceResx
 * Mục đích: Xóa một bản dịch (resource) từ bảng sysOpeningBalanceResx dựa trên mã code_name và ngôn ngữ, sau khi kiểm tra điều kiện tồn tại (hàm afExistMaeningBlanc).
 * Procedure thực hiện kiểm tra: nếu hàm dbo.afExistMaeningBlanc(@pCode_name) trả về 1 thì không xóa và trả về @pRet = 1; ngược lại thực hiện DELETE và trả về @pRet = 0.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Mã code cần xóa (NVARCHAR(50)).
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ (ví dụ: 'vi', 'en') (NVARCHAR(5)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu xóa thành công, 1 nếu không được xóa (do điều kiện hàm afExistMaeningBlanc trả về 1).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để biết kết quả.
 * 
 * Logic chi tiết:
 * - IF dbo.afExistMaeningBlanc(@pCode_name) = 1 SET @pRet = 1
 * - ELSE DELETE FROM sysOpeningBalanceResx WHERE Code_name = @pCode_name AND Language = @pLanguage; SET @pRet = 0
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelOpeningBlanceResx::call([
 *     'pCode_name' => 'OB001',
 *     'pLanguage' => 'en',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } elseif ($ret === 1) {
 *     // Không được xóa do điều kiện afExistMaeningBlanc trả về 1 (có thể mã đang được sử dụng)
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pCode_name và @pLanguage bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa phụ thuộc vào hàm afExistMaeningBlanc (có thể kiểm tra mã có đang được sử dụng không).
 * - Bảng sysOpeningBalanceResx lưu các bản dịch (resource) cho số dư đầu kỳ đa ngôn ngữ.
 * - Giá trị @pRet chỉ là 0 hoặc 1, không phải @@error.
 * - Tên procedure có lỗi chính tả "Blance" (đúng ra là "Balance") nhưng phải giữ nguyên.
 */
class AsDelOpeningBlanceResx
{
    /**
     * Gọi stored procedure asDelOpeningBlanceResx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelOpeningBlanceResx', $params);
    }
}