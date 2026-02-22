<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetArkhInfo_SO
 *
 * Stored procedure: asGetArkhInfo_SO
 * Mục đích: Lấy thông tin khách hàng cho Hóa đơn mã chứng từ = 'SO3'.
 * Procedure trả về các chỉ số tài chính liên quan đến khách hàng trong một tháng/năm cụ thể:
 *   - Dư hiện thời (tổng dư nợ)
 *   - Hóa đơn (tổng số hóa đơn và tổng tiền)
 *   - Hóa đơn chưa tất toán (số lượng và tổng dư)
 *   - Phiếu thu (số lượng và tổng tiền)
 *   - Hóa đơn cuối (hóa đơn gần nhất)
 *   - Phiếu thu cuối (phiếu thu gần nhất)
 * Dữ liệu được tổng hợp từ các bảng arcdkh13, arTt, arph1.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 *   Không có giá trị mặc định.
 * - @pMa_kh (string, bắt buộc): Mã khách hàng (NVARCHAR(20)).
 *   Không có giá trị mặc định.
 * - @pThang (int, bắt buộc): Tháng cần lấy dữ liệu.
 *   Không có giá trị mặc định.
 * - @pNam (int, bắt buộc): Năm cần lấy dữ liệu.
 *   Không có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma (string): Mã loại chỉ số ('DUHT', 'HD', 'HDCTT', 'PT', 'HDCUOI', 'PTCUOI').
 *   - mo_ta (string): Mô tả tiếng Việt.
 *   - sl (money hoặc int): Số lượng (số hóa đơn, phiếu thu) hoặc 0.
 *   - tien (money): Tổng tiền (VND).
 *   - tien_nt (money): Tổng tiền ngoại tệ.
 *   - ngay (smalldatetime): Ngày của bản ghi (01/01/1900 cho các chỉ số tổng hợp, ngày thực cho bản ghi cuối).
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. Dư hiện thời: SELECT từ arcdkh13, tổng hợp du, du_nt (dư nợ hiện tại).
 * 2. Hóa đơn: SELECT từ arTt, đếm số hóa đơn và tổng t_tt, t_tt_nt trong tháng/năm, mã chứng từ 'SO3' hoặc 'SO5'.
 * 3. Hóa đơn chưa tất toán: tương tự nhưng với điều kiện tat_toan <> '1'.
 * 4. Phiếu thu: SELECT từ arph1, đếm số phiếu thu và tổng t_tien, t_tien_nt trong tháng/năm (sử dụng hàm afNamTC, afThangTC để lấy năm/tháng tài chính), mã chứng từ 'AR1' hoặc 'AR4'.
 * 5. Hóa đơn cuối: lấy bản ghi hóa đơn gần nhất (TOP 1 ORDER BY ngay DESC) cùng tháng/năm.
 * 6. Phiếu thu cuối: lấy bản ghi phiếu thu gần nhất cùng tháng/năm.
 * 7. UNION/UNION ALL kết hợp các kết quả.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetArkhInfo_SO::call([
 *     'pMa_cty' => '001',
 *     'pMa_kh' => 'KH001',
 *     'pThang' => 10,
 *     'pNam' => 2023,
 * ]);
 * foreach ($rows as $row) {
 *     echo "Chỉ số: {$row->ma}, Mô tả: {$row->mo_ta}, Tiền: {$row->tien}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tất cả tham số đều bắt buộc, không có giá trị mặc định.
 * - Dữ liệu được lọc theo năm/tháng tài chính (sử dụng hàm afNamTC, afThangTC) đối với phiếu thu.
 * - Các chỉ số 'HDCUOI' và 'PTCUOI' chỉ trả về một bản ghi duy nhất (gần nhất).
 * - Cột sl có thể là kiểu money hoặc int tùy loại chỉ số.
 * - Cột ngay với giá trị 01/01/1900 cho các chỉ số tổng hợp, ngày thực cho bản ghi cuối.
 */
class AsGetArkhInfo_SO
{
    /**
     * Gọi stored procedure asGetArkhInfo_SO
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetArkhInfo_SO', $params);
    }
}