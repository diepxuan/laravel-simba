<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCADelCDKU
 *
 * Stored procedure: asCADelCDKU
 * Mục đích: Xóa chi tiết khế ước (cacdku) theo mã công ty, năm, mã khế ước.
 * Procedure thực hiện xóa các bản ghi trong bảng cacdku (chi tiết khế ước) thỏa mãn điều kiện.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNam (int, bắt buộc): Năm của khế ước.
 * - @pMa_ku (string, bắt buộc): Mã khế ước (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelCDKU::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pMa_ku' => 'KU001',
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
 * - Procedure sử dụng TRY...CATCH để bắt lỗi SQL.
 * - Xóa tất cả chi tiết khế ước của một năm và mã khế ước cụ thể.
 * - Bảng cacdku lưu trữ chi tiết khế ước (có thể bao gồm các khoản vay, trả nợ).
 */
class AsCADelCDKU
{
    /**
     * Gọi stored procedure asCADelCDKU
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asCADelCDKU', $params);
    }
}