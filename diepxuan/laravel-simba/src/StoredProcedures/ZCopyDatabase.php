<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class ZCopyDatabase
 *
 * Stored procedure: zCopyDatabase
 * Mục đích: Copy toàn bộ dữ liệu từ một database nguồn sang một database đích (toàn bộ bảng).
 * Procedure thực hiện:
 *   1. Duyệt qua tất cả các bảng (BASE TABLE) trong database hiện tại (INFORMATION_SCHEMA.TABLES) thỏa điều kiện:
 *      - Không bắt đầu bằng 'Z%' (bảng tạm).
 *      - Không phải bảng 'SiStt'.
 *      - Không phải bảng hệ thống ('sys%').
 *      - Không nằm trong smsystables (có thể là bảng hệ thống của ứng dụng).
 *   2. Với mỗi bảng:
 *      - Xây dựng danh sách cột (colList) từ INFORMATION_SCHEMA.COLUMNS.
 *      - Chèn dữ liệu từ bảng nguồn sang bảng đích (insert select) toàn bộ dữ liệu (không có điều kiện where).
 *   3. Nếu có lỗi, in tên bảng ra log (print).
 * Lưu ý: Procedure phải được thực thi trong database nguồn (@sourcedb) vì nó truy vấn INFORMATION_SCHEMA của database hiện tại.
 * 
 * Tham số:
 * - @sourcedb (sysname, bắt buộc): Tên database nguồn (database chứa dữ liệu gốc). Thực tế procedure không dùng tham số này trong truy vấn, mà dùng database hiện tại. Có thể tham số này để tham chiếu.
 * - @destdb (sysname, bắt buộc): Tên database đích (database sẽ nhận dữ liệu). Được dùng trong câu INSERT.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter. Chỉ thực hiện copy dữ liệu.
 * - Kết quả có thể kiểm tra qua thông báo lỗi (nếu có) qua PRINT.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = ZCopyDatabase::call([
 *     'sourcedb' => 'SourceDBName',
 *     'destdb' => 'DestDBName',
 * ]);
 * // Gọi thành công nếu không có lỗi SQL.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt bảng, có thể ảnh hưởng hiệu năng với số lượng bảng lớn.
 * - Điều kiện lọc bảng: loại trừ bảng tạm (Z%), bảng SiStt, bảng hệ thống (sys%), và bảng trong smsystables. Có thể cần điều chỉnh cho phù hợp với cấu trúc thực tế.
 * - Copy toàn bộ dữ liệu, không có điều kiện lọc theo mã công ty hay bất kỳ tiêu chí nào.
 * - Thao tác INSERT không xóa dữ liệu cũ trong bảng đích, có thể gây trùng khóa chính. Cần đảm bảo bảng đích trống hoặc có cơ chế merge.
 * - Procedure không xử lý transaction, nếu lỗi giữa chừng có thể để lại dữ liệu không nhất quán.
 * - Tham số @sourcedb không được sử dụng trong dynamic SQL; có thể là tham số dự phòng hoặc để ghi chú.
 */
class ZCopyDatabase
{
    /**
     * Gọi stored procedure zCopyDatabase
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là kết quả của các câu lệnh INSERT).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('zCopyDatabase', $params);
    }
}