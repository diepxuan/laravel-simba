<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsFAChkDTSD
 *
 * Stored procedure: asFAChkDTSD
 * Mục đích: Kiểm tra xem có được phép chuyển (di chuyển tài sản cố định) hay không.
 * Procedure đếm số lượng bản ghi trong bảng fadtsd thỏa mãn điều kiện: mã công ty, mã tài sản, ngày, loại di chuyển.
 * Trả về 0 nếu được phép chuyển (không có bản ghi trùng), khác 0 nếu không được phép chuyển (có ít nhất một bản ghi).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ts (string, bắt buộc): Mã tài sản cố định (20 ký tự).
 * - @pNgay (datetime, bắt buộc): Ngày di chuyển (kiểu SMALLDATETIME).
 * - @pLoai_dt (string, bắt buộc): Loại di chuyển (20 ký tự). Ví dụ: 'CHUYEN_KHO', 'THU_HOI', ...
 * - @pRet (int, output): Kết quả trả về: 0 - Được phép chuyển, <>0 - không được phép chuyển.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsFAChkDTSD::call([
 *     'pMa_cty' => '001',
 *     'pMa_ts' => 'TS001',
 *     'pNgay' => '2025-02-11',
 *     'pLoai_dt' => 'CHUYEN_KHO',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Được phép chuyển
 * } else {
 *     // Không được phép chuyển
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure này thường được gọi trước khi thực hiện di chuyển tài sản để đảm bảo không trùng lặp.
 * - Nếu có bất kỳ bản ghi nào trong bảng fadtsd khớp với điều kiện, coi như không được phép chuyển.
 * - Giá trị @pRet là số lượng bản ghi trùng (COUNT(*)).
 */
class AsFAChkDTSD
{
    /**
     * Gọi stored procedure asFAChkDTSD
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asFAChkDTSD', $params);
    }
}