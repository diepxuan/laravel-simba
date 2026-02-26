<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:32:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdVoucherResx.
 *
 * Stored procedure: asUpdVoucherResx
 * Mục đích: Cập nhật tài nguyên đa ngôn ngữ (resource) cho chứng từ.
 * Procedure cập nhật thông tin dịch thuật (resource) của một loại chứng từ trong bảng sysVoucherResx, bao gồm danh sách cột định dạng cho phần header (Ph) và detail (Ct), cùng mô tả.
 *
 * Tham số:
 * - @pKey_Voucher_code (string, bắt buộc): Mã chứng từ cũ dùng làm điều kiện WHERE (NVARCHAR(50)).
 * - @pKey_Language (string, bắt buộc): Mã ngôn ngữ cũ dùng làm điều kiện WHERE (NVARCHAR(5)).
 * - @pVoucher_code (string, bắt buộc): Mã chứng từ mới (NVARCHAR(50)).
 * - @pLanguage (string, bắt buộc): Mã ngôn ngữ mới (NVARCHAR(5)).
 * - @pPh_formated_col_list (string, bắt buộc): Danh sách cột định dạng cho phần header (Ph) (NVARCHAR(1000)).
 * - @pCt_formated_col_list (string, bắt buộc): Danh sách cột định dạng cho phần detail (Ct) (NVARCHAR(1000)).
 * - @pDescription (string, bắt buộc): Mô tả chứng từ (NVARCHAR(50)).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - UPDATE bảng sysVoucherResx: cập nhật các cột Voucher_code, Language, Ph_formated_col_list, Ct_formated_col_list, Description với điều kiện Voucher_code = @pKey_Voucher_code AND Language = @pKey_Language.
 * - Lưu ý cập nhật cả mã chứng từ và mã ngôn ngữ (có thể thay đổi cả hai).
 * - Bắt lỗi: SET @pRet = @@error.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdVoucherResx::call([
 *     'pKey_Voucher_code' => 'AR1',
 *     'pKey_Language' => 'vi',
 *     'pVoucher_code' => 'AR1',
 *     'pLanguage' => 'en',
 *     'pPh_formated_col_list' => '<col name="SoCt" width="100"/>',
 *     'pCt_formated_col_list' => '<col name="MaKH" width="150"/>',
 *     'pDescription' => 'Phiếu thu khách hàng',
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
 * - Tham số @pKey_Voucher_code và @pKey_Language tạo thành khóa điều kiện duy nhất (có thể là khóa chính phức hợp).
 * - Có thể thay đổi cả mã chứng từ và ngôn ngữ (cập nhật thành bản ghi mới). Nếu thay đổi, cần đảm bảo không trùng với khóa chính khác.
 * - Cột Ph_formated_col_list và Ct_formated_col_list có thể chứa dữ liệu định dạng hiển thị (XML, JSON) cho các cột trong grid của phần header và detail.
 * - Cột Description lưu mô tả ngắn về chứng từ bằng ngôn ngữ tương ứng.
 * - Procedure không cập nhật các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Bảng sysVoucherResx lưu thông tin dịch thuật và cấu hình hiển thị cho chứng từ theo ngôn ngữ.
 */
class AsUpdVoucherResx
{
    /**
     * Gọi stored procedure asUpdVoucherResx.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    /**
     * Call stored procedure asUpdVoucherResx.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdVoucherResx', [
            'pKey_Voucher_code'     => $params['pKey_Voucher_code'] ?? null,
            'pKey_Language'         => $params['pKey_Language'] ?? null,
            'pVoucher_code'         => $params['pVoucher_code'] ?? null,
            'pLanguage'             => $params['pLanguage'] ?? null,
            'pPh_formated_col_list' => $params['pPh_formated_col_list'] ?? null,
            'pCt_formated_col_list' => $params['pCt_formated_col_list'] ?? null,
            'pDescription'          => $params['pDescription'] ?? null,
            'pRet'                  => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdVoucherResx with named parameters.
     */
    public static function callWithParams(?string $Key_Voucher_code = null, ?string $Key_Language = null, ?string $Voucher_code = null, ?string $Language = null, ?string $Ph_formated_col_list = null, ?string $Ct_formated_col_list = null, ?string $Description = null, ?int $Ret = null): Collection
    {
        $params = [
            'pKey_Voucher_code'     => $Key_Voucher_code,
            'pKey_Language'         => $Key_Language,
            'pVoucher_code'         => $Voucher_code,
            'pLanguage'             => $Language,
            'pPh_formated_col_list' => $Ph_formated_col_list,
            'pCt_formated_col_list' => $Ct_formated_col_list,
            'pDescription'          => $Description,
            'pRet'                  => $Ret,
        ];

        return self::call($params);
    }
}
