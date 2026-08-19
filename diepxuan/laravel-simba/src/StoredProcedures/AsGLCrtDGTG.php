<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGLCrtDGTG
 *
 * Stored procedure: asGLCrtDGTG
 * Mục đích: Tạo bút toán đánh giá tỷ giá (đánh giá lại chênh lệch tỷ giá) cho các tài khoản ngoại tệ trong khoảng thời gian.
 * Procedure này thực hiện việc tạo các bút toán đánh giá tỷ giá dựa trên danh mục đánh giá tỷ giá (gldmdgtg), xóa các bút toán đánh giá tỷ giá cũ cùng kỳ, sau đó gọi procedure chi tiết asGLCrtDGTG1 để tạo bút toán.
 * 
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (nvarchar(3)). Không có giá trị mặc định.
 * - @pma_ct (string, bắt buộc): Mã chứng từ (nvarchar(3)). Ví dụ: 'GL5'. Không có giá trị mặc định.
 * - @pma_nt (string, bắt buộc): Mã ngoại tệ (nvarchar(3)). Không có giá trị mặc định.
 * - @pstt (int, bắt buộc): Số thứ tự danh mục đánh giá tỷ giá (stt trong bảng gldmdgtg). Không có giá trị mặc định.
 * - @pngay1 (datetime, bắt buộc): Ngày bắt đầu kỳ đánh giá (smalldatetime). Không có giá trị mặc định.
 * - @pngay2 (datetime, bắt buộc): Ngày kết thúc kỳ đánh giá (smalldatetime). Không có giá trị mặc định.
 * - @puser (string, bắt buộc): Người thực hiện (nvarchar(20)). Không có giá trị mặc định.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * 1. Xác định tháng từ ngày kết thúc, định dạng 2 chữ số.
 * 2. Tạo số chứng từ (stt_rec) theo cấu trúc: Mã công ty + ws_id (từ sisetup) + mã chứng từ + số thứ tự (7 ký tự) + tháng + năm.
 * 3. Lấy thông tin danh mục đánh giá tỷ giá từ bảng gldmdgtg: tên bút toán, tài khoản đánh giá tỷ giá, tài khoản lãi chênh lệch tỷ giá, tài khoản lỗ chênh lệch tỷ giá, tài khoản chênh lệch tỷ giá chưa xác định, các cờ đánh giá theo đối tượng (khách hàng, bộ phận, hợp đồng, sản phẩm công trình, phí), loại đánh giá.
 * 4. Lấy số chứng từ (so_ct) bằng cách gọi asGetSoCt.
 * 5. Xác định mã chứng từ mẹ (ma_ct_me) và prefix từ sidmct, cập nhật sequence nếu phần đuôi là số.
 * 6. Xóa các bút toán đánh giá tỷ giá cũ cùng kỳ bằng asGLDelDGTG.
 * 7. Gọi procedure asGLCrtDGTG1 với đầy đủ thông số để tạo bút toán chi tiết.
 * 8. Trả về mã lỗi SQL (@@error) qua @pRet.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsGLCrtDGTG::call([
 *     'pma_cty' => '001',
 *     'pma_ct' => 'GL5',
 *     'pma_nt' => 'USD',
 *     'pstt' => 1,
 *     'pngay1' => '2023-01-01',
 *     'pngay2' => '2023-01-31',
 *     'puser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Tạo bút toán thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure này chỉ tạo bút toán đánh giá tỷ giá, không tính toán số liệu chênh lệch tỷ giá. Việc tính toán do asGLCrtDGTG1 thực hiện.
 * - Cần đảm bảo danh mục đánh giá tỷ giá (gldmdgtg) đã được thiết lập trước.
 * - Số chứng từ được lấy từ bảng sidmct, cần có cấu hình prefix và sequence cho mã chứng từ mẹ.
 * - Bút toán đánh giá tỷ giá thường được thực hiện vào cuối kỳ kế toán.
 */
class AsGLCrtDGTG
{
    /**
     * Gọi stored procedure asGLCrtDGTG
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asGLCrtDGTG', $params);
    }
}