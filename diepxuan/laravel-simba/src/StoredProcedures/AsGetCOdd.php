<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCOdd
 *
 * Stored procedure: asGetCOdd
 * Mục đích: Lấy dữ liệu dở dang (codd) theo công ty, năm, tháng, mã sản phẩm công trình và tài khoản.
 * Procedure trả về các bản ghi từ bảng codd (chi phí dở dang) với điều kiện tìm kiếm mờ (LIKE).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)). Không có giá trị mặc định.
 * - @pNam (int, bắt buộc): Năm. Không có giá trị mặc định.
 * - @pThang (int, bắt buộc): Tháng. Không có giá trị mặc định.
 * - @pMa_spct (string, tùy chọn): Mã sản phẩm công trình (nvarchar(20)).
 *   Giá trị mặc định: '' (chuỗi rỗng). Khi truyền rỗng, điều kiện LIKE '%' sẽ lấy tất cả.
 * - @pTk (string, tùy chọn): Tài khoản (nvarchar(20)).
 *   Giá trị mặc định: '' (chuỗi rỗng). Khi truyền rỗng, điều kiện LIKE '%' sẽ lấy tất cả.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - nam (int): Năm.
 *   - thang (int): Tháng.
 *   - tk (string): Tài khoản.
 *   - ma_spct (string): Mã sản phẩm công trình.
 *   - sl_dd_ck (decimal?): Số lượng dở dang cuối kỳ.
 *   - gt_dd_ck (decimal?): Giá trị dở dang cuối kỳ.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT các cột từ bảng codd.
 * 2. WHERE với các điều kiện LIKE:
 *    - Ma_cty LIKE @pMa_cty + '%' (tìm theo prefix mã công ty).
 *    - Nam LIKE @pNam (so sánh chính xác, nhưng dùng LIKE với số, tương đương =).
 *    - Thang LIKE @pThang (tương tự).
 *    - Ma_spct LIKE @pMa_spct + '%' (tìm theo prefix mã sản phẩm công trình).
 *    - tk LIKE @pTk + '%' (tìm theo prefix tài khoản).
 * 3. Không có ORDER BY.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCOdd::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2023,
 *     'pThang' => 10,
 *     'pMa_spct' => 'SPCT001',
 *     'pTk' => '154',
 * ]);
 * // Hoặc chỉ truyền các tham số bắt buộc, các tham số tùy chọn để mặc định rỗng:
 * $rows = AsGetCOdd::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2023,
 *     'pThang' => 10,
 * ]);
 * foreach ($rows as $row) {
 *     echo "Công ty: {$row->ma_cty}, Năm tháng: {$row->nam}/{$row->thang}, TK: {$row->tk}, Mã SPCT: {$row->ma_spct}, Giá trị dở dang: {$row->gt_dd_ck}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Ba tham số đầu bắt buộc, không có giá trị mặc định.
 * - Hai tham số sau tùy chọn, mặc định là chuỗi rỗng, khi đó điều kiện LIKE '%' sẽ lấy tất cả giá trị.
 * - Điều kiện Nam LIKE @pNam và Thang LIKE @pThang thực chất là so sánh bằng (với số). Có thể thay bằng =.
 * - Bảng codd lưu chi phí dở dang cuối kỳ (có thể là chi phí sản xuất dở dang).
 * - Dữ liệu trả về không có sắp xếp, nếu cần thứ tự phải tự sắp xếp ở ứng dụng.
 */
class AsGetCOdd
{
    /**
     * Gọi stored procedure asGetCOdd
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCOdd', $params);
    }
}