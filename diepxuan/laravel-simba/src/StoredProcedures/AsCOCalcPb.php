<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOCalcPb
 *
 * Stored procedure: asCOCalcPb
 * Mục đích: Thực hiện phân bổ và tạo ra các bút toán phân bổ trong GLCT (sổ cái chi tiết).
 * Procedure này thực hiện phân bổ chi phí từ các tài khoản phân bổ (tk_pb) sang các tài khoản nhận phân bổ (tk_nhan_pb)
 * dựa trên hệ số phân bổ được định nghĩa trong danh mục phân bổ (codmpb2) cho một kỳ tháng cụ thể.
 * 
 * Logic chính:
 * 1. Kiểm tra ngày phân bổ có sau ngày khóa sổ không, nếu trước thì thoát.
 * 2. Reset số tiền phân bổ trong danh mục phân bổ cho kỳ tháng.
 * 3. Tính tổng hệ số phân bổ từ danh sách đối tượng nhận phân bổ (codmpb2).
 * 4. Duyệt qua từng tài khoản phân bổ (tk_pb) có phát sinh trong kỳ (từ glct).
 * 5. Với mỗi tài khoản phân bổ, tính số tiền phân bổ cho từng đối tượng nhận dựa trên hệ số.
 * 6. Điều chỉnh chênh lệch do làm tròn vào đối tượng có hệ số lớn nhất.
 * 7. Tạo bút toán phân bổ (ghi nợ/ghi có) trong glct với mã chứng từ phân bổ (@pMa_ct).
 * 8. Cập nhật tổng số tiền đã phân bổ vào danh mục phân bổ (codmpb) và chi tiết (codmpb2).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNgay1 (string, bắt buộc): Ngày bắt đầu kỳ phân bổ (SMALLDATETIME, định dạng 'YYYY-MM-DD' hoặc 'MM/DD/YYYY').
 * - @pNgay2 (string, bắt buộc): Ngày kết thúc kỳ phân bổ (SMALLDATETIME). Đây cũng là ngày chứng từ phân bổ.
 * - @pId (int, bắt buộc): ID bút toán phân bổ (tham chiếu đến codmpb.id). Xác định danh mục phân bổ cần thực hiện.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ phân bổ (3 ký tự). Dùng để đánh dấu các bút toán phân bổ trong glct.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện (20 ký tự). Ghi lại vào cuser của bút toán.
 * 
 * Giá trị mặc định:
 * - Không có tham số nào có giá trị mặc định, tất cả đều bắt buộc.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày @pNgay1 trước ngày khóa sổ (ngay_ks trong sisetup), procedure sẽ thoát ngay mà không thực hiện.
 * - Nếu tổng hệ số phân bổ = 0 hoặc NULL, procedure sẽ thoát.
 * - Procedure có thể ném ngoại lệ SQL nếu có lỗi (ví dụ: không tìm thấy mã công ty, ID không tồn tại, ...).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOCalcPb::call([
 *     'pMa_cty' => '901',
 *     'pNgay1' => '2011-01-01',
 *     'pNgay2' => '2011-01-31',
 *     'pId' => 1,
 *     'pMa_ct' => 'CO2',
 *     'pUser' => 'Test',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt qua từng tài khoản phân bổ, có thể ảnh hưởng hiệu năng nếu số lượng lớn.
 * - Các bút toán phân bổ được tạo với ngày chứng từ là @pNgay2.
 * - Mỗi tài khoản phân bổ sẽ tạo một cặp bút toán (ghi nợ và ghi có) cho từng đối tượng nhận phân bổ.
 * - Bút toán phân bổ sẽ ghi đè lên các bút toán phân bổ cũ cùng ngày, cùng tài khoản và cùng mã chứng từ.
 * - Tháng/năm kế toán được xác định bằng hàm afThangTC, afNamTC dựa trên @pNgay2.
 * - Chỉ phân bổ các bút toán có mã chứng từ khác với @pMa_ct (tránh phân bổ chính các bút toán phân bổ).
 */
class AsCOCalcPb
{
    /**
     * Gọi stored procedure asCOCalcPb
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là null, không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOCalcPb', $params);
    }
}