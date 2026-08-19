<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCODelDMCoBomPH
 *
 * Stored procedure: asCODelDMCoBomPH
 * Mục đích: Xóa định mức nguyên vật liệu (cả phần chung và chi tiết).
 * Procedure thực hiện xóa toàn bộ định mức nguyên vật liệu của một sản phẩm công trình, bao gồm bảng chi tiết (codmbomct) và bảng chung (codmbomph).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0: được xoá, khác 0: lỗi (mã lỗi SQL).
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
 * 1. Xóa các bản ghi trong codmbomct (chi tiết định mức) với điều kiện Ma_cty và Ma_spct.
 * 2. Xóa bản ghi trong codmbomph (thông tin chung định mức) với điều kiện Ma_cty và Ma_spct.
 * 3. Gán @pRet = @@ERROR (lỗi của lệnh DELETE cuối cùng? Thực tế @@ERROR sẽ bắt lỗi của lệnh trước đó, nếu lỗi xảy ra ở DELETE đầu thì sẽ bị ghi đè bởi DELETE sau. Cần lưu ý).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCODelDMCoBomPH::call([
 *     'pMa_cty' => 'A07',
 *     'pMa_spct' => 'SP001',
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
 * - Procedure không kiểm tra ràng buộc trước khi xóa. Nếu có bảng khác tham chiếu đến định mức này, có thể gây lỗi khóa ngoại.
 * - Xóa toàn bộ chi tiết định mức trước, sau đó xóa phần chung để đảm bảo toàn vẹn khóa ngoại (nếu có ràng buộc từ chi tiết đến chung).
 * - Nếu không có bản ghi nào thỏa điều kiện, DELETE không ảnh hưởng hàng nào và @pRet = 0 (thành công).
 * - Cần đảm bảo mã sản phẩm công trình tồn tại.
 */
class AsCODelDMCoBomPH
{
    /**
     * Gọi stored procedure asCODelDMCoBomPH
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCODelDMCoBomPH', $params);
    }
}