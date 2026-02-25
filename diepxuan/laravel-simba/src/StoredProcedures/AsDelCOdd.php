<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelCOdd
 *
 * Stored procedure: asDelCOdd
 * Mục đích: Xóa bản ghi chi phí dở dang (codd) theo mã công ty, năm, tháng, mã sản phẩm công trình và tài khoản.
 * Procedure thực hiện DELETE từ bảng codd với điều kiện khớp chính xác các tham số.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 * - @pNam (int, bắt buộc): Năm (INT).
 * - @pThang (int, bắt buộc): Tháng (INT).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (nvarchar(20)).
 * - @pTK (string, bắt buộc): Tài khoản (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công (không có lỗi), giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * 1. DELETE FROM codd WHERE Ma_cty = @pMa_cty AND Nam = @pNam AND Thang = @pThang AND Ma_spct = @pMa_spct AND tk = @pTK
 * 2. SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelCOdd::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pThang' => 2,
 *     'pMa_spct' => 'SPCT001',
 *     'pTk' => '154',
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
 * - Tất cả tham số đầu vào đều bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên tất cả cột.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelCOdd
{
    /**
     * Gọi stored procedure asDelCOdd
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelCOdd', $params);
    }
}