<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelardmkh_nh
 *
 * Stored procedure: asDelardmkh_nh
 * Mục đích: Xóa một bản ghi từ bảng ardmkhngh (có thể là danh mục khách hàng - ngành hàng) dựa trên mã công ty, mã khách hàng, mã ngành và số thứ tự.
 * Procedure thực hiện DELETE từ bảng ardmkhngh với điều kiện khớp Ma_cty, Ma_kh, Ma_ngh và Stt.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(20)).
 * - @pMa_kh (string, bắt buộc): Mã khách hàng (nvarchar(20)).
 * - @pMa_ngh (string, bắt buộc): Mã ngành (nvarchar(20)).
 * - @pStt (string, bắt buộc): Số thứ tự (nvarchar(50)).
 * - @pRet (int, output): Kết quả thực thi: luôn gán 0 (thành công). Không dùng @@error.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công (luôn là 0 nếu không có lỗi runtime).
 * 
 * Logic chi tiết:
 * - DELETE FROM ardmkhngh WHERE Ma_cty = @pMa_cty AND Ma_kh = @pMa_kh AND Ma_ngh = @pMa_ngh AND Stt = @pStt
 * - SET @pRet = 0 (luôn thành công)
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelardmkh_nh::call([
 *     'pMa_cty' => '001',
 *     'pMa_kh' => 'KH001',
 *     'pMa_ngh' => 'NGH01',
 *     'pStt' => '1',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công (hoặc không có bản ghi nào bị xóa)
 * }
 * ```
 * 
 * Lưu ý:
 * - Tất cả tham số đầu vào đều bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên bốn cột.
 * - Bảng ardmkhngh có thể lưu quan hệ giữa khách hàng và ngành hàng (nhiều-nhiều) với số thứ tự.
 * - Procedure luôn trả về @pRet = 0, không phản ánh lỗi SQL (nếu có lỗi runtime sẽ ném exception?).
 * - Có comment về hàm kiểm tra tồn tại afExistMadmkh_nh nhưng đã bị comment, không sử dụng.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelardmkh_nh
{
    /**
     * Gọi stored procedure asDelardmkh_nh
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelardmkh_nh', $params);
    }
}