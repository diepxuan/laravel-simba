<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsDictionaryComplexInfo
 *
 * Stored procedure: asInsDictionaryComplexInfo
 * Mục đích: Thêm mới một bản ghi vào bảng sysDictionaryComplexInfo (từ điển phức tạp).
 * Bảng này lưu thông tin cấu hình cho các từ điển (danh mục) phức tạp trong hệ thống, bao gồm tên bảng, trường khóa, lớp giao diện, v.v.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Tên mã (50 ký tự, Unicode). Định danh của từ điển.
 * - @pPk (string, bắt buộc): Tên trường khóa chính (128 ký tự). Ví dụ: 'ma_vt'.
 * - @pCode_fname (string, bắt buộc): Tên trường mã (50 ký tự). Ví dụ: 'ma_vt'.
 * - @pMenuid (string, bắt buộc): Mã menu liên kết (8 ký tự). Menu chứa chức năng quản lý từ điển.
 * - @pCode_length (int, bắt buộc): Độ dài tối đa của mã (số nguyên). Ví dụ: 20.
 * - @pName_fname (string, bắt buộc): Tên trường tên (50 ký tự). Ví dụ: 'ten_vt'.
 * - @pTable_name (string, bắt buộc): Tên bảng dữ liệu (100 ký tự). Bảng chứa dữ liệu danh mục.
 * - @pLookup_when_invalid (bool, bắt buộc): Cờ cho phép tra cứu khi mã không hợp lệ (bit). 1 = cho phép.
 * - @pAllow_merge_code (bool, bắt buộc): Cờ cho phép gộp mã (bit). 1 = cho phép.
 * - @pDllname (string, bắt buộc): Tên file DLL chứa lớp quản lý (100 ký tự). Có thể rỗng.
 * - @pView_class_name (string, bắt buộc): Tên lớp giao diện xem (50 ký tự). Ví dụ: 'CDictionaryView'.
 * - @pEdit_class_name (string, bắt buộc): Tên lớp giao diện sửa (50 ký tự). Ví dụ: 'CDictionaryEdit'.
 * - @pDescription (string, bắt buộc): Mô tả từ điển (128 ký tự, Unicode).
 * - @pCarry_field_list (string, bắt buộc): Danh sách các trường mang theo (255 ký tự). Danh sách cách nhau dấu phẩy.
 * - @pDefault_sort (string, bắt buộc): Sắp xếp mặc định (128 ký tự). Ví dụ: 'ma_vt ASC'.
 * - @pCopy_vaora (bool, bắt buộc): Cờ cho phép copy giá trị vào/ra (bit). 1 = cho phép.
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
 * 1. INSERT vào sysDictionaryComplexInfo với các giá trị truyền vào.
 * 2. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Bảng sysDictionaryComplexInfo có thể có khóa chính là code_name hoặc kết hợp nhiều trường.
 * - Các tham số kiểu bit (bool) trong SQL Server tương ứng với giá trị 0/1. Trong PHP có thể truyền boolean hoặc integer.
 * - Danh sách trường carry_field_list có thể dùng để chỉ định các trường dữ liệu cần mang theo khi tra cứu.
 * - Tên lớp view và edit có thể dùng để tùy chỉnh giao diện cho từ điển.
 * - Nên đảm bảo menuid tồn tại trong bảng menu hệ thống.
 * - Độ dài mã code_length nên phù hợp với thiết kế cột trong bảng table_name.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsDictionaryComplexInfo::call([
 *     'pCode_name' => 'DM_VATTU',
 *     'pPk' => 'ma_vt',
 *     'pCode_fname' => 'ma_vt',
 *     'pMenuid' => 'MN001',
 *     'pCode_length' => 20,
 *     'pName_fname' => 'ten_vt',
 *     'pTable_name' => 'dmvt',
 *     'pLookup_when_invalid' => true,
 *     'pAllow_merge_code' => false,
 *     'pDllname' => '',
 *     'pView_class_name' => 'CDictionaryView',
 *     'pEdit_class_name' => 'CDictionaryEdit',
 *     'pDescription' => 'Danh mục vật tư',
 *     'pCarry_field_list' => 'ma_nhvt,ma_dvt,gia_ban',
 *     'pDefault_sort' => 'ma_vt ASC',
 *     'pCopy_vaora' => true,
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
 * - Bảng sysDictionaryComplexInfo: lưu cấu hình từ điển phức tạp.
 * - Các procedure khác: asGetDictionaryComplexInfo, asUpdDictionaryComplexInfo, asDelDictionaryComplexInfo.
 */
class AsInsDictionaryComplexInfo
{
    /**
     * Gọi stored procedure asInsDictionaryComplexInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsDictionaryComplexInfo', $params);
    }
}