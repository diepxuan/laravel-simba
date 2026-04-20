<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsOpeningBlanceInfo
 *
 * Stored procedure: asInsOpeningBlanceInfo
 * Mục đích: Thêm mới một bản ghi vào bảng sysOpeningBalanceInfo (thông tin mở đầu số dư).
 * Bảng này lưu cấu hình cho các từ điển mở đầu số dư (opening balance), tương tự sysDictionaryInfo nhưng có thêm các cột tham số par0..par9.
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
 * - @pPar0 (string, bắt buộc): Tham số phụ 0 (50 ký tự). Có thể dùng để lưu thông tin bổ sung.
 * - @pPar1 (string, bắt buộc): Tham số phụ 1 (50 ký tự).
 * - @pPar2 (string, bắt buộc): Tham số phụ 2 (50 ký tự).
 * - @pPar3 (string, bắt buộc): Tham số phụ 3 (50 ký tự).
 * - @pPar4 (string, bắt buộc): Tham số phụ 4 (50 ký tự).
 * - @pPar5 (string, bắt buộc): Tham số phụ 5 (50 ký tự).
 * - @pPar6 (string, bắt buộc): Tham số phụ 6 (50 ký tự).
 * - @pPar7 (string, bắt buộc): Tham số phụ 7 (50 ký tự).
 * - @pPar8 (string, bắt buộc): Tham số phụ 8 (50 ký tự).
 * - @pPar9 (string, bắt buộc): Tham số phụ 9 (50 ký tự).
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
 * 1. INSERT vào sysOpeningBalanceInfo với các giá trị truyền vào (bao gồm par0..par9).
 * 2. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Bảng sysOpeningBalanceInfo có thể có khóa chính là code_name hoặc kết hợp nhiều trường.
 * - Các cột par0..par9 có thể dùng để lưu thông tin bổ sung tùy theo nghiệp vụ mở đầu số dư.
 * - Các tham số kiểu bit (bool) trong SQL Server tương ứng với giá trị 0/1. Trong PHP có thể truyền boolean hoặc integer.
 * - Danh sách trường carry_field_list có thể dùng để chỉ định các trường dữ liệu cần mang theo khi tra cứu.
 * - Tên lớp view và edit có thể dùng để tùy chỉnh giao diện cho từ điển.
 * - Nên đảm bảo menuid tồn tại trong bảng menu hệ thống.
 * - Độ dài mã code_length nên phù hợp với thiết kế cột trong bảng table_name.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsOpeningBlanceInfo::call([
 *     'pCode_name' => 'OB_VATTU',
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
 *     'pDescription' => 'Mở đầu số dư vật tư',
 *     'pCarry_field_list' => 'ma_nhvt,ma_dvt,gia_ban',
 *     'pDefault_sort' => 'ma_vt ASC',
 *     'pCopy_vaora' => true,
 *     'pPar0' => '',
 *     'pPar1' => '',
 *     // ... các par khác
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
 * - Bảng sysOpeningBalanceInfo: lưu cấu hình từ điển mở đầu số dư.
 * - Các procedure khác: asGetOpeningBlanceInfo, asUpdOpeningBlanceInfo, asDelOpeningBlanceInfo.
 */
class AsInsOpeningBlanceInfo
{
    /**
     * Gọi stored procedure asInsOpeningBlanceInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsOpeningBlanceInfo', $params);
    }
}