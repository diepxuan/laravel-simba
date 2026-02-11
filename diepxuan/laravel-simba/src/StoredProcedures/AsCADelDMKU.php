<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCADelDMKU
 *
 * Stored procedure: asCADelDMKU
 * Mục đích: Xóa danh mục khế ước (CADMKU) theo mã công ty và mã khế ước.
 * Procedure thực hiện kiểm tra tồn tại mã khế ước bằng hàm afChkExistsCodeDict trước khi xóa.
 * Nếu mã tồn tại (có bản ghi liên quan) thì trả về lỗi 50004, ngược lại xóa bản ghi trong bảng CADMKU.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL hoặc 50004).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ku (string, bắt buộc): Mã khế ước (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelDMKU::call([
 *     'pMa_cty' => '001',
 *     'pMa_ku' => 'KU001',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else if ($ret === 50004) {
 *     // Mã khế ước tồn tại trong các bản ghi liên quan, không được xóa
 * } else {
 *     // Có lỗi SQL khác
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure gọi hàm hệ thống afChkExistsCodeDict để kiểm tra ràng buộc khóa ngoại.
 * - Bảng CADMKU lưu trữ danh mục khế ước (loan agreements).
 * - Mã lỗi 50004 là lỗi custom của ứng dụng, chỉ định không thể xóa do tồn tại bản ghi liên quan.
 */
class AsCADelDMKU
{
    /**
     * Gọi stored procedure asCADelDMKU
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asCADelDMKU', $params);
    }
}