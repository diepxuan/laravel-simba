<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAGetDmCongDoan
 *
 * Stored procedure: asSAGetDmCongDoan
 * Mục đích: Lấy danh mục công đoạn.
 * Procedure truy vấn danh sách công đoạn sản xuất, kết hợp với thông tin sản phẩm từ danh mục sản phẩm.
 * Có thể lọc theo mã công ty, mã sản phẩm, mã công đoạn. Nếu tham số là NULL, lấy tất cả.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định NULL): Mã công ty (3 ký tự). Nếu NULL, lấy tất cả công ty.
 * - @pMa_sanpham (string, tùy chọn, mặc định NULL): Mã sản phẩm (8 ký tự). Nếu NULL, lấy tất cả sản phẩm.
 * - @pMa_congdoan (string, tùy chọn, mặc định NULL): Mã công đoạn (8 ký tự). Nếu NULL, lấy tất cả công đoạn.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset chứa các cột:
 *   + Ma_cty: Mã công ty
 *   + Ma_congdoan: Mã công đoạn
 *   + Ma_sanpham: Mã sản phẩm
 *   + Ten_sp: Tên sản phẩm (lấy từ bảng SaDmSanPham)
 *   + Ten_cd: Tên công đoạn
 *   + Ksd: Trạng thái sử dụng (bit)
 *   + Cuser: Người tạo
 *   + Cdate: Ngày tạo
 *   + Luser: Người sửa cuối
 *   + Ldate: Ngày sửa cuối
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả công đoạn của công ty '001'
 * $result = AsSAGetDmCongDoan::call([
 *     'pMa_cty' => '001',
 * ]);
 * 
 * // Lấy công đoạn của sản phẩm 'SP001'
 * $result = AsSAGetDmCongDoan::call([
 *     'pMa_cty' => '001',
 *     'pMa_sanpham' => 'SP001',
 * ]);
 * 
 * // Lấy tất cả công đoạn của mọi công ty
 * $result = AsSAGetDmCongDoan::call();
 * ```
 * 
 * Lưu ý:
 * - Nếu tham số là NULL, procedure sẽ gán giá trị '%', sau đó điều kiện WHERE sử dụng LIKE với tham số + '%'.
 * - Join với bảng SaDmSanPham trên điều kiện b.Ma_cty = @pMa_cty AND a.Ma_SanPham = b.Ma_SanPham. Lưu ý @pMa_cty có thể là '%' khi join, có thể không khớp chính xác.
 * - Kết quả trả về có thể bao gồm dữ liệu của nhiều công ty, sản phẩm, công đoạn nếu các tham số là NULL.
 * - Điều kiện LIKE có thể ảnh hưởng hiệu năng nếu bảng lớn.
 */
class AsSAGetDmCongDoan
{
    /**
     * Gọi stored procedure asSAGetDmCongDoan
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSAGetDmCongDoan', $params);
    }
}