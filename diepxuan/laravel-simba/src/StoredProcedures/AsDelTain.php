<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelTain
 *
 * Stored procedure: asDelTain
 * Mục đích: Xóa một bản ghi nhập kho (TAIN) dựa trên mã công ty và số chứng từ.
 * Procedure thực hiện DELETE từ bảng TAIN với điều kiện khớp Ma_cty và Stt_rec, sử dụng khối TRY CATCH để xử lý lỗi.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 * - @pStt_rec (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công (không có lỗi), giá trị lỗi SQL Server nếu có lỗi (@@ERROR) trong khối CATCH.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - BEGIN TRY
 *   - DELETE FROM TAIN WHERE Ma_cty = @pMa_cty AND Stt_rec = @pStt_rec
 *   - SET @pRet = 0
 * - END TRY
 * - BEGIN CATCH
 *   - SET @pRet = @@error
 * - END CATCH
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelTain::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'IN202500001',
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
 * - Tham số @pMa_cty và @pStt_rec bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột Ma_cty và Stt_rec.
 * - Bảng TAIN lưu thông tin nhập kho (có thể là phiếu nhập kho, nhập vật tư...).
 * - Khối TRY CATCH giúp bắt lỗi và trả về mã lỗi thay vì rollback transaction (nếu có).
 * - Giá trị @pRet = 0 khi thành công, khác 0 khi có lỗi.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelTain
{
    /**
     * Gọi stored procedure asDelTain
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelTain', $params);
    }
}