<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPoGetCt1
 *
 * Stored procedure: asPOGetCT1
 * Mục đích: Lấy danh sách chi tiết hàng hóa (POCT1) theo mã công ty, số tham chiếu và số thứ tự dòng.
 * Procedure truy vấn bảng POCT1 với khả năng lọc linh hoạt, hỗ trợ tìm kiếm theo pattern.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định null): Mã công ty (3 ký tự). Nếu null sẽ chuyển thành '%' (tất cả).
 * - @pStt_rec (string, tùy chọn, mặc định null): Số tham chiếu (stt_rec) của chứng từ. Nếu null sẽ chuyển thành '%'.
 * - @pStt_rec0 (string, tùy chọn, mặc định null): Số thứ tự dòng (stt_rec0) của chi tiết. Nếu null sẽ chuyển thành '%'.
 * - @pStruct (string, tùy chọn, mặc định '0'): Cấu trúc? Giá trị mặc định '0', nếu null cũng gán thành '0'.
 * 
 * Giá trị trả về:
 * - Resultset gồm các cột: ma_cty, stt_rec, stt_rec0, stt_rec_pdn, stt_rec0_pdn, so_pdn, ma_vt, ten_vt, ton_kho, tk_vt, tk_thue, so_luong, dvt, so_luong_qd, gia_nt0, gia0, tien_nt0, tien0, ts_gtgt, thue_gtgt_nt, thue_gtgt, tt_nt, tt, sl_nhap, sl_nhap_qd, ton, ton_all, ton_mua, ton_mua_all, ton_ban, ton_ban_all, ma_kho, ten_kho, dia_chi, ma_vitri, ten_vitri, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * - Dữ liệu được lọc bằng điều kiện LIKE với pattern @pMa_cty + '%', @pStt_rec + '%', @pStt_rec0 + '%', đồng thời @pStruct phải bằng '0'.
 * 
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả chi tiết hàng hóa của công ty 001
 * $results = AsPoGetCt1::call([
 *     'pMa_cty' => '001',
 * ]);
 * // Lấy chi tiết của một dòng cụ thể
 * $results = AsPoGetCt1::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 *     'pStt_rec0' => '001',
 * ]);
 * // Lấy tất cả chi tiết (không lọc)
 * $results = AsPoGetCt1::call([]);
 * ```
 * 
 * Lưu ý:
 * - Tham số @pStruct hiện luôn so sánh bằng '0', có thể dùng để mở rộng sau.
 * - Pattern tìm kiếm sử dụng LIKE, nên có thể dùng ký tự đại diện SQL (%, _) nếu truyền trực tiếp.
 * - Nếu muốn lấy chính xác mã công ty, nên truyền giá trị đầy đủ không kèm '%'.
 */
class AsPoGetCt1
{
    /**
     * Gọi stored procedure asPOGetCT1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các đối tượng stdClass).
     */
    public static function call(array $params = [])
    {
        // Giá trị mặc định cho pStruct
        $defaultParams = ['pStruct' => '0'];
        $params = array_merge($defaultParams, $params);

        return ProcedureCaller::call('asPOGetCT1', $params);
    }
}