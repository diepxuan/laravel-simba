<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSADelDmXepLoai
 *
 * Stored procedure: asSADelDmXepLoai
 * Mục đích: Xóa danh mục xếp loại.
 * Procedure xóa một xếp loại khỏi danh mục xếp loại dựa trên mã công ty và mã xếp loại.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_xeploai (string, bắt buộc): Mã xếp loại (1 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSADelDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'C',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure thực hiện DELETE trên bảng `sadmxeploai`.
 * - Nếu không có bản ghi nào khớp điều kiện, DELETE không ảnh hưởng đến dòng nào, @pRet vẫn là 0 (không có lỗi SQL).
 * - Cần đảm bảo rằng không có ràng buộc khóa ngoại ngăn xóa (nếu có, @pRet sẽ là mã lỗi SQL).
 * - Người dùng cần có quyền DELETE trên bảng sadmxeploai.
 */
class AsSADelDmXepLoai
{
    /**
     * Gọi stored procedure asSADelDmXepLoai
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSADelDmXepLoai', $params);
    }
}