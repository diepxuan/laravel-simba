<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAInsDmSanPham
 *
 * Stored procedure: asSAInsDmSanPham
 * Mục đích: Thêm danh mục sản phẩm.
 * Procedure thêm một sản phẩm mới vào danh mục sản phẩm.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pTen_sp (string, bắt buộc): Tên sản phẩm (200 ký tự).
 * - @pDvt (string, bắt buộc): Đơn vị tính (50 ký tự).
 * - @pCUser (string, bắt buộc): Tên người dùng thực hiện thêm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSAInsDmSanPham::call([
 *     'pMa_cty' => '001',
 *     'pMa_sanpham' => 'SP001',
 *     'pTen_sp' => 'Áo thun cổ tròn',
 *     'pDvt' => 'Cái',
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
 * - Procedure thực hiện INSERT vào bảng SaDmSanPham với các giá trị được cung cấp.
 * - Các trường Cdate và Ldate được gán bằng GETDATE() (thời điểm hiện tại).
 * - Trường Luser được gán bằng @pCUser (người tạo cũng là người sửa lần cuối).
 * - Trường Ksd không được cung cấp, có thể mặc định là 1 (đang sử dụng) nếu cấu trúc bảng cho phép.
 * - Nếu bản ghi đã tồn tại (trùng khóa chính Ma_cty, Ma_sanpham), sẽ xảy ra lỗi violation và @pRet sẽ là mã lỗi SQL.
 * - Cần đảm bảo mã sản phẩm là duy nhất trong công ty.
 */
class AsSAInsDmSanPham
{
    /**
     * Gọi stored procedure asSAInsDmSanPham
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSAInsDmSanPham', $params);
    }
}