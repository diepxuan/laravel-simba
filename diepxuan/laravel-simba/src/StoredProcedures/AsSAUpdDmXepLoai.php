<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAUpdDmXepLoai
 *
 * Stored procedure: asSAUpdDmXepLoai
 * Mục đích: Sửa danh mục xếp loại.
 * Procedure cập nhật thông tin của một xếp loại trong danh mục xếp loại.
 * Các thông tin có thể sửa: hệ số, trạng thái sử dụng, người sửa, ngày sửa.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_xeploai (string, bắt buộc): Mã xếp loại (1 ký tự).
 * - @pHe_so (decimal, bắt buộc): Hệ số (decimal 19,4).
 * - @pKsd (bool, bắt buộc): Trạng thái sử dụng (0 = ngừng sử dụng, 1 = đang sử dụng).
 * - @pLUser (string, bắt buộc): Tên người dùng thực hiện sửa (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSAUpdDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'A',
 *     'pHe_so' => 2.5,
 *     'pKsd' => true,
 *     'pLUser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ cập nhật các trường He_so, Ksd, Luser, Ldate của bảng sadmxeploai.
 * - Điều kiện update dựa trên hai khóa: Ma_cty, Ma_xeploai.
 * - Ngày sửa (Ldate) được tự động cập nhật bằng GETDATE().
 * - Nếu không có bản ghi nào khớp điều kiện, procedure không báo lỗi nhưng @pRet sẽ là 0 (vì không có lỗi SQL). Cần kiểm tra số dòng bị ảnh hưởng thông qua kết nối database.
 * - Cần đảm bảo bản ghi đã tồn tại trước khi sửa (nếu không, không có hành động gì). Có thể sử dụng procedure asSAInsDmXepLoai để thêm mới.
 */
class AsSAUpdDmXepLoai
{
    /**
     * Gọi stored procedure asSAUpdDmXepLoai
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSAUpdDmXepLoai', $params);
    }
}