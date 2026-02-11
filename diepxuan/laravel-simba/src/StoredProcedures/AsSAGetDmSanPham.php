<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAGetDmSanPham
 *
 * Stored procedure: asSAGetDmSanPham
 * Mục đích: Lấy danh mục sản phẩm.
 * Procedure truy vấn danh sách sản phẩm từ bảng danh mục sản phẩm, có thể lọc theo mã công ty và mã sản phẩm.
 * Nếu tham số là NULL, procedure sẽ sử dụng ký tự đại diện '%' để lấy tất cả.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định NULL): Mã công ty (3 ký tự). Nếu NULL hoặc không truyền, procedure sẽ lấy tất cả các công ty (sử dụng ký tự đại diện '%').
 * - @pMa_sanpham (string, tùy chọn, mặc định NULL): Mã sản phẩm (20 ký tự). Nếu NULL hoặc không truyền, procedure sẽ lấy tất cả sản phẩm (sử dụng ký tự đại diện '%').
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset chứa các cột:
 *   + Ma_cty: Mã công ty
 *   + Ma_sanpham: Mã sản phẩm
 *   + Ten_sp: Tên sản phẩm
 *   + Dvt: Đơn vị tính
 *   + Ksd: Trạng thái sử dụng (bit)
 *   + Cuser: Người tạo
 *   + Cdate: Ngày tạo
 *   + Luser: Người sửa cuối
 *   + Ldate: Ngày sửa cuối
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy danh mục sản phẩm của công ty '001'
 * $result = AsSAGetDmSanPham::call([
 *     'pMa_cty' => '001',
 * ]);
 * 
 * // Lấy sản phẩm cụ thể 'SP001' của công ty '001'
 * $result = AsSAGetDmSanPham::call([
 *     'pMa_cty' => '001',
 *     'pMa_sanpham' => 'SP001',
 * ]);
 * 
 * // Lấy tất cả sản phẩm của mọi công ty
 * $result = AsSAGetDmSanPham::call();
 * ```
 * 
 * Lưu ý:
 * - Nếu @pMa_cty là NULL, procedure sẽ gán giá trị '%', sau đó điều kiện WHERE sử dụng LIKE với @pMa_cty + '%'.
 * - Tương tự với @pMa_sanpham.
 * - Kết quả trả về có thể bao gồm dữ liệu của nhiều công ty và nhiều sản phẩm nếu các tham số là NULL.
 * - Điều kiện LIKE có thể ảnh hưởng hiệu năng nếu bảng lớn, nên sử dụng tham số cụ thể khi có thể.
 */
class AsSAGetDmSanPham
{
    /**
     * Gọi stored procedure asSAGetDmSanPham
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSAGetDmSanPham', $params);
    }
}