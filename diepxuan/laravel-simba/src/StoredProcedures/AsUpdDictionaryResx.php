<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdDictionaryResx
 *
 * Stored procedure: asUpdDictionaryResx
 * Mục đích: Cập nhật tài nguyên đa ngôn ngữ (resource) cho từ điển.
 * Procedure cập nhật thông tin dịch thuật (resource) của một từ điển trong bảng DictionaryResx, bao gồm danh sách cột định dạng và kích thước form.
 * 
 * Tham số:
 * - @pKey_Code_name (string, bắt buộc): Mã từ điển cũ dùng làm điều kiện WHERE (NVARCHAR(50)).
 * - @pKey_Language (string, bắt buộc): Mã ngôn ngữ cũ dùng làm điều kiện WHERE (NVARCHAR(5)).
 * - @pCode_name (string, bắt buộc): Mã từ điển mới (NVARCHAR(50)).
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ mới (NVARCHAR(5)).
 * - @pFormated_col_list (string, bắt buộc): Danh sách cột định dạng (NVARCHAR(4000)). Có thể là XML hoặc chuỗi định dạng hiển thị.
 * - @pViewform_size (string, bắt buộc): Kích thước form hiển thị (VARCHAR). Kiểu không có độ dài cụ thể (có thể là VARCHAR(MAX)?).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - UPDATE bảng DictionaryResx: cập nhật các cột Code_name, Language, Formated_col_list, Viewform_size với điều kiện Code_name = @pKey_Code_name AND Language = @pKey_Language.
 * - Lưu ý cập nhật cả mã từ điển và mã ngôn ngữ (có thể thay đổi cả hai).
 * - Bắt lỗi: SET @pRet = @@error.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdDictionaryResx::call([
 *     'pKey_Code_name' => 'CUST',
 *     'pKey_Language' => 'vi',
 *     'pCode_name' => 'CUST',
 *     'pLanguage' => 'en',
 *     'pFormated_col_list' => '<columns><col name="Ma" width="100"/></columns>',
 *     'pViewform_size' => '800x600',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pKey_Code_name và @pKey_Language tạo thành khóa điều kiện duy nhất (có thể là khóa chính phức hợp).
 * - Có thể thay đổi cả mã từ điển và ngôn ngữ (cập nhật thành bản ghi mới). Nếu thay đổi, cần đảm bảo không trùng với khóa chính khác.
 * - Cột Formated_col_list có thể chứa dữ liệu lớn (NVARCHAR(4000)), dùng để định dạng hiển thị các cột trong grid/form.
 * - Cột Viewform_size kiểu VARCHAR không có độ dài cụ thể (có thể là VARCHAR(MAX) trong SQL Server). Lưu ý độ dài khi truyền giá trị.
 * - Procedure không cập nhật các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Bảng DictionaryResx lưu thông tin dịch thuật và cấu hình hiển thị cho từ điển theo ngôn ngữ.
 */
class AsUpdDictionaryResx
{
    /**
     * Gọi stored procedure asUpdDictionaryResx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdDictionaryResx', $params);
    }
}