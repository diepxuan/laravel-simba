<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsChkCodeExists
 *
 * Stored procedure: asChkCodeExists
 * Mục đích: Kiểm tra tồn tại mã trong danh mục. Dùng cho các thủ tục Insert Danh mục.
 * Chỉ dùng cho các danh mục có 1 trường mã (Khách hàng, Vật tư, Hợp đồng, Bộ phận, Kho...).
 * Gọi trực tiếp từ Base - FrameWork.dll.
 * 
 * Tham số:
 * - @pMa_Cty (string, tùy chọn): Mã công ty (nvarchar(3)).
 *   Giá trị mặc định: '111'. Khi không truyền, dùng giá trị mặc định.
 * - @pTable_name (sysname, tùy chọn): Tên bảng danh mục (sysname).
 *   Giá trị mặc định: 'ARDMKH'. Ví dụ: 'HRDmKhachHang', 'ARDMKH', 'CODMSPCT'.
 * - @pCode_name (sysname, tùy chọn): Tên cột mã trong bảng (sysname).
 *   Giá trị mặc định: 'MA_KH'. Ví dụ: 'MA_KH', 'MA_VT', 'MA_SPCT'.
 * - @pCode_value (string, tùy chọn): Giá trị mã cần kiểm tra tồn tại (nvarchar(20)).
 *   Giá trị mặc định: 'KH005'. Là giá trị mã cụ thể cần kiểm tra.
 * 
 * Giá trị trả về:
 * - Procedure trả về một số nguyên (single column, single row) là số lượng bản ghi thỏa mãn điều kiện.
 * - Kết quả > 0 nghĩa là mã đã tồn tại, = 0 nghĩa là chưa tồn tại.
 * 
 * Logic chi tiết:
 * 1. Nếu @pTable_name thuộc danh sách ('GLDMTK', 'GlMauBctc02', 'GlMauBctc03', 'GlMauBctc04') thì procedure trả về ngay (RETURN) mà không kiểm tra.
 * 2. Xây dựng câu SQL động dựa trên tên bảng, tên cột mã và giá trị mã.
 * 3. Điều kiện kiểm tra: (pCode_name LIKE @value + '%' OR @pCode_value LIKE pCode_name + '%')
 *    - Tìm các mã có phần đầu trùng với giá trị cần kiểm tra, hoặc giá trị cần kiểm tra có phần đầu trùng với mã có sẵn.
 *    - Điều này cho phép kiểm tra cả mã cha/con, mã có cấu trúc phân cấp.
 * 4. Điều kiện bổ sung: ma_cty = @pMa_Cty và pCode_name <> '' (khác chuỗi rỗng).
 * 5. Thực thi câu SQL động bằng sp_executesql, lấy số lượng bản ghi thỏa mãn.
 * 6. Trả về số lượng đó.
 * 
 * Ví dụ gọi:
 * ```php
 * $count = AsChkCodeExists::call([
 *     'pMa_Cty' => '001',
 *     'pTable_name' => 'HRDmKhachHang',
 *     'pCode_name' => 'MA_KH',
 *     'pCode_value' => 'KH001',
 * ]);
 * // Kết quả: 1 nếu mã KH001 đã tồn tại trong bảng HRDmKhachHang của công ty 001.
 * 
 * // Gọi với các tham số mặc định (kiểm tra mã 'KH005' trong bảng ARDMKH của công ty '111'):
 * $count = AsChkCodeExists::call();
 * 
 * // Gọi chỉ truyền mã công ty và giá trị mã:
 * $count = AsChkCodeExists::call([
 *     'pMa_Cty' => '002',
 *     'pCode_value' => 'VT001',
 * ]);
 * // Bảng mặc định 'ARDMKH', cột mã mặc định 'MA_KH' (có thể không phù hợp, nên truyền đủ).
 * ```
 * 
 * Lưu ý:
 * - Các tham số đều có giá trị mặc định, có thể gọi không tham số.
 * - Tuy nhiên trong thực tế, nên truyền đủ các tham số để đảm bảo kiểm tra đúng bảng, đúng cột.
 * - Procedure này được dùng trước khi thêm mới một bản ghi danh mục để tránh trùng mã.
 * - Điều kiện LIKE cho phép kiểm tra mã phân cấp, ví dụ mã 'A001' có tồn tại trong các mã 'A001.001', 'A001.002' không.
 * - Nếu bảng thuộc danh sách loại trừ (các bảng GL...), procedure không kiểm tra và trả về ngay (kết quả không xác định).
 */
class AsChkCodeExists
{
    /**
     * Gọi stored procedure asChkCodeExists
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (số lượng bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asChkCodeExists', $params);
    }
}