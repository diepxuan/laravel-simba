<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCODelDMCoBomCT
 *
 * Stored procedure: asCODelDMCoBomCT
 * Mục đích: Xóa định mức nguyên vật liệu - thông tin chi tiết (bảng codmbomct).
 * Procedure thực hiện xóa một bản ghi định mức nguyên vật liệu cho sản phẩm công trình dựa trên mã công ty, mã sản phẩm công trình và mã vật tư.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pMa_vt (string, bắt buộc): Mã vật tư (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0: được xoá, khác 0: lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu xóa thành công (không có lỗi).
 * - @pRet = mã lỗi SQL nếu có lỗi.
 * 
 * Logic chi tiết:
 * 1. Xóa bản ghi trong codmbomct với điều kiện Ma_cty, Ma_spct và ma_vt.
 * 2. Gán @pRet = @@ERROR.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCODelDMCoBomCT::call([
 *     'pMa_cty' => 'A07',
 *     'pMa_spct' => 'SP001',
 *     'pMa_vt' => 'VT001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure không kiểm tra ràng buộc trước khi xóa. Nếu bản ghi đang được sử dụng ở bảng khác, có thể gây lỗi khóa ngoại.
 * - Nếu không có bản ghi nào thỏa điều kiện, DELETE không ảnh hưởng hàng nào và @pRet = 0 (thành công).
 * - Đây là xóa chi tiết định mức, không phải xóa toàn bộ định mức của sản phẩm.
 */
class AsCODelDMCoBomCT
{
    /**
     * Gọi stored procedure asCODelDMCoBomCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCODelDMCoBomCT', $params);
    }
}