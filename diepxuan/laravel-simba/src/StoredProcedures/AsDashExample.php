<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDashExample
 *
 * Stored procedure: asDashExample
 * Mục đích: Ví dụ về hàm cung cấp dữ liệu cho Dashboard.
 * Procedure trả về top các tài khoản có tổng phát sinh (ps_no + ps_co) cao nhất trong kỳ (năm).
 * Sử dụng dynamic SQL để thay đổi số lượng dòng trả về.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Tuy nhiên không được sử dụng trong điều kiện lọc (có thể dự phòng).
 * - @pNam (int, bắt buộc): Năm cần lấy dữ liệu. Không được sử dụng trong điều kiện lọc (có thể dự phòng).
 * - @pTopSelect (int, tùy chọn, mặc định 5): Số dòng trả về (top N). Nếu bằng 0 sẽ được gán lại thành 5.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset gồm hai cột:
 *   - tk: Mã tài khoản.
 *   - ps: Tổng phát sinh (ps_no + ps_co) của tài khoản đó (không phân biệt năm, công ty).
 * - Kết quả được sắp xếp giảm dần theo ps (ORDER BY ps DESC).
 * - Chỉ lấy top N tài khoản có tổng phát sinh cao nhất.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDashExample::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2023,
 *     'pTopSelect' => 10,
 * ]);
 * // $result là collection/array các dòng kết quả.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng dynamic SQL (execute(@sql)) nên có nguy cơ SQL injection nếu tham số không được kiểm soát.
 * - Các tham số @pMa_cty và @pNam không được đưa vào điều kiện WHERE, có thể là dự phòng cho phiên bản sau.
 * - Dữ liệu lấy từ bảng glct (General Ledger chi tiết) mà không có điều kiện lọc theo công ty, năm, tháng, có thể trả về toàn bộ dữ liệu.
 * - Cần xem xét bổ sung điều kiện lọc để đảm bảo hiệu năng và tính đúng đắn.
 */
class AsDashExample
{
    /**
     * Gọi stored procedure asDashExample
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (một resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asDashExample', $params);
    }
}