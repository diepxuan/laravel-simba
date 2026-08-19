<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCADelCT1
 *
 * Stored procedure: asCADelCT1
 * Mục đích: Xóa bản ghi trong bảng CACT1 (chi tiết chứng từ 1) theo mã công ty và số thứ tự record.
 * Procedure thực hiện xóa các bản ghi trong bảng CACT1 thỏa mãn điều kiện mã công ty và stt_rec.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự record (20 ký tự). Khóa chính của bảng CACT1.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelCT1::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'CT202500001',
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
 * - Bảng CACT1 lưu trữ chi tiết chứng từ loại 1 trong module Cost Accounting.
 * - Procedure này thường được gọi khi hủy một chứng từ chi phí.
 */
class AsCADelCT1
{
    /**
     * Gọi stored procedure asCADelCT1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asCADelCT1', $params);
    }
}