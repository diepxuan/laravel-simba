<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGLChuyenSdTk
 *
 * Stored procedure: asGLChuyenSdTk
 * Mục đích: Chuyển số dư khách hàng và tài khoản sang năm sau.
 * Procedure thực hiện chuyển số dư cuối kỳ của các tài khoản công nợ (khách hàng) và tài khoản tổng hợp sang năm tài chính tiếp theo.
 * Bao gồm số dư tiền Việt Nam và ngoại tệ, theo từng khách hàng, bộ phận, hợp đồng, công trình (tùy cấu hình).
 * Procedure kiểm tra ngày kế sách, nếu ngày đầu năm sau nhỏ hơn hoặc bằng ngày kế sách thì báo lỗi 50012.
 * Xóa dữ liệu số dư năm tiếp theo trước khi chèn mới.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNgay_cnt (string/datetime, bắt buộc): Ngày cuối năm trước (small datetime). Format: 'YYYY-MM-DD HH:mm:ss'.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsGLChuyenSdTk::call([
 *     'pMa_cty' => '001',
 *     'pNgay_cnt' => '2024-12-31 23:59:59',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Chuyển số dư thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng các bảng tạm #TmpKh, #TmpKhac, #TmpCn để tổng hợp số dư từ arcdkh và glct.
 * - Chỉ chuyển các tài khoản có cờ Tk_cn = 1 (tài khoản công nợ) trong bảng glDmTk.
 * - Số dư âm sẽ được chuyển thành số dư bên có (du_co).
 * - Cập nhật bảng arcdkh (số dư chi tiết khách hàng) và glcdtk (số dư tài khoản) cho năm mới.
 * - Gọi hàm afDuCuoiTk để lấy số dư cuối kỳ của tất cả tài khoản.
 * - Nếu ngày đầu năm sau <= ngày kế sách (ngay_ks trong sisetup) thì trả về lỗi 50012 (không cho phép chuyển).
 */
class AsGLChuyenSdTk
{
    /**
     * Gọi stored procedure asGLChuyenSdTk
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asGLChuyenSdTk', $params);
    }
}