<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAUpdDmCongDoan
 *
 * Stored procedure: asSAUpdDmCongDoan
 * Mục đích: Sửa danh mục công đoạn.
 * Procedure cập nhật thông tin của một công đoạn sản xuất trong danh mục công đoạn.
 * Các thông tin có thể sửa: tên công đoạn, trạng thái sử dụng, người sửa, ngày sửa.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_congdoan (string, bắt buộc): Mã công đoạn (20 ký tự).
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pTen_cd (string, bắt buộc): Tên công đoạn (200 ký tự).
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
 * $result = AsSAUpdDmCongDoan::call([
 *     'pMa_cty' => '001',
 *     'pMa_congdoan' => 'CD001',
 *     'pMa_sanpham' => 'SP001',
 *     'pTen_cd' => 'Công đoạn cắt vải',
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
 * - Procedure chỉ cập nhật các trường Ten_cd, Ksd, Luser, Ldate của bảng SaDmCongDoan.
 * - Điều kiện update dựa trên ba khóa: Ma_cty, Ma_congdoan, Ma_sanpham.
 * - Ngày sửa (Ldate) được tự động cập nhật bằng GETDATE().
 * - Nếu không có bản ghi nào khớp điều kiện, procedure không báo lỗi nhưng @pRet sẽ là 0 (vì không có lỗi SQL). Cần kiểm tra số dòng bị ảnh hưởng thông qua kết nối database.
 */
class AsSAUpdDmCongDoan
{
    /**
     * Gọi stored procedure asSAUpdDmCongDoan
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSAUpdDmCongDoan', $params);
    }
}