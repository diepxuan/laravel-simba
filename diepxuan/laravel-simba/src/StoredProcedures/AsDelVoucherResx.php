<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelVoucherResx
 *
 * Stored procedure: asDelVoucherResx
 * Mục đích: Xóa một bản dịch (resource) từ bảng sysVoucherResx dựa trên mã chứng từ và ngôn ngữ.
 * Procedure thực hiện DELETE từ bảng sysVoucherResx với điều kiện khớp Voucher_code và Language.
 * 
 * Tham số:
 * - @pVoucher_code (string, bắt buộc): Mã chứng từ (NVARCHAR(50)).
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ (ví dụ: 'vi', 'en') (NVARCHAR(5)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysVoucherResx WHERE Voucher_code = @pVoucher_code AND Language = @pLanguage
 * - SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelVoucherResx::call([
 *     'pVoucher_code' => 'PC',
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
 * - Tham số @pVoucher_code và @pLanguage bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột Voucher_code và Language.
 * - Bảng sysVoucherResx lưu các bản dịch (resource) cho thông tin chứng từ đa ngôn ngữ.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelVoucherResx
{
    /**
     * Gọi stored procedure asDelVoucherResx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelVoucherResx', $params);
    }
}