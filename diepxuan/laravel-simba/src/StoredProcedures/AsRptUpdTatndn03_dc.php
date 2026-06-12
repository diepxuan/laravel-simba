<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsRptUpdTatndn03_dc
 *
 * Stored procedure: asRptUpdTatndn03_dc
 * Mục đích: Cập nhật trường tiền (tien) trong bảng tatndn03_dc (báo cáo thuế thu nhập doanh nghiệp - mẫu 03 điều chỉnh).
 * Procedure thực hiện cập nhật giá trị tiền cho một bản ghi cụ thể trong bảng điều chỉnh tatndn03_dc dựa trên các điều kiện:
 * mã công ty, ngày bắt đầu, ngày kết thúc, mẫu số, mã số, số thứ tự.
 * 
 * Tham số:
 * - @pMa_Cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNgay1 (datetime, bắt buộc): Ngày bắt đầu kỳ báo cáo (kiểu SMALLDATETIME).
 * - @pNgay2 (datetime, bắt buộc): Ngày kết thúc kỳ báo cáo (kiểu SMALLDATETIME).
 * - @pMau (string, tùy chọn, mặc định '01'): Mẫu số (3 ký tự). Mặc định là '01'.
 * - @pMa_so (string, tùy chọn, mặc định ''): Mã số (20 ký tự). Mặc định rỗng.
 * - @pTien (decimal, bắt buộc): Giá trị tiền cần cập nhật (DECIMAL(19,4)).
 * - @pStt (string, bắt buộc): Số thứ tự (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsRptUpdTatndn03_dc::call([
 *     'pMa_Cty' => '001',
 *     'pNgay1' => '2025-01-01',
 *     'pNgay2' => '2025-03-31',
 *     'pMau' => '01',
 *     'pMa_so' => '03',
 *     'pTien' => 5000000.00,
 *     'pStt' => '1',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Bảng tatndn03_dc lưu trữ dữ liệu điều chỉnh của tờ khai thuế thu nhập doanh nghiệp mẫu 03.
 * - Các điều kiện WHERE bao gồm tất cả các cột khóa: ma_cty, ngay1, ngay2, mau, ma_so, stt.
 * - Giá trị tiền được cập nhật trực tiếp, không kiểm tra trước sự tồn tại của bản ghi.
 * - Nếu không có bản ghi nào khớp điều kiện, không có dòng nào được cập nhật nhưng @pRet vẫn là 0 (vì không có lỗi SQL).
 * - Sử dụng @@ERROR để lấy mã lỗi SQL sau lệnh UPDATE.
 */
class AsRptUpdTatndn03_dc
{
    /**
     * Gọi stored procedure asRptUpdTatndn03_dc
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asRptUpdTatndn03_dc', $params);
    }
}