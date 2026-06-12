<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelOptFieldSetup
 *
 * Stored procedure: asDelOptFieldSetup
 * Mục đích: Xóa một thiết lập trường tùy chọn (optional field) từ bảng sysOptFieldSetup dựa trên mã chứng từ và tên trường.
 * Procedure thực hiện DELETE từ bảng sysOptFieldSetup với điều kiện khớp Voucher_code và Field.
 * 
 * Tham số:
 * - @pVoucher_code (string, bắt buộc): Mã chứng từ (NVARCHAR(3)).
 * - @pField (string, bắt buộc): Tên trường (NVARCHAR(10)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysOptFieldSetup WHERE Voucher_code = @pVoucher_code AND Field = @pField
 * - SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelOptFieldSetup::call([
 *     'pVoucher_code' => 'PC',
 *     'pField' => 'OPT1',
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
 * - Tham số @pVoucher_code và @pField bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột Voucher_code và Field.
 * - Bảng sysOptFieldSetup lưu thiết lập các trường tùy chọn cho từng loại chứng từ (có thể là các trường mở rộng do người dùng định nghĩa).
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelOptFieldSetup
{
    /**
     * Gọi stored procedure asDelOptFieldSetup
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelOptFieldSetup', $params);
    }
}