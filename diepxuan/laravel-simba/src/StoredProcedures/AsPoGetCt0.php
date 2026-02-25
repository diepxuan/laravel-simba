<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPoGetCt0
 *
 * Stored procedure: asPOGetCT0
 * Mục đích: Lấy danh sách chi tiết hàng hóa (POCT0) theo mã công ty và số tham chiếu.
 * Procedure truy vấn bảng POCT0 với khả năng lọc linh hoạt, hỗ trợ tìm kiếm theo pattern.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định null): Mã công ty (3 ký tự). Nếu null sẽ chuyển thành '%' (tất cả).
 * - @pStt_rec (string, tùy chọn, mặc định null): Số tham chiếu (stt_rec) của chứng từ. Nếu null sẽ chuyển thành '%'.
 * - @pStruct (string, tùy chọn, mặc định '0'): Cấu trúc? Giá trị mặc định '0', nếu null cũng gán thành '0'.
 * 
 * Giá trị trả về:
 * - Resultset gồm các cột: ma_cty, stt_rec, stt_rec0, ma_vt, ten_vt, tk_vt, so_luong, dvt, so_luong_qd, ton, ton_all, ton_mua, ton_mua_all, ton_ban, ton_ban_all, stt_rec_dhb, stt_rec0_dhb, so_dhb, ma_kho, ten_kho, dia_chi, ma_vitri, ten_vitri, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * - Dữ liệu được lọc bằng điều kiện LIKE với pattern @pMa_cty + '%' và @pStt_rec + '%', đồng thời @pStruct phải bằng '0'.
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả chi tiết hàng hóa của công ty 001
 * $results = AsPoGetCt0::call([
 *     'pMa_cty' => '001',
 * ]);
 * // Lấy chi tiết của một chứng từ cụ thể
 * $results = AsPoGetCt0::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 * ]);
 * // Lấy tất cả chi tiết (không lọc)
 * $results = AsPoGetCt0::call([]);
 * ```
 * 
 * Lưu ý:
 * - Tham số @pStruct hiện luôn so sánh bằng '0', có thể dùng để mở rộng sau.
 * - Pattern tìm kiếm sử dụng LIKE, nên có thể dùng ký tự đại diện SQL (%, _) nếu truyền trực tiếp.
 * - Nếu muốn lấy chính xác mã công ty, nên truyền giá trị đầy đủ không kèm '%'.
 */
class AsPoGetCt0
{
    /**
     * Gọi stored procedure asPOGetCT0
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các đối tượng stdClass).
     */
    public static function call(array $params = [])
    {
        // Giá trị mặc định cho pStruct
        $defaultParams = ['pStruct' => '0'];
        $params = array_merge($defaultParams, $params);

        return ProcedureCaller::call('asPOGetCT0', $params);
    }
}