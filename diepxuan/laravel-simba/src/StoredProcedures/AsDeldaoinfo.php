<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDeldaoinfo
 *
 * Stored procedure: asDeldaoinfo
 * Mục đích: Xóa một bản ghi từ bảng sysDAOInfo (thông tin Data Access Object) dựa trên tên bảng.
 * Procedure thực hiện DELETE từ bảng sysDAOInfo với điều kiện khớp Table_name.
 * 
 * Tham số:
 * - @pTable_name (string, bắt buộc): Tên bảng (NVARCHAR(100)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM dbo.sysDAOInfo WHERE Table_name = @pTable_name
 * - SET @pRet = @@Error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDeldaoinfo::call([
 *     'pTable_name' => 'sysUserInfo',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, có lỗi SQL
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pTable_name bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột Table_name.
 * - Bảng sysDAOInfo lưu thông tin cấu hình DAO (Data Access Object) cho các bảng trong hệ thống (có thể ánh xạ bảng - class).
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDeldaoinfo
{
    /**
     * Gọi stored procedure asDeldaoinfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDeldaoinfo', $params);
    }
}