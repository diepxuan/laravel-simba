<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPoGetCp2
 *
 * Stored procedure: asPOGetCP2
 * Mục đích: Lấy danh sách chi phí (POCP2) theo mã công ty và số tham chiếu.
 * Procedure truy vấn bảng POCP2 với khả năng lọc linh hoạt, hỗ trợ tìm kiếm theo pattern.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định null): Mã công ty (3 ký tự). Nếu null sẽ chuyển thành '%' (tất cả).
 * - @pStt_rec (string, tùy chọn, mặc định null): Số tham chiếu (stt_rec) của chứng từ. Nếu null sẽ chuyển thành '%'.
 * - @pStruct (string, tùy chọn, mặc định '0'): Cấu trúc? Giá trị mặc định '0', nếu null cũng gán thành '0'.
 * 
 * Giá trị trả về:
 * - Resultset gồm các cột: ma_cty, stt_rec, stt_rec0, ma_cp, ten_cp, tt_pb, tien_cp_nt, tien_cp, ts_gtgt, thue_gtgt_nt, thue_gtgt, tt_nt, tt.
 * - Dữ liệu được lọc bằng điều kiện LIKE với pattern @pMa_cty + '%' và @pStt_rec + '%', đồng thời @pStruct phải bằng '0'.
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả chi phí của công ty 001
 * $results = AsPoGetCp2::call([
 *     'pMa_cty' => '001',
 * ]);
 * // Lấy chi phí của một chứng từ cụ thể
 * $results = AsPoGetCp2::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 * ]);
 * // Lấy tất cả chi phí (không lọc)
 * $results = AsPoGetCp2::call([]);
 * ```
 * 
 * Lưu ý:
 * - Tham số @pStruct hiện luôn so sánh bằng '0', có thể dùng để mở rộng sau.
 * - Pattern tìm kiếm sử dụng LIKE, nên có thể dùng ký tự đại diện SQL (%, _) nếu truyền trực tiếp.
 * - Nếu muốn lấy chính xác mã công ty, nên truyền giá trị đầy đủ không kèm '%'.
 */
class AsPoGetCp2
{
    /**
     * Gọi stored procedure asPOGetCP2
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các đối tượng stdClass).
     */
    public static function call(array $params = [])
    {
        // Giá trị mặc định cho pStruct
        $defaultParams = ['pStruct' => '0'];
        $params = array_merge($defaultParams, $params);

        return ProcedureCaller::call('asPOGetCP2', $params);
    }
}