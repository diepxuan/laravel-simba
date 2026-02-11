<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelcolk
 *
 * Stored procedure: asDelcolk
 * Mục đích: Xóa một bản ghi từ bảng colk (có thể là chi phí lũy kế) dựa trên mã công ty, tháng, năm, mã sản phẩm công trình và tài khoản.
 * Procedure thực hiện DELETE từ bảng colk với điều kiện khớp Ma_cty, Thang, Nam, Ma_spct và Tk.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 * - @pThang (int, bắt buộc): Tháng (INT).
 * - @pNam (int, bắt buộc): Năm (INT).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (nvarchar(20)).
 * - @pTk (string, bắt buộc): Tài khoản (nvarchar(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM colk WHERE Ma_cty = @pMa_cty AND Thang = @pThang AND Nam = @pNam AND Ma_spct = @pMa_spct AND Tk = @pTk
 * - SET @pRet = @@error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelcolk::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
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
 * - Điều kiện xóa khớp chính xác trên năm cột.
 * - Bảng colk có thể lưu chi phí lũy kế (cumulative cost) cho từng công trình/sản phẩm theo thời gian.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelcolk
{
    /**
     * Gọi stored procedure asDelcolk
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelcolk', $params);
    }
}