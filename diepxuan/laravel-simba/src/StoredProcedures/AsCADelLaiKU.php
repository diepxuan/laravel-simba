<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCADelLaiKU
 *
 * Stored procedure: asCADelLaiKU
 * Mục đích: Xóa bản ghi lãi khế ước (CaLaiKu) theo mã công ty, tháng, năm và mã khế ước (có thể dùng pattern).
 * Procedure thực hiện xóa các bản ghi trong bảng CaLaiKu thỏa mãn điều kiện mã công ty, tháng, năm và mã khế ước bắt đầu bằng chuỗi cung cấp.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (int, bắt buộc): Tháng (1-12).
 * - @pNam (int, bắt buộc): Năm.
 * - @pMa_ku (string, bắt buộc): Mã khế ước (20 ký tự). Nếu chuỗi không rỗng, sẽ xóa các bản ghi có mã khế ước bắt đầu bằng chuỗi này (dùng LIKE). Nếu chuỗi rỗng, xóa tất cả bản ghi của tháng/năm.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelLaiKU::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_ku' => 'KU',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Bảng CaLaiKu lưu trữ lãi khế ước đã tính từ procedure asCACalLaiKU.
 * - Nếu @pMa_ku là chuỗi rỗng, điều kiện LIKE '%' sẽ xóa tất cả bản ghi của tháng/năm đó.
 * - Procedure này thường được gọi khi muốn hủy tính lãi đã thực hiện trước đó.
 */
class AsCADelLaiKU
{
    /**
     * Gọi stored procedure asCADelLaiKU
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asCADelLaiKU', $params);
    }
}