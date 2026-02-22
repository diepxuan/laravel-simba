<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsLogPrint
 *
 * Stored procedure: asInsLogPrint
 * Mục đích: Ghi log in chứng từ/hóa đơn vào bảng LogPrint.
 * Procedure này được gọi khi in một chứng từ, lưu thông tin về lần in (người in, thời gian, số hóa đơn, số seri, v.v.).
 * Nó xác định xem đây có phải là lần in đầu tiên của hóa đơn (cùng số chứng từ và số seri) hay không, và gán cờ Is_Frist tương ứng.
 * 
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pusername (string, bắt buộc): Tên người dùng in (20 ký tự).
 * - @pmenuid (string, bắt buộc): Mã menu (20 ký tự). Menu chứa chức năng in.
 * - @pstt_rec (string, bắt buộc): Số thứ tự bản ghi (20 ký tự). Khóa chính của chứng từ.
 * - @pma_ct (string, bắt buộc): Mã chứng từ (3 ký tự). Loại chứng từ.
 * - @pso_ct (string, bắt buộc): Số chứng từ (20 ký tự). Số hóa đơn/chứng từ.
 * - @pso_seri (string, bắt buộc): Số seri (20 ký tự). Số seri của hóa đơn.
 * - @pngay_ct (smalldatetime, bắt buộc): Ngày chứng từ.
 * - @pma_mau (string, bắt buộc): Mã mẫu in (20 ký tự). Mẫu hóa đơn được sử dụng.
 * - @pdate (datetime, bắt buộc): Thời gian in (datetime). Có thể là thời điểm gọi in.
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả gọi có thể là số dòng affected (1 nếu insert thành công) hoặc empty.
 * 
 * Logic chi tiết:
 * 1. Khai báo biến @pCountPrinted (số lần đã in) và @pIs_Frist (cờ lần đầu).
 * 2. Đếm số bản ghi trong LogPrint với cùng ma_cty, So_ct, So_seri.
 * 3. Nếu @pCountPrinted = 0, đây là lần in đầu -> @pIs_Frist = 1, ngược lại = 0.
 * 4. INSERT vào bảng LogPrint với các giá trị truyền vào và @pIs_Frist.
 * 
 * Lưu ý:
 * - Bảng LogPrint lưu lịch sử in ấn, có thể dùng để kiểm soát số lần in, tránh in trùng.
 * - Cờ Is_Frist có thể dùng để đánh dấu hóa đơn gốc (lần in đầu) và các lần in sau (bản sao).
 * - Tham số @pdate có thể được truyền từ client (thời gian máy client) hoặc lấy GETDATE() trước khi gọi.
 * - Nên đảm bảo các tham số như so_ct, so_seri tồn tại trong hệ thống.
 * - Không có kiểm tra trùng lặp (có thể in nhiều lần cùng một chứng từ, mỗi lần đều ghi log).
 * - Có thể có khóa chính tự tăng (ID) hoặc kết hợp nhiều trường.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsLogPrint::call([
 *     'pma_cty' => '001',
 *     'pusername' => 'admin',
 *     'pmenuid' => 'MN001',
 *     'pstt_rec' => 'PO202500001',
 *     'pma_ct' => 'HD',
 *     'pso_ct' => 'HD001',
 *     'pso_seri' => 'AB/2025',
 *     'pngay_ct' => '2025-02-11',
 *     'pma_mau' => 'Mau01',
 *     'pdate' => '2025-02-11 10:30:00',
 * ]);
 * // $result có thể là số dòng affected hoặc empty
 * ```
 * 
 * Liên quan:
 * - Bảng LogPrint: lưu log in ấn.
 * - Các procedure khác: asGetLogPrint, asDelLogPrint (nếu có).
 */
class AsInsLogPrint
{
    /**
     * Gọi stored procedure asInsLogPrint
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là số dòng affected hoặc empty).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsLogPrint', $params);
    }
}