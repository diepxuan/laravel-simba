<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetAllDAOInfo
 *
 * Stored procedure: asGetAllDAOInfo
 * Mục đích: Lấy toàn bộ thông tin từ bảng sysDAOInfo (cấu hình DAO - Data Access Object).
 * Procedure trả về tất cả các cột của bảng sysDAOInfo, thường dùng để lấy danh sách các kết nối DAO được định nghĩa trong hệ thống.
 * 
 * Tham số:
 * - Không có tham số.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với tất cả các cột của bảng sysDAOInfo.
 *   Cấu trúc bảng có thể bao gồm:
 *   - id (int): ID định danh DAO.
 *   - name (string): Tên DAO.
 *   - connection_string (string): Chuỗi kết nối cơ sở dữ liệu.
 *   - provider (string): Loại provider (SQL Server, Oracle, MySQL...).
 *   - is_default (bit): Cờ mặc định.
 *   - active (bit): Trạng thái hoạt động.
 *   - created_at (datetime): Thời điểm tạo.
 *   - updated_at (datetime): Thời điểm cập nhật.
 *   - Các cột khác tùy thiết kế bảng.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT * FROM sysDAOInfo (không có điều kiện WHERE).
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetAllDAOInfo::call();
 * // Hoặc
 * $rows = AsGetAllDAOInfo::call([]);
 * foreach ($rows as $row) {
 *     echo "DAO ID: {$row->id}, Tên: {$row->name}, Chuỗi kết nối: {$row->connection_string}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure này trả về toàn bộ bản ghi trong bảng sysDAOInfo, không có phân trang hay lọc.
 * - Nếu bảng có nhiều bản ghi, cần cân nhắc hiệu suất.
 * - Thông tin DAO thường dùng để cấu hình kết nối đa nguồn dữ liệu trong ứng dụng.
 */
class AsGetAllDAOInfo
{
    /**
     * Gọi stored procedure asGetAllDAOInfo
     *
     * @param array $params Mảng tham số (không cần thiết).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetAllDAOInfo', $params);
    }
}