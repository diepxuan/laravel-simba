<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsHrDelChamCongKhac
 *
 * Stored procedure: asHrDelChamCongKhac
 * Mục đích: Xóa dữ liệu chấm công khác (ngoài giờ) của nhân viên theo mã công ty, năm, tháng, ngày và ID nhân viên.
 * Procedure thực hiện DELETE từ bảng HrChamCongKhac với điều kiện khớp các tham số.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pNam (int, bắt buộc): Năm chấm công (INT).
 * - @pThang (int, bắt buộc): Tháng chấm công (INT).
 * - @pNgay (int, bắt buộc): Ngày chấm công (INT).
 * - @pId (string, bắt buộc): ID nhân viên (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả trả về: 0 nếu thành công, khác 0 nếu có lỗi (giá trị @@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsHrDelChamCongKhac::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pThang' => 2,
 *     'pNgay' => 15,
 *     'pId' => 'NV001',
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
class AsHrDelChamCongKhac
{
    /**
     * Gọi stored procedure asHrDelChamCongKhac
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asHrDelChamCongKhac', $params);
    }
}