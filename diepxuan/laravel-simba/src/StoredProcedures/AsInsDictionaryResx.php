<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsDictionaryResx
 *
 * Stored procedure: asInsDictionaryResx
 * Mục đích: Thêm mới một bản ghi vào bảng sysDictionaryResx (tài nguyên đa ngôn ngữ cho từ điển đơn giản).
 * Bảng này lưu thông tin định dạng cột và kích thước form xem theo ngôn ngữ cho từ điển đơn giản.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Tên mã từ điển (50 ký tự, Unicode). Khớp với code_name trong sysDictionaryInfo.
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ (5 ký tự). Ví dụ: 'vi', 'en', 'fr'.
 * - @pFormated_col_list (string, bắt buộc): Danh sách cột định dạng (4000 ký tự, Unicode). Có thể là chuỗi XML, JSON hoặc danh sách trường cách nhau dấu phẩy.
 * - @pViewform_size (string, bắt buộc): Kích thước form xem (kiểu VARCHAR không độ dài). Có thể là chuỗi kích thước như '800,600'.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. INSERT vào sysDictionaryResx với các giá trị truyền vào.
 * 2. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Bảng sysDictionaryResx có khóa chính có thể là (code_name, language).
 * - Tham số @pFormated_col_list có độ dài lớn (4000 ký tự) để lưu cấu hình định dạng cột cho grid hoặc form.
 * - Tham số @pViewform_size kiểu VARCHAR không chỉ định độ dài, có thể lưu tối đa 8000 ký tự (mặc định).
 * - Nên đảm bảo code_name đã tồn tại trong sysDictionaryInfo.
 * - Ngôn ngữ phải tuân theo danh sách ngôn ngữ hỗ trợ của hệ thống.
 * - Nếu đã có bản ghi với cùng code_name và language, INSERT sẽ gây lỗi vi phạm khóa chính.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsDictionaryResx::call([
 *     'pCode_name' => 'DM_VATTU',
 *     'pLanguage' => 'vi',
 *     'pFormated_col_list' => 'ma_vt:100,ten_vt:200,ma_dvt:50',
 *     'pViewform_size' => '1000,700',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysDictionaryResx: lưu tài nguyên đa ngôn ngữ cho từ điển đơn giản.
 * - Bảng sysDictionaryInfo: thông tin từ điển đơn giản.
 * - Các procedure khác: asGetDictionaryResx, asUpdDictionaryResx, asDelDictionaryResx.
 */
class AsInsDictionaryResx
{
    /**
     * Gọi stored procedure asInsDictionaryResx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsDictionaryResx', $params);
    }
}