<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSysCopyDatabaseCompany
 *
 * Stored procedure: asSysCopyDatabaseCompany
 * Mục đích: Copy toàn bộ dữ liệu của một công ty từ một database nguồn sang một database đích.
 * Procedure thực hiện:
 *   1. Duyệt qua tất cả các bảng (BASE TABLE) trong database hiện tại (INFORMATION_SCHEMA.TABLES) thỏa điều kiện:
 *      - Không bắt đầu bằng 'Z%' (bảng tạm).
 *      - Không phải bảng 'SiStt'.
 *      - Không phải bảng hệ thống ('sys%').
 *      - Có cột 'ma_cty'.
 *   2. Với mỗi bảng:
 *      - Xây dựng danh sách cột (colList) từ INFORMATION_SCHEMA.COLUMNS.
 *      - Xóa dữ liệu cũ trong database đích cho công ty đó (delete where ma_cty = @Ma_CTy).
 *      - Chèn dữ liệu từ bảng nguồn sang bảng đích (insert select) với cùng điều kiện ma_cty.
 *   3. Nếu có lỗi, in tên bảng ra log (print).
 * Lưu ý: Procedure phải được thực thi trong database nguồn (@SourceDB) vì nó truy vấn INFORMATION_SCHEMA của database hiện tại.
 * 
 * Tham số:
 * - @SourceDB (sysname, bắt buộc): Tên database nguồn (database chứa dữ liệu gốc). Thực tế procedure không dùng tham số này trong truy vấn, mà dùng database hiện tại. Có thể tham số này để tham chiếu.
 * - @DestDB (sysname, bắt buộc): Tên database đích (database sẽ nhận dữ liệu). Được dùng trong câu DELETE và INSERT.
 * - @Ma_CTy (string, bắt buộc): Mã công ty (3 ký tự). Dữ liệu của công ty này sẽ được copy.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter. Chỉ thực hiện copy dữ liệu.
 * - Kết quả có thể kiểm tra qua thông báo lỗi (nếu có) qua PRINT.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSysCopyDatabaseCompany::call([
 *     'SourceDB' => 'SourceDBName',
 *     'DestDB' => 'DestDBName',
 *     'Ma_CTy' => '001',
 * ]);
 * // Gọi thành công nếu không có lỗi SQL.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt bảng, có thể ảnh hưởng hiệu năng với số lượng bảng lớn.
 * - Điều kiện lọc bảng: loại trừ bảng tạm (Z%), bảng SiStt, bảng hệ thống (sys%). Có thể cần điều chỉnh cho phù hợp với cấu trúc thực tế.
 * - Chỉ copy các bảng có cột ma_cty, đảm bảo dữ liệu được phân biệt theo công ty.
 * - Các bảng không có cột ma_cty sẽ bị bỏ qua.
 * - Thao tác DELETE trước INSERT có thể gây mất dữ liệu nếu có xung đột khóa ngoại. Cần đảm bảo thứ tự bảng phù hợp (tuy nhiên procedure không xử lý dependencies).
 * - Procedure không xử lý transaction, nếu lỗi giữa chừng có thể để lại dữ liệu không nhất quán.
 * - Tham số @SourceDB không được sử dụng trong dynamic SQL; có thể là tham số dự phòng hoặc để ghi chú.
 */
class AsSysCopyDatabaseCompany
{
    /**
     * Gọi stored procedure asSysCopyDatabaseCompany
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là kết quả của các câu lệnh DELETE/INSERT).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSysCopyDatabaseCompany', $params);
    }
}