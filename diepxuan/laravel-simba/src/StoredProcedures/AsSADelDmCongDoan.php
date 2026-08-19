<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSADelDmCongDoan
 *
 * Stored procedure: asSADelDmCongDoan
 * Mục đích: Xóa danh mục công đoạn.
 * Procedure xóa một công đoạn khỏi danh mục công đoạn dựa trên mã công ty, mã công đoạn và mã sản phẩm.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_congdoan (string, bắt buộc): Mã công đoạn (20 ký tự).
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSADelDmCongDoan::call([
 *     'pMa_cty' => '001',
 *     'pMa_congdoan' => 'CD001',
 *     'pMa_sanpham' => 'SP001',
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
 * - Procedure thực hiện DELETE trên bảng SaDmCongDoan.
 * - Nếu không có bản ghi nào khớp điều kiện, DELETE không ảnh hưởng đến dòng nào, @pRet vẫn là 0 (không có lỗi SQL).
 * - Cần đảm bảo rằng không có ràng buộc khóa ngoại ngăn xóa (nếu có, @pRet sẽ là mã lỗi SQL).
 * - Người dùng cần có quyền DELETE trên bảng SaDmCongDoan.
 */
class AsSADelDmCongDoan
{
    /**
     * Gọi stored procedure asSADelDmCongDoan
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asSADelDmCongDoan', $params);
    }
}