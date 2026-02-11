<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGLCrtKC
 *
 * Stored procedure: asGLCrtKC
 * Mục đích: Tạo bút toán kết chuyển tự động giữa hai tài khoản trong khoảng thời gian.
 * Procedure này thực hiện kết chuyển số dư (hoặc phát sinh) từ tài khoản nguồn sang tài khoản đích, dựa trên danh mục kết chuyển (gldmkc). Xóa các bút toán kết chuyển cũ cùng kỳ, sau đó gọi asGLCrtKC1 để tạo bút toán chi tiết.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)). Giá trị mặc định: '111'.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (nvarchar(3)). Giá trị mặc định: ''.
 * - @pNgay1 (datetime, bắt buộc): Ngày bắt đầu kỳ kết chuyển (smalldatetime). Giá trị mặc định: '20150101'.
 * - @pNgay2 (datetime, bắt buộc): Ngày kết thúc kỳ kết chuyển (smalldatetime). Giá trị mặc định: '20150131'.
 * - @pTk (string, bắt buộc): Tài khoản nguồn (nvarchar(20)). Giá trị mặc định: ''.
 * - @pTk_du (string, bắt buộc): Tài khoản đích (nvarchar(20)). Giá trị mặc định: ''.
 * - @pUser (string, bắt buộc): Người thực hiện (nvarchar(20)). Giá trị mặc định: ''.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * 1. Lấy stt_rec (số chứng từ) bằng cách gọi asGetSttRec.
 * 2. Lấy thông tin từ danh mục kết chuyển (gldmkc) gồm: stt, ten_bt, kc_bp, kc_hd, kc_spct, kc_phi, loai_kc, kc_dt_ps.
 * 3. Xác định năm, tháng kế toán từ ngày bắt đầu.
 * 4. Lấy số chứng từ (so_ct) bằng cách gọi asGetSoCt.
 * 5. Xác định mã chứng từ mẹ (ma_ct_me) và prefix từ sidmct, cập nhật sequence nếu phần đuôi là số.
 * 6. Xóa các bút toán kết chuyển cũ cùng kỳ bằng asGLDelKC.
 * 7. Gọi procedure asGLCrtKC1 với đầy đủ thông số để tạo bút toán chi tiết.
 * 8. Trả về mã lỗi SQL (@@error) qua @pRet.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsGLCrtKC::call([
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'GL3',
 *     'pNgay1' => '2023-01-01',
 *     'pNgay2' => '2023-01-31',
 *     'pTk' => '1331',
 *     'pTk_du' => '33311',
 *     'pUser' => 'hieulq',
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
 * - Procedure này chỉ tạo bút toán kết chuyển, không tính toán số liệu kết chuyển. Việc tính toán do asGLCrtKC1 thực hiện.
 * - Cần đảm bảo danh mục kết chuyển (gldmkc) đã được thiết lập trước với cặp tài khoản nguồn-đích.
 * - Số chứng từ được lấy từ bảng sidmct, cần có cấu hình prefix và sequence cho mã chứng từ mẹ.
 * - Bút toán kết chuyển thường được thực hiện vào cuối kỳ kế toán để kết chuyển doanh thu, chi phí, lãi lỗ.
 */
class AsGLCrtKC
{
    /**
     * Gọi stored procedure asGLCrtKC
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asGLCrtKC', $params);
    }
}