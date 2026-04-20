<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsAPDelCT1
 *
 * Stored procedure: asAPDelCT1
 * Mục đích: Xóa chi tiết 1 (APCT1) của một chứng từ Accounts Payable.
 * Procedure xóa các bản ghi trong bảng APCT1 (chi tiết chứng từ phải trả) dựa trên mã công ty và số chứng từ.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số chứng từ (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsAPDelCT1::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AP202500001',
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
 * - Procedure chỉ xóa các bản ghi trong bảng APCT1 có khớp mã công ty và số chứng từ.
 * - Không có kiểm tra ràng buộc khác (như trạng thái chứng từ). Cần đảm bảo chứng từ có thể xóa được trước khi gọi.
 * - Bảng APCT1 lưu chi tiết các khoản phải trả (có thể là chi tiết theo hóa đơn, hợp đồng, v.v.).
 */
class AsAPDelCT1
{
    /**
     * Gọi stored procedure asAPDelCT1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asAPDelCT1', $params);
    }
}