<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAGetDmXepLoai
 *
 * Stored procedure: asSAGetDmXepLoai
 * Mục đích: Lấy danh mục xếp loại.
 * Procedure truy vấn danh sách xếp loại (cấp bậc, hệ số) từ bảng danh mục xếp loại, có thể lọc theo mã công ty và mã xếp loại.
 * Nếu tham số là NULL, procedure sẽ sử dụng ký tự đại diện '%' để lấy tất cả.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định NULL): Mã công ty (3 ký tự). Nếu NULL hoặc không truyền, procedure sẽ lấy tất cả các công ty (sử dụng ký tự đại diện '%').
 * - @pMa_xeploai (string, tùy chọn, mặc định NULL): Mã xếp loại (1 ký tự). Nếu NULL hoặc không truyền, procedure sẽ lấy tất cả xếp loại (sử dụng ký tự đại diện '%').
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset chứa các cột:
 *   + ma_cty: Mã công ty
 *   + ma_xeploai: Mã xếp loại (A, B, C...)
 *   + he_so: Hệ số lương (hoặc hệ số khác) dạng decimal
 *   + ksd: Trạng thái sử dụng (bit)
 *   + cuser: Người tạo
 *   + cdate: Ngày tạo
 *   + luser: Người sửa cuối
 *   + ldate: Ngày sửa cuối
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy danh mục xếp loại của công ty '001'
 * $result = AsSAGetDmXepLoai::call([
 *     'pMa_cty' => '001',
 * ]);
 * 
 * // Lấy xếp loại cụ thể 'A' của công ty '001'
 * $result = AsSAGetDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'A',
 * ]);
 * 
 * // Lấy tất cả xếp loại của mọi công ty
 * $result = AsSAGetDmXepLoai::call();
 * ```
 * 
 * Lưu ý:
 * - Nếu @pMa_cty là NULL, procedure sẽ gán giá trị '%', sau đó điều kiện WHERE sử dụng LIKE với @pMa_cty + '%'.
 * - Tương tự với @pMa_xeploai.
 * - Kết quả trả về có thể bao gồm dữ liệu của nhiều công ty và nhiều xếp loại nếu các tham số là NULL.
 * - Điều kiện LIKE có thể ảnh hưởng hiệu năng nếu bảng lớn, nên sử dụng tham số cụ thể khi có thể.
 * - Tên bảng trong SQL là `sadmxeploai` (không phân biệt hoa thường).
 */
class AsSAGetDmXepLoai
{
    /**
     * Gọi stored procedure asSAGetDmXepLoai
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSAGetDmXepLoai', $params);
    }
}