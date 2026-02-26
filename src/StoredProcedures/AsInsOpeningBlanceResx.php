<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:11:30
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsOpeningBlanceResx.
 *
 * Stored procedure: asInsOpeningBlanceResx
 * Mục đích: Thêm mới một bản ghi vào bảng sysOpeningBalanceResx (tài nguyên đa ngôn ngữ cho mở đầu số dư).
 * Bảng này lưu thông tin định dạng cột và kích thước form xem theo ngôn ngữ cho từ điển mở đầu số dư.
 *
 * Tham số:
 * - @pCode_name (string, bắt buộc): Tên mã từ điển (50 ký tự, Unicode). Khớp với code_name trong sysOpeningBalanceInfo.
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
 * 1. INSERT vào sysOpeningBalanceResx với các giá trị truyền vào.
 * 2. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Bảng sysOpeningBalanceResx có khóa chính có thể là (code_name, language).
 * - Tham số @pFormated_col_list có độ dài lớn (4000 ký tự) để lưu cấu hình định dạng cột cho grid hoặc form.
 * - Tham số @pViewform_size kiểu VARCHAR không chỉ định độ dài, có thể lưu tối đa 8000 ký tự (mặc định).
 * - Nên đảm bảo code_name đã tồn tại trong sysOpeningBalanceInfo.
 * - Ngôn ngữ phải tuân theo danh sách ngôn ngữ hỗ trợ của hệ thống.
 * - Nếu đã có bản ghi với cùng code_name và language, INSERT sẽ gây lỗi vi phạm khóa chính.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsOpeningBlanceResx::call([
 *     'pCode_name' => 'OB_VATTU',
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
 * - Bảng sysOpeningBalanceResx: lưu tài nguyên đa ngôn ngữ cho mở đầu số dư.
 * - Bảng sysOpeningBalanceInfo: thông tin mở đầu số dư.
 * - Các procedure khác: asGetOpeningBlanceResx, asUpdOpeningBlanceResx, asDelOpeningBlanceResx.
 */
class AsInsOpeningBlanceResx
{
    /**
     * Gọi stored procedure asInsOpeningBlanceResx.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsOpeningBlanceResx', [
            'pCode_name'         => $params['pCode_name'] ?? null,
            'pLanguage'          => $params['pLanguage'] ?? null,
            'pFormated_col_list' => $params['pFormated_col_list'] ?? null,
            'pViewform_size'     => $params['pViewform_size'] ?? null,
            'pRet'               => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asInsOpeningBlanceResx with named parameters.
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
