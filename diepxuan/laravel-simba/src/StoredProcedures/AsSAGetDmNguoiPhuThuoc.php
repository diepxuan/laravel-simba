<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSAGetDmNguoiPhuThuoc
 *
 * Stored procedure: asSAGetDmNguoiPhuThuoc
 * Mục đích: Lấy danh mục người phụ thuộc.
 * Procedure truy vấn danh sách người phụ thuộc của nhân viên, kết hợp với thông tin nhân viên từ bảng HrHSNS.
 * Cho phép lọc theo mã công ty (có thể NULL để lấy tất cả).
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định NULL): Mã công ty (3 ký tự). Nếu NULL hoặc không truyền, procedure sẽ lấy tất cả các công ty (sử dụng ký tự đại diện '%').
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset chứa các cột:
 *   + Ma_cty: Mã công ty
 *   + Thang: Tháng (có thể là tháng của kỳ tính người phụ thuộc)
 *   + Nam: Năm
 *   + Ma_nv: Mã nhân viên
 *   + Ho_ten: Họ tên nhân viên (lấy từ bảng HrHSNS)
 *   + So_npt: Số người phụ thuộc
 *   + Ghi_chu: Ghi chú
 *   + Cuser: Người tạo
 *   + Cdate: Ngày tạo
 *   + Luser: Người sửa cuối
 *   + Ldate: Ngày sửa cuối
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy danh mục người phụ thuộc của công ty '001'
 * $result = AsSAGetDmNguoiPhuThuoc::call([
 *     'pMa_cty' => '001',
 * ]);
 * 
 * // Lấy tất cả người phụ thuộc của mọi công ty
 * $result = AsSAGetDmNguoiPhuThuoc::call();
 * ```
 * 
 * Lưu ý:
 * - Nếu @pMa_cty là NULL, procedure sẽ gán giá trị '%', sau đó điều kiện WHERE sử dụng LIKE với @pMa_cty + '%'.
 * - Điều kiện join với bảng HrHSNS sử dụng ON b.Ma_cty = @pMa_cty AND a.Ma_nv = b.Ma_nvns. Lưu ý rằng @pMa_cty có thể là '%' khi join, có thể không khớp chính xác.
 * - Kết quả trả về có thể bao gồm dữ liệu của nhiều công ty nếu @pMa_cty là NULL.
 * - Cần đảm bảo bảng HrHSNS có dữ liệu tương ứng.
 */
class AsSAGetDmNguoiPhuThuoc
{
    /**
     * Gọi stored procedure asSAGetDmNguoiPhuThuoc
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSAGetDmNguoiPhuThuoc', $params);
    }
}