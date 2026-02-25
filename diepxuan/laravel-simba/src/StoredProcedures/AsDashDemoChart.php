<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDashDemoChart
 *
 * Stored procedure: asDashDemoChart
 * Mục đích: Lấy dữ liệu biểu đồ demo cho dashboard.
 * Procedure trả về top 6 người giao dịch có tổng tiền lớn nhất từ bảng ARPH3 (Accounts Receivable Phieu 3),
 * lọc theo mã khách hàng và mã bộ phận (tùy chọn).
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên người dùng (không sử dụng trong điều kiện lọc, có thể dùng để phân quyền).
 * - @pMa_kh (string, tùy chọn, mặc định ''): Mã khách hàng (20 ký tự). Nếu cung cấp, sẽ lọc các giao dịch có mã khách hàng bắt đầu bằng chuỗi này.
 * - @pMa_bp (string, tùy chọn, mặc định ''): Mã bộ phận (20 ký tự). Hiện tại không sử dụng trong điều kiện lọc (có thể dự phòng).
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset gồm hai cột:
 *   - "Người giao dịch": Tên người giao dịch (nguoi_gd).
 *   - "Tổng tiền": Tổng số tiền (t_tien) lớn nhất của người đó.
 * - Chỉ lấy top 6 người có tổng tiền cao nhất (sắp xếp tự động bởi MAX(a.t_tien) giảm dần? Không có ORDER BY, có thể là thứ tự không xác định).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDashDemoChart::call([
 *     'pUserName' => 'HIEULQ',
 *     'pMa_kh' => 'KH001',
 *     'pMa_bp' => 'BP01',
 * ]);
 * // $result là collection/array các dòng kết quả.
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ lấy dữ liệu từ bảng ARPH3 (phiếu phải thu loại 3).
 * - Điều kiện lọc: nguoi_gd không rỗng và mã khách hàng LIKE @pMa_kh + '%'.
 * - Không có ORDER BY nên thứ tự kết quả có thể thay đổi tùy vào SQL Server.
 * - Tham số @pMa_bp không được sử dụng trong điều kiện WHERE, có thể dự phòng cho phiên bản sau.
 * - Tên cột trả về có ký tự Unicode (N'...'), cần chú ý khi xử lý ở frontend.
 */
class AsDashDemoChart
{
    /**
     * Gọi stored procedure asDashDemoChart
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (một resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asDashDemoChart', $params);
    }
}