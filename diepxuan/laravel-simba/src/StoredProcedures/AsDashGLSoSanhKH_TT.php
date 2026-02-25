<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDashGLSoSanhKH_TT
 *
 * Stored procedure: asDashGLSoSanhKH_TT
 * Mục đích: So sánh thực tế và kế hoạch ngân sách (budget) cho dashboard.
 * Procedure lấy dữ liệu kế hoạch từ bảng GLBudget (ngân sách theo tài khoản, tháng) và dữ liệu thực tế từ bảng GLCT (phát sinh thực tế).
 * Tính toán tỷ lệ hoàn thành kế hoạch (%).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNam (int, bắt buộc): Năm cần so sánh (tuy nhiên procedure sử dụng năm của ngày hệ thống GETDATE()).
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset gồm năm cột:
 *   - "Tk": Mã tài khoản.
 *   - "Ten_tk": Tên tài khoản (lấy từ bảng GLDMTK).
 *   - "Kế hoạch": Tổng kế hoạch ngân sách cả năm (tổng 12 tháng).
 *   - "Thực tế": Tổng phát sinh thực tế cả năm (ps_no hoặc ps_co tùy theo ttps_no_co).
 *   - "% hoàn thành": Tỷ lệ hoàn thành kế hoạch (thực tế / kế hoạch * 100), làm tròn 1 chữ số thập phân.
 * - Các dòng được sắp xếp theo mã tài khoản.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDashGLSoSanhKH_TT::call([
 *     'pMa_cty' => '901',
 *     'pNam' => 2023,
 * ]);
 * // $result là collection/array các dòng kết quả.
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng năm của ngày hệ thống GETDATE() để lọc dữ liệu, không sử dụng tham số @pNam.
 * - Bảng GLBudget lưu ngân sách theo từng tháng (cột t1..t12). Tổng kế hoạch là tổng 12 tháng.
 * - Phát sinh thực tế lấy từ bảng GLCT: nếu ttps_no_co = 'NO' thì lấy tổng ps_no, nếu 'CO' thì lấy tổng ps_co.
 * - Điều kiện join: b.tk like a.tk + '%' (tài khoản con có thể có nhiều cấp).
 * - Tên tài khoản được lấy từ bảng GLDMTK.
 * - Tỷ lệ hoàn thành tính bằng (thực tế / kế hoạch * 100), nếu kế hoạch = 0 có thể gây lỗi chia cho 0 (ty le sẽ NULL).
 * - Các giá trị tiền được cast sang bigint để đảm bảo đủ lớn.
 * - Cần đảm bảo dữ liệu ngân sách và phát sinh thực tế đã được nhập đầy đủ.
 */
class AsDashGLSoSanhKH_TT
{
    /**
     * Gọi stored procedure asDashGLSoSanhKH_TT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (một resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asDashGLSoSanhKH_TT', $params);
    }
}