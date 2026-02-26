<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:57:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdOpeningBlanceResx.
 *
 * Stored procedure: asUpdOpeningBlanceResx
 * Mục đích: Cập nhật tài nguyên đa ngôn ngữ (resource) cho số dư đầu kỳ.
 * Procedure cập nhật danh sách cột định dạng (Formated_col_list) cho một mã số dư đầu kỳ và ngôn ngữ cụ thể trong bảng sysOpeningBalanceResx.
 *
 * Tham số:
 * - @pCode_name (string, bắt buộc): Mã số dư đầu kỳ (NVARCHAR(50)).
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ (NVARCHAR(5)).
 * - @pFormated_col_list (string, bắt buộc): Danh sách cột định dạng (NVARCHAR(4000)). Có thể là XML hoặc chuỗi định dạng hiển thị.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả thực thi có thể kiểm tra qua số dòng bị ảnh hưởng (affected rows).
 *
 * Logic chi tiết:
 * - UPDATE bảng sysOpeningBalanceResx: cập nhật cột Formated_col_list = @pFormated_col_list với điều kiện Code_name = @pCode_name AND Language = @pLanguage.
 * - Các cột khác (Viewform_size) bị comment trong code gốc, không được cập nhật.
 * - Không có bắt lỗi @@output (bị comment).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdOpeningBlanceResx::call([
 *     'pCode_name' => 'OB001',
 *     'pLanguage' => 'vi',
 *     'pFormated_col_list' => '<columns><col name="MaTK" width="100"/></columns>',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Tham số @pCode_name và @pLanguage tạo thành khóa điều kiện duy nhất (có thể là khóa chính phức hợp).
 * - Cột Formated_col_list có thể chứa dữ liệu lớn (NVARCHAR(4000)), dùng để định dạng hiển thị các cột trong grid/form.
 * - Cột Viewform_size bị comment trong procedure, có thể đã không dùng đến.
 * - Procedure không cập nhật các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Không có output parameter @pRet, lỗi SQL sẽ ném exception (tùy vào cấu hình kết nối).
 * - Bảng sysOpeningBalanceResx lưu thông tin dịch thuật và cấu hình hiển thị cho số dư đầu kỳ theo ngôn ngữ.
 * - Tên procedure có lỗi chính tả "Blance" (đúng ra là "Balance") nhưng phải giữ nguyên.
 */
class AsUpdOpeningBlanceResx
{
    /**
     * Gọi stored procedure asUpdOpeningBlanceResx.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa resultset nếu có SELECT)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdOpeningBlanceResx', [
            'pCode_name'         => $params['pCode_name'] ?? null,
            'pLanguage'          => $params['pLanguage'] ?? null,
            'pFormated_col_list' => $params['pFormated_col_list'] ?? null,
            'pViewform_size'     => $params['pViewform_size'] ?? null,
            'pRet'               => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdOpeningBlanceResx with named parameters.
     */
    public static function callWithParams(?string $Code_name = null, ?string $Language = null, ?string $Formated_col_list = null, ?string $Viewform_size = null, ?int $Ret = null): Collection
    {
        $params = [
            'pCode_name'         => $Code_name,
            'pLanguage'          => $Language,
            'pFormated_col_list' => $Formated_col_list,
            'pViewform_size'     => $Viewform_size,
            'pRet'               => $Ret,
        ];

        return self::call($params);
    }
}
