<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCACalLaiKU
 *
 * Stored procedure: asCACalLaiKU
 * Mục đích: Tính lãi khế ước trong kỳ.
 * Procedure thực hiện tính toán lãi phải trả và gốc phải trả cho các khế ước vay (loan agreements) trong một tháng/năm cụ thể.
 * Dựa trên các tham số: mã công ty, tháng, năm, mã chứng từ, mã khế ước, người dùng.
 * Procedure duyệt qua danh sách khế ước, tính toán lãi theo các phương pháp khác nhau (trả gốc lãi giảm dần, trả góp đều lãi suất kép, lãi suất đơn, ...)
 * và cập nhật vào bảng calaiku (lãi khế ước).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (int, bắt buộc): Tháng tính lãi (1-12).
 * - @pNam (int, bắt buộc): Năm tính lãi.
 * - @pMa_ct (string, tùy chọn, mặc định 'CA6'): Mã chứng từ (3 ký tự). Thường là 'CA6' cho khế ước.
 * - @pMa_ku (string, tùy chọn, mặc định ''): Mã khế ước (20 ký tự). Nếu rỗng sẽ xử lý tất cả khế ước.
 * - @pUser (string, tùy chọn, mặc định ''): Tên người dùng thực hiện (50 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCACalLaiKU::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_ct' => 'CA6',
 *     'pMa_ku' => 'KU001',
 *     'pUser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Tính lãi thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng cursor để duyệt qua từng khế ước, có thể ảnh hưởng hiệu năng nếu số lượng lớn.
 * - Các phương pháp tính lãi:
 *   1. Trả gốc và lãi theo dư nợ giảm dần.
 *   2. Trả góp đều hàng tháng theo lãi suất kép.
 *   3. Trả góp đều theo lãi suất đơn.
 *   4. Trả góp đều, lãi tính trên dư nợ giảm dần hàng tháng.
 * - Procedure cập nhật bảng calaiku, nếu bản ghi đã tồn tại sẽ kiểm tra cờ sua_lai, sua_goc để quyết định cập nhật.
 * - Ngày tính lãi được xác định bằng hàm afNgay_CTTC (ngày cuối tháng của kỳ).
 */
class AsCACalLaiKU
{
    /**
     * Gọi stored procedure asCACalLaiKU
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asCACalLaiKU', $params);
    }
}