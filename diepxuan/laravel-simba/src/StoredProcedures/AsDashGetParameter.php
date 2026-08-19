<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDashGetParameter
 *
 * Stored procedure: asDashGetParameter
 * Mục đích: Lấy danh sách tham số và mô tả tham số của một stored procedure khác.
 * Procedure phục vụ cho việc nhập giá trị default cho các tham số khi gọi stored procedure từ giao diện.
 * Procedure thực hiện:
 * 1. Lấy định nghĩa stored procedure từ INFORMATION_SCHEMA.ROUTINES.
 * 2. Làm sạch mã nguồn (loại bỏ khoảng trắng dư, tab, dòng trống, dấu phẩy, comment không cần thiết).
 * 3. Lấy danh sách tham số từ INFORMATION_SCHEMA.PARAMETERS.
 * 4. Duyệt từng dòng mã nguồn để tìm comment mô tả tham số (dòng bắt đầu bằng @p và có '--').
 * 5. Trả về kết quả gồm tên tham số, kiểu dữ liệu, độ dài, mô tả, và một cột DEFAULT_VALUE trống.
 * 
 * Tham số:
 * - @pSp_name (string, bắt buộc): Tên stored procedure cần lấy tham số (ví dụ: 'asDashGLKetQuaKinhDoanh').
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset gồm các cột:
 *   - PARAMETER_NAME: Tên tham số (có tiền tố '@').
 *   - DATA_TYPE: Kiểu dữ liệu (nvarchar, int, datetime...).
 *   - CHARACTER_MAXIMUM_LENGTH: Độ dài tối đa (cho kiểu chuỗi).
 *   - DESCRIPTION: Mô tả tham số được trích xuất từ comment trong mã nguồn.
 *   - DEFAULT_VALUE: Cột trống (dự phòng cho giá trị mặc định).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDashGetParameter::call([
 *     'pSp_name' => 'asDashGLKetQuaKinhDoanh',
 * ]);
 * // $result là collection/array các dòng kết quả.
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ hoạt động với stored procedure có định nghĩa trong cùng database (INFORMATION_SCHEMA).
 * - Việc trích xuất mô tả dựa trên cú pháp comment '--' ngay sau khai báo tham số. Nếu không có comment, DESCRIPTION sẽ rỗng.
 * - Các tham số đặc biệt (@pMa_cty, @pNgay1, @pNgay2) được bỏ qua không cập nhật mô tả (có lẽ vì đã biết trước).
 * - Việc làm sạch mã nguồn có thể làm mất định dạng gốc, nhưng không ảnh hưởng đến kết quả.
 * - Cột DEFAULT_VALUE luôn trống, có thể dùng để người dùng nhập giá trị mặc định.
 * - Procedure sử dụng PRINT trong vòng lặp (có thể gây output message), nhưng không ảnh hưởng đến resultset.
 */
class AsDashGetParameter
{
    /**
     * Gọi stored procedure asDashGetParameter
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (một resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asDashGetParameter', $params);
    }
}