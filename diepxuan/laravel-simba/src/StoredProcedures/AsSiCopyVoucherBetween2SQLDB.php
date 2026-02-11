<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsSiCopyVoucherBetween2SQLDB
 *
 * Stored procedure: asSiCopyVoucherBetween2SQLDB
 * Mục đích: Copy số liệu chứng từ từ một database SQL sang một database SQL khác (có cùng cấu trúc).
 * Procedure thực hiện:
 *   1. Xác định database đích (DestDB) từ bảng sisetup dựa trên mã công ty.
 *   2. Xác định tên bảng chứng từ (ph_tbl_name, ct_tbl_name) từ bảng sidmct.
 *   3. Dynamic SQL: chèn dữ liệu từ bảng chứng từ nguồn vào bảng chứng từ đích (chỉ các chứng từ chưa tồn tại trong đích).
 * Điều kiện: hai database phải có cấu trúc giống nhau, mã công ty trùng nhau.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Dùng để lấy thông tin database đích và tên bảng.
 * - @pNgay1 (datetime, bắt buộc): Ngày bắt đầu khoảng thời gian chứng từ.
 * - @pNgay2 (datetime, bắt buộc): Ngày kết thúc khoảng thời gian chứng từ.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (3 ký tự). (Tham số này không được sử dụng trong body procedure, có thể dự phòng).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter. Chỉ thực hiện insert dữ liệu.
 * - Kết quả có thể kiểm tra qua số dòng bị ảnh hưởng (nếu cần).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsSiCopyVoucherBetween2SQLDB::call([
 *     'pMa_cty' => '001',
 *     'pNgay1' => '2025-01-01',
 *     'pNgay2' => '2025-12-31',
 *     'pMa_ct' => 'AP',
 * ]);
 * // Gọi thành công nếu không có lỗi SQL.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng dynamic SQL với sp_executesql, xây dựng câu lệnh INSERT dựa trên tên database và bảng lấy từ cấu hình.
 * - Chỉ copy các chứng từ có ngày chứng từ (ngay_ct) trong khoảng từ @pNgay1 đến @pNgay2 và chưa tồn tại trong database đích (kiểm tra qua stt_rec).
 * - Tên database đích được lấy từ cột vat_db của bảng sisetup, tên bảng chứng từ từ cột ph của bảng sidmct (cả bảng ph và ct đều lấy từ cùng một cột ph, có thể là lỗi thiết kế).
 * - Tham số @pMa_ct không được sử dụng trong logic, có thể là tham số dự phòng cho tính mở rộng.
 * - Cần đảm bảo kết nối database hiện tại có quyền truy cập cả hai database (nguồn và đích).
 */
class AsSiCopyVoucherBetween2SQLDB
{
    /**
     * Gọi stored procedure asSiCopyVoucherBetween2SQLDB
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là kết quả của INSERT).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asSiCopyVoucherBetween2SQLDB', $params);
    }
}