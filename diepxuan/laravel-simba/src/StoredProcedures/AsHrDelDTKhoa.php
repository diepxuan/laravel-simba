<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsHrDelDTKhoa
 *
 * Stored procedure: asHrDelDTKhoa
 * Mục đích: Xóa khóa đào tạo khỏi bảng HrDTKhoa dựa trên mã công ty và mã khóa đào tạo.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pMa_kdt (string, bắt buộc): Mã khóa đào tạo (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả trả về: 0 nếu thành công, khác 0 nếu có lỗi (giá trị @@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsHrDelDTKhoa::call([
 *     'pMa_cty' => '001',
 *     'pMa_kdt' => 'KDT001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure này thực hiện DELETE trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 */
class AsHrDelDTKhoa
{
    /**
     * Gọi stored procedure asHrDelDTKhoa
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asHrDelDTKhoa', $params);
    }
}