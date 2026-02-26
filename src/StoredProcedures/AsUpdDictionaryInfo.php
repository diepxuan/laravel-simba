<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:58:33
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdDictionaryInfo.
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
     * Gọi stored procedure asUpdDictionaryInfo.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDictionaryInfo', [
            'pCode_name'           => $params['pCode_name'] ?? null,
            'pKey_Code_name'       => $params['pKey_Code_name'] ?? null,
            'pPk'                  => $params['pPk'] ?? null,
            'pCode_fname'          => $params['pCode_fname'] ?? null,
            'pMenuid'              => $params['pMenuid'] ?? null,
            'pCode_length'         => $params['pCode_length'] ?? null,
            'pName_fname'          => $params['pName_fname'] ?? null,
            'pTable_name'          => $params['pTable_name'] ?? null,
            'pLookup_when_invalid' => $params['pLookup_when_invalid'] ?? null,
            'pAllow_merge_code'    => $params['pAllow_merge_code'] ?? null,
            'pDllname'             => $params['pDllname'] ?? null,
            'pView_class_name'     => $params['pView_class_name'] ?? null,
            'pEdit_class_name'     => $params['pEdit_class_name'] ?? null,
            'pDescription'         => $params['pDescription'] ?? null,
            'pCarry_field_list'    => $params['pCarry_field_list'] ?? null,
            'pDefault_sort'        => $params['pDefault_sort'] ?? null,
            'pCopy_vaora'          => $params['pCopy_vaora'] ?? null,
            'pRet'                 => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDictionaryInfo with named parameters.
     */
    public static function callWithParams(?string $Code_name = null, ?string $Key_Code_name = null, ?string $Pk = null, ?string $Code_fname = null, ?string $Menuid = null, ?int $Code_length = null, ?string $Name_fname = null, ?string $Table_name = null, ?bool $Lookup_when_invalid = null, ?bool $Allow_merge_code = null, ?string $Dllname = null, ?string $View_class_name = null, ?string $Edit_class_name = null, ?string $Description = null, ?string $Carry_field_list = null, ?string $Default_sort = null, ?bool $Copy_vaora = null, ?int $Ret = null): Collection
    {
        $params = [
            'pCode_name'           => $Code_name,
            'pKey_Code_name'       => $Key_Code_name,
            'pPk'                  => $Pk,
            'pCode_fname'          => $Code_fname,
            'pMenuid'              => $Menuid,
            'pCode_length'         => $Code_length,
            'pName_fname'          => $Name_fname,
            'pTable_name'          => $Table_name,
            'pLookup_when_invalid' => $Lookup_when_invalid,
            'pAllow_merge_code'    => $Allow_merge_code,
            'pDllname'             => $Dllname,
            'pView_class_name'     => $View_class_name,
            'pEdit_class_name'     => $Edit_class_name,
            'pDescription'         => $Description,
            'pCarry_field_list'    => $Carry_field_list,
            'pDefault_sort'        => $Default_sort,
            'pCopy_vaora'          => $Copy_vaora,
            'pRet'                 => $Ret,
        ];

        return self::call($params);
    }
}
