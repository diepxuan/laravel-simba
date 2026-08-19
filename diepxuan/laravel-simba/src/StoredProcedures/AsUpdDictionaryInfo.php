<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdDictionaryInfo
 *
 * Stored procedure: asUpdDictionaryInfo
 * Mục đích: Cập nhật thông tin từ điển (danh mục hệ thống).
 * Procedure cập nhật các thuộc tính của một mục từ điển (dictionary) trong bảng sysDictionaryInfo.
 * Các thuộc tính bao gồm tên mã, khóa chính, tên trường mã, độ dài mã, tên bảng, các cờ điều khiển, v.v.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Tên mã mới (NVARCHAR(50)). Giá trị sẽ được gán vào cột Code_name.
 * - @pKey_Code_name (string, bắt buộc): Tên mã cũ dùng làm điều kiện WHERE (NVARCHAR(50)).
 * - @pPk (string, bắt buộc): Khóa chính (NVARCHAR(128)).
 * - @pCode_fname (string, bắt buộc): Tên trường chứa mã (NVARCHAR(50)).
 * - @pMenuid (string, bắt buộc): Mã menu (NVARCHAR(8)).
 * - @pCode_length (int, bắt buộc): Độ dài mã (INT).
 * - @pName_fname (string, bắt buộc): Tên trường chứa tên (NVARCHAR(50)).
 * - @pTable_name (string, bắt buộc): Tên bảng (NVARCHAR(100)).
 * - @pLookup_when_invalid (bool, bắt buộc): Cờ tra cứu khi mã không hợp lệ (BIT).
 * - @pAllow_merge_code (bool, bắt buộc): Cờ cho phép gộp mã (BIT).
 * - @pDllname (string, bắt buộc): Tên DLL (NVARCHAR(100)).
 * - @pView_class_name (string, bắt buộc): Tên lớp hiển thị (NVARCHAR(50)).
 * - @pEdit_class_name (string, bắt buộc): Tên lớp chỉnh sửa (NVARCHAR(50)).
 * - @pDescription (string, bắt buộc): Mô tả (NVARCHAR(128)).
 * - @pCarry_field_list (string, bắt buộc): Danh sách trường mang theo (NVARCHAR(255)).
 * - @pDefault_sort (string, bắt buộc): Sắp xếp mặc định (NVARCHAR(128)).
 * - @pCopy_vaora (bool, bắt buộc): Cờ sao chép vaora (BIT).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - UPDATE bảng sysDictionaryInfo với tất cả các cột được liệt kê, điều kiện WHERE Code_name = @pKey_Code_name.
 * - Lưu ý cột Code_name cũng được cập nhật thành giá trị mới @pCode_name (có thể thay đổi mã).
 * - Bắt lỗi: SET @pRet = @@error.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdDictionaryInfo::call([
 *     'pCode_name' => 'NEWCODE',
 *     'pKey_Code_name' => 'OLDCODE',
 *     'pPk' => 'PK001',
 *     'pCode_fname' => 'MaCode',
 *     'pMenuid' => 'MENU01',
 *     'pCode_length' => 10,
 *     'pName_fname' => 'Ten',
 *     'pTable_name' => 'tblDictionary',
 *     'pLookup_when_invalid' => true,
 *     'pAllow_merge_code' => false,
 *     'pDllname' => 'Module.dll',
 *     'pView_class_name' => 'ViewClass',
 *     'pEdit_class_name' => 'EditClass',
 *     'pDescription' => 'Mô tả từ điển',
 *     'pCarry_field_list' => 'Field1,Field2',
 *     'pDefault_sort' => 'Code_name ASC',
 *     'pCopy_vaora' => false,
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
 * - Tham số @pKey_Code_name là mã cũ dùng để xác định bản ghi cần cập nhật. Nếu mã không tồn tại, không có dòng nào bị ảnh hưởng.
 * - Các tham số BIT trong PHP có thể truyền true/false hoặc 1/0.
 * - Procedure không thay đổi các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Nếu cần cập nhật chỉ một số trường, có thể cần sửa procedure gốc hoặc tạo procedure riêng.
 */
class AsUpdDictionaryInfo
{
    /**
     * Gọi stored procedure asUpdDictionaryInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdDictionaryInfo', $params);
    }
}