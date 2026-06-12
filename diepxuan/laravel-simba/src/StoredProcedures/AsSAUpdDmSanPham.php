<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAUpdDmSanPham
 *
 * Stored procedure: asSAUpdDmSanPham
 * Mục đích: Sửa danh mục sản phẩm.
 * Procedure cập nhật thông tin của một sản phẩm trong danh mục sản phẩm.
 * Các thông tin có thể sửa: tên sản phẩm, đơn vị tính, trạng thái sử dụng, người sửa, ngày sửa.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pTen_sp (string, bắt buộc): Tên sản phẩm (200 ký tự).
 * - @pDvt (string, bắt buộc): Đơn vị tính (50 ký tự).
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
 * $result = AsSAUpdDmSanPham::call([
 *     'pMa_cty' => '001',
 *     'pMa_sanpham' => 'SP001',
 *     'pTen_sp' => 'Áo thun cổ tròn',
 *     'pDvt' => 'Cái',
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
 * - Procedure chỉ cập nhật các trường Ten_sp, Dvt, Ksd, Luser, Ldate của bảng SaDmSanPham.
 * - Điều kiện update dựa trên hai khóa: Ma_cty, Ma_sanpham.
 * - Ngày sửa (Ldate) được tự động cập nhật bằng GETDATE().
 * - Nếu không có bản ghi nào khớp điều kiện, procedure không báo lỗi nhưng @pRet sẽ là 0 (vì không có lỗi SQL). Cần kiểm tra số dòng bị ảnh hưởng thông qua kết nối database.
 * - Cần đảm bảo bản ghi đã tồn tại trước khi sửa (nếu không, không có hành động gì). Có thể sử dụng procedure asSAInsDmSanPham để thêm mới.
 */
class AsSAUpdDmSanPham
{
    /**
     * Gọi stored procedure asSAUpdDmSanPham
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSAUpdDmSanPham', $params);
    }
}