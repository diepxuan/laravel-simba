<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAInsDmXepLoai
 *
 * Stored procedure: asSAInsDmXepLoai
 * Mục đích: Thêm mới danh mục xếp loại.
 * Procedure thêm một xếp loại mới vào danh mục xếp loại.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_xeploai (string, bắt buộc): Mã xếp loại (1 ký tự).
 * - @pHe_so (decimal, bắt buộc): Hệ số (decimal 19,4).
 * - @pCUser (string, bắt buộc): Tên người dùng thực hiện thêm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSAInsDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'A',
 *     'pHe_so' => 2.5,
 *     'pCUser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure thực hiện INSERT vào bảng sadmxeploai với các giá trị được cung cấp.
 * - Các trường cdate và ldate được gán bằng GETDATE() (thời điểm hiện tại).
 * - Trường luser được gán bằng @pCUser (người tạo cũng là người sửa lần cuối).
 * - Trường ksd không được cung cấp, có thể mặc định là 1 (đang sử dụng) nếu cấu trúc bảng cho phép.
 * - Nếu bản ghi đã tồn tại (trùng khóa chính Ma_cty, Ma_xeploai), sẽ xảy ra lỗi violation và @pRet sẽ là mã lỗi SQL.
 * - Cần đảm bảo mã xếp loại là duy nhất trong công ty.
 */
class AsSAInsDmXepLoai
{
    /**
     * Gọi stored procedure asSAInsDmXepLoai
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSAInsDmXepLoai', $params);
    }
}