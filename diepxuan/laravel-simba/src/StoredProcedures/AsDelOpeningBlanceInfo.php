<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelOpeningBlanceInfo
 *
 * Stored procedure: asDelOpeningBlanceInfo
 * Mục đích: Xóa một bản ghi từ bảng sysOpeningBalanceInfo (số dư đầu kỳ) dựa trên mã code_name.
 * Procedure thực hiện DELETE từ bảng sysOpeningBalanceInfo với điều kiện khớp Code_name.
 * 
 * Tham số:
 * - @pCode_name (string, bắt buộc): Mã code cần xóa (NVARCHAR(50)).
 * - @pRet (int, output): Kết quả thực thi: luôn gán 0 (thành công). Không dùng @@error.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công (luôn là 0 nếu không có lỗi runtime).
 * 
 * Logic chi tiết:
 * - DELETE FROM sysOpeningBalanceInfo WHERE Code_name = @pCode_name
 * - SET @pRet = 0 (luôn thành công)
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelOpeningBlanceInfo::call([
 *     'pCode_name' => 'OB001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công (hoặc không có bản ghi nào bị xóa)
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pCode_name bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột Code_name.
 * - Bảng sysOpeningBalanceInfo lưu thông tin số dư đầu kỳ (có thể là danh mục số dư tài khoản, công nợ...).
 * - Procedure luôn trả về @pRet = 0, không phản ánh lỗi SQL (nếu có lỗi runtime sẽ ném exception?).
 * - Cần đảm bảo không còn dữ liệu phụ thuộc trước khi xóa (ràng buộc khóa ngoại).
 * - Tên procedure có lỗi chính tả "Blance" (đúng ra là "Balance") nhưng phải giữ nguyên.
 */
class AsDelOpeningBlanceInfo
{
    /**
     * Gọi stored procedure asDelOpeningBlanceInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelOpeningBlanceInfo', $params);
    }
}