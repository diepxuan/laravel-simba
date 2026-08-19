<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDashGLKetQuaKinhDoanh
 *
 * Stored procedure: asDashGLKetQuaKinhDoanh
 * Mục đích: Tính toán kết quả kinh doanh tạm thời (doanh thu, giá vốn, chi phí, lợi nhuận, tồn quỹ) cho dashboard.
 * Procedure sử dụng dữ liệu từ bảng GLCT (General Ledger chi tiết) và hàm afDuCuoiTk để tính toán các chỉ tiêu tài chính:
 * - Doanh thu (tài khoản 511)
 * - Giá vốn (tài khoản 632)
 * - Chi phí bán hàng (tài khoản 641)
 * - Chi phí quản lý doanh nghiệp (tài khoản 642)
 * - Lợi nhuận (tổng hợp từ các chỉ tiêu trên)
 * - Tồn quỹ (dư cuối kỳ tài khoản 111)
 * Kết quả trả về theo tháng hiện tại (tháng của ngày hệ thống) và lũy kế từ đầu năm đến tháng hiện tại.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNam (int, bắt buộc): Năm cần lấy dữ liệu (tuy nhiên procedure sử dụng năm của ngày hệ thống GETDATE()).
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset gồm ba cột:
 *   - "Chỉ tiêu": Tên chỉ tiêu (Doanh thu, Giá vốn, CP bán hàng, CP QLDN, Lợi nhuận, Tồn quỹ).
 *   - "Trong kỳ": Giá trị phát sinh trong tháng hiện tại (tháng của ngày hệ thống).
 *   - "Lũy kế": Giá trị lũy kế từ đầu năm đến tháng hiện tại.
 * - Các dòng được sắp xếp theo mã số (ẩn).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDashGLKetQuaKinhDoanh::call([
 *     'pMa_cty' => '901',
 *     'pNam' => 2023,
 * ]);
 * // $result là collection/array các dòng kết quả.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng ngày hệ thống GETDATE() để xác định tháng/năm hiện tại, không sử dụng tham số @pNam.
 * - Các tài khoản mặc định: 511 (doanh thu), 632 (giá vốn), 641 (chi phí bán hàng), 642 (chi phí QLDN).
 * - Procedure tạo bảng tạm #kq để tính toán từng chỉ tiêu, sau đó cập nhật lũy kế.
 * - Hàm dbo.afDuCuoiTk được gọi để tính tồn quỹ (dư cuối kỳ tài khoản 111).
 * - Cột "Dau" dùng để xác định dấu (+/-) khi tổng hợp lợi nhuận.
 * - Giá trị NULL được chuyển thành 0.
 * - Cần đảm bảo bảng GLCT có dữ liệu cho tháng/năm hiện tại.
 */
class AsDashGLKetQuaKinhDoanh
{
    /**
     * Gọi stored procedure asDashGLKetQuaKinhDoanh
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (một resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asDashGLKetQuaKinhDoanh', $params);
    }
}