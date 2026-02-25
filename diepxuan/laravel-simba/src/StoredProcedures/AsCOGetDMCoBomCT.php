<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOGetDMCoBomCT
 *
 * Stored procedure: asCOGetDMCoBomCT
 * Mục đích: Lấy danh sách định mức nguyên vật liệu - thông tin chi tiết (bảng codmbomct) kết hợp với thông tin chung và tên vật tư.
 * Procedure trả về danh sách các định mức nguyên vật liệu với khả năng lọc theo mã công ty, mã sản phẩm công trình và mã vật tư.
 * Các tham số có giá trị mặc định rỗng, nếu truyền NULL sẽ được chuyển thành '%' (tìm tất cả).
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định ''): Mã công ty (20 ký tự). Lưu ý kiểu NVARCHAR(20) thay vì 3. Nếu NULL hoặc rỗng sẽ tìm tất cả mã công ty.
 * - @pma_spct (string, tùy chọn, mặc định ''): Mã sản phẩm công trình (20 ký tự). Nếu NULL hoặc rỗng sẽ tìm tất cả mã sản phẩm.
 * - @pMa_vt (string, tùy chọn, mặc định ''): Mã vật tư (20 ký tự). Nếu NULL hoặc rỗng sẽ tìm tất cả mã vật tư.
 * 
 * Giá trị mặc định:
 * - @pMa_cty = '' (chuỗi rỗng)
 * - @pma_spct = ''
 * - @pMa_vt = ''
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - ma_spct (string): Mã sản phẩm công trình.
 *   - ma_vt (string): Mã vật tư.
 *   - vt_chinh (string): Cờ vật tư chính (1 ký tự).
 *   - so_luong (float): Số lượng định mức.
 *   - ten_vt (string): Tên vật tư (lấy từ indmvt). Nếu không có sẽ là chuỗi rỗng.
 *   - cuser (string): Người tạo bản ghi.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. Nếu @pMa_cty IS NULL, gán @pMa_cty = '%' (ký tự đại diện).
 * 2. Tương tự với @pMa_spct và @pMa_vt (nhưng code chỉ xử lý NULL, không xử lý chuỗi rỗng? Thực tế chuỗi rỗng sẽ được dùng trực tiếp trong LIKE, ví dụ @pMa_spct + '%' nếu @pMa_spct = '' thì thành '%%'? Có thể vẫn hoạt động).
 * 3. SELECT kết hợp LEFT JOIN giữa codmbomct, codmbomph và indmvt.
 * 4. Điều kiện WHERE: ph.ma_cty = @pMa_cty (so sánh chính xác) và ph.ma_spct LIKE @pMa_spct + '%', ct.ma_vt LIKE @pMa_vt + '%'.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsCOGetDMCoBomCT::call([
 *     'pMa_cty' => 'A07',
 *     'pma_spct' => 'SP',
 *     'pMa_vt' => 'VT',
 * ]);
 * // $rows là mảng các đối tượng stdClass hoặc mảng kết hợp.
 * foreach ($rows as $row) {
 *     echo "Mã SPCT: {$row->ma_spct}, Mã VT: {$row->ma_vt}, Tên VT: {$row->ten_vt}, Số lượng: {$row->so_luong}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pMa_cty so sánh bằng (=) chứ không LIKE, do đó cần truyền chính xác mã công ty nếu muốn lọc.
 * - Các tham số @pma_spct và @pMa_vt sử dụng LIKE với ký tự '%' ở sau, cho phép tìm kiếm theo tiền tố.
 * - Nếu truyền chuỗi rỗng, điều kiện LIKE sẽ thành '%%' (trả về tất cả).
 * - Nếu truyền NULL, procedure sẽ chuyển thành '%' (cũng trả về tất cả).
 * - Kết quả trả về có thể bao gồm các định mức không có tên vật tư (LEFT JOIN).
 */
class AsCOGetDMCoBomCT
{
    /**
     * Gọi stored procedure asCOGetDMCoBomCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOGetDMCoBomCT', $params);
    }
}