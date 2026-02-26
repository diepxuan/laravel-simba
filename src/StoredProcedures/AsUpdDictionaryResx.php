<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:58:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdDictionaryResx.
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
     * Gọi stored procedure asUpdDictionaryResx.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDictionaryResx', [
            'pKey_Code_name'     => $params['pKey_Code_name'] ?? null,
            'pKey_Language'      => $params['pKey_Language'] ?? null,
            'pCode_name'         => $params['pCode_name'] ?? null,
            'pLanguage'          => $params['pLanguage'] ?? null,
            'pFormated_col_list' => $params['pFormated_col_list'] ?? null,
            'pViewform_size'     => $params['pViewform_size'] ?? null,
            'pRet'               => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDictionaryResx with named parameters.
     */
    public static function callWithParams(?string $Key_Code_name = null, ?string $Key_Language = null, ?string $Code_name = null, ?string $Language = null, ?string $Formated_col_list = null, ?string $Viewform_size = null, ?int $Ret = null): Collection
    {
        $params = [
            'pKey_Code_name'     => $Key_Code_name,
            'pKey_Language'      => $Key_Language,
            'pCode_name'         => $Code_name,
            'pLanguage'          => $Language,
            'pFormated_col_list' => $Formated_col_list,
            'pViewform_size'     => $Viewform_size,
            'pRet'               => $Ret,
        ];

        return self::call($params);
    }
}
