<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsChkSoCt
 *
 * Stored procedure: asChkSoCt
 * Mục đích: Kiểm tra trùng số chứng từ (so_ct) trong hệ thống.
 * Procedure kiểm tra cấu hình kiểu trùng số chứng từ (theo tháng hoặc theo năm) và duyệt qua các bảng liên quan
 * để đếm số chứng từ có cùng số chứng từ, cùng loại chứng từ, cùng công ty, cùng năm (và tháng nếu cấu hình theo tháng).
 * 
 * Tham số (tất cả đều bắt buộc, không có giá trị mặc định):
 * - @pMa_cty (string): Mã công ty (nvarchar(3)).
 * - @pMa_ct (string): Mã chứng từ (loại chứng từ) (nvarchar(3)).
 * - @pStt_rec (string): Số thứ tự bản ghi (stt_rec) của chứng từ cần kiểm tra (nvarchar(20)).
 *   Dùng để loại trừ chính bản ghi hiện tại khi kiểm tra trùng.
 * - @pSo_ct (string): Số chứng từ cần kiểm tra (nvarchar(12)).
 * - @pNgay_Ct (smalldatetime): Ngày chứng từ (smalldatetime).
 * - @pRet (int, output): Tham số đầu ra (output parameter) chứa kết quả kiểm tra.
 *   Giá trị trả về:
 *     - 0: không trùng (số chứng từ là duy nhất theo điều kiện).
 *     - >0: số lượng chứng từ trùng (có thể là 1,2,...).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ trả về giá trị qua tham số output @pRet.
 * - Để lấy giá trị output parameter, cần sử dụng phương thức hỗ trợ output (DB::statement với binding OUTPUT).
 * 
 * Logic chi tiết:
 * 1. Lấy cấu hình `kieu_trung_so_ct` từ bảng sidmct với điều kiện ma_cty = @pMa_cty và ma_ct = @pMa_ct.
 *    - Giá trị 0: Cho phép trùng (không kiểm tra) -> procedure RETURN ngay.
 *    - Giá trị 1: Kiểu trùng theo tháng (cùng tháng, cùng năm).
 *    - Giá trị 2: Kiểu trùng theo năm (chỉ cùng năm).
 * 2. Chuẩn hóa @pMa_ct (uppercase, trim).
 * 3. Xác định năm (@year) và tháng (@month) từ @pNgay_Ct.
 * 4. Lấy mã chứng từ mẹ (@ma_ct_me) từ sidmct (nếu có).
 * 5. Lấy tên bảng (@tblName) từ sidmct cho mã chứng từ gốc.
 * 6. Mở cursor duyệt qua tất cả các chứng từ con (các bảng có ma_ct_me = @ma_ct_me) hoặc chính bảng gốc.
 * 7. Với mỗi bảng:
 *    - Xây dựng câu SQL động đếm số chứng từ trùng với điều kiện:
 *      + ma_cty = @pMa_cty
 *      + ma_ct = @pMa_ct (hoặc mã chứng từ con)
 *      + so_ct = @pSo_ct
 *      + stt_rec <> @pStt_rec (loại trừ chính bản ghi đang kiểm tra)
 *      + year(ngay_ct) = @year
 *      + Nếu kiểu trùng = 1: thêm điều kiện month(ngay_ct) = @month
 *    - Thực thi câu SQL động bằng sp_executesql, gán kết quả vào @pRet.
 * 8. Nếu @pRet <> 0 (đã tìm thấy trùng) thì dừng duyệt.
 * 9. Đóng cursor.
 * 
 * Kết quả cuối cùng: @pRet cho biết số lượng chứng từ trùng (ngoại trừ bản ghi hiện tại).
 * 
 * Ví dụ gọi (sử dụng DB facade trực tiếp):
 * ```php
 * $pRet = 0;
 * DB::statement('EXEC dbo.asChkSoCt @pMa_cty = ?, @pMa_ct = ?, @pStt_rec = ?, @pSo_ct = ?, @pNgay_Ct = ?, @pRet = ? OUTPUT',
 *     ['001', 'PNH', 'REC001', 'SO001', '2023-10-25', $pRet]);
 * // Sau khi gọi, $pRet sẽ chứa số lượng trùng.
 * 
 * if ($pRet > 0) {
 *     echo "Số chứng từ đã tồn tại (trùng).";
 * } else {
 *     echo "Số chứng từ hợp lệ (không trùng).";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tất cả tham số đều bắt buộc, không có giá trị mặc định.
 * - Procedure này thường được gọi trước khi lưu chứng từ (insert/update) để đảm bảo tính duy nhất của số chứng từ theo cấu hình.
 * - Cấu hình kiểu trùng số chứng từ được lưu trong bảng sidmct (cấu hình danh mục chứng từ).
 * - Nếu mã chứng từ có các chứng từ con (ma_ct_me), procedure sẽ kiểm tra cả các bảng con để tránh trùng xuyên bảng.
 * - Output parameter @pRet cần được xử lý đặc biệt do ProcedureCaller hiện tại chưa hỗ trợ output parameters.
 * - Ngày chứng từ được dùng để xác định năm/tháng, không phải ngày hiện tại.
 */
class AsChkSoCt
{
    /**
     * Gọi stored procedure asChkSoCt
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     *   Đối với output parameter @pRet, truyền giá trị null (sẽ không nhận được giá trị trả về).
     * @return mixed Kết quả trả về từ procedure (thường là null hoặc mảng rỗng do output parameter).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asChkSoCt', $params);
    }
}