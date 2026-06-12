<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdVoucherResx
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
     * Gọi stored procedure asUpdVoucherResx
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdVoucherResx', $params);
    }
}