<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetDAOInfo
 *
 * Stored procedure: asGetDAOInfo
 * Mục đích: Lấy thông tin DAO (Data Access Object) theo tên bảng.
 * Procedure trả về tất cả các cột của bảng sysDAOInfo cho bảng chỉ định, dùng để cấu hình kết nối và mapping dữ liệu.
 * 
 * Tham số:
 * - @pTableName (string, bắt buộc): Tên bảng (NVARCHAR(50)).
 *   Không có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với tất cả các cột của bảng sysDAOInfo.
 *   Cấu trúc bảng có thể bao gồm:
 *   - Table_Name (string): Tên bảng.
 *   - DAO_Name (string): Tên DAO.
 *   - Connection_String (string): Chuỗi kết nối.
 *   - Provider (string): Loại provider.
 *   - Is_Default (bit): Cờ mặc định.
 *   - Active (bit): Trạng thái hoạt động.
 *   - Created_At (datetime): Thời điểm tạo.
 *   - Updated_At (datetime): Thời điểm cập nhật.
 *   - Các cột khác tùy thiết kế.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT * FROM sysDAOInfo WHERE Table_Name = @pTableName.
 * 2. Không có ORDER BY.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetDAOInfo::call([
 *     'pTableName' => 'incdvt',
 * ]);
 * // Kết quả có thể có nhiều bản ghi (nếu có nhiều DAO cho cùng bảng):
 * foreach ($rows as $row) {
 *     echo "Bảng: {$row->Table_Name}, DAO: {$row->DAO_Name}, Chuỗi kết nối: {$row->Connection_String}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pTableName là bắt buộc, không có giá trị mặc định.
 * - Bảng sysDAOInfo lưu cấu hình DAO cho từng bảng, giúp ứng dụng biết cách kết nối và truy vấn dữ liệu từ nhiều nguồn.
 * - Có thể có nhiều bản ghi cho cùng một Table_Name (nhiều DAO), nhưng thường là một.
 * - Nếu không tìm thấy bản ghi nào, resultset rỗng.
 */
class AsGetDAOInfo
{
    /**
     * Gọi stored procedure asGetDAOInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetDAOInfo', $params);
    }
}