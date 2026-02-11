<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPoFilt1
 *
 * Stored procedure: asPOFilt1
 * Mục đích: Lọc danh sách chứng từ đơn đặt hàng (POPH1) và chi tiết (POCT1) dựa trên điều kiện truyền vào.
 * Procedure sử dụng dynamic SQL để xây dựng câu truy vấn linh hoạt, trả về hai resultset:
 *   - Resultset 1: Thông tin chứng từ POPH1 (header) kèm thông tin khách hàng và điều khoản thanh toán.
 *   - Resultset 2: Chi tiết hàng hóa POCT1 kèm thông tin vật tư, kho, lô, bộ phận, hợp đồng, phí, sản phẩm.
 * 
 * Tham số:
 * - @pKeyPh (string, tùy chọn, mặc định '1=1'): Điều kiện WHERE dạng chuỗi để lọc bảng POPH1 (không bao gồm từ khóa WHERE).
 * - @pKeyCt (string, tùy chọn, mặc định " ma_kho like '%CT%'"): Điều kiện WHERE dạng chuỗi để lọc bảng POCT1.
 * 
 * Giá trị trả về:
 * - Hai resultset được trả về liên tiếp.
 *   + Resultset 1: các cột: chon, ma_cty, stt_rec, ma_ct, ma_kh, ten_kh, dia_chi, nguoi_gd, dien_giai, so_ct, ngay_ct, ngay_lct, ma_tt_po, mo_ta, han_ck, tl_ck, han_tt, ls_qh, ma_nt, ty_gia, t_tien_nt0, t_tien0, t_thue, t_thue_nt, t_tt, t_tt_nt, t_so_luong, sua_tien, sua_tt, tao_tu_pdn, post2gl, trang_thai, cdate, cuser, ldate, luser.
 *   + Resultset 2: các cột: ma_cty, stt_rec, stt_rec0, stt_rec_pdn, stt_rec0_pdn, so_pdn, ma_vt, ten_vt, ton_kho, tk_vt, tk_thue, so_luong, dvt, so_luong_qd, gia_nt0, gia0, tien_nt0, tien0, ts_gtgt, thue_gtgt_nt, thue_gtgt, tt_nt, tt, sl_nhap, sl_nhap_qd, ton, ton_all, ton_mua, ton_mua_all, ton_ban, ton_ban_all, ma_kho, ten_kho, dia_chi, ma_vitri, ten_vitri, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * 
 * Ví dụ gọi:
 * ```php
 * $results = AsPoFilt1::call([
 *     'pKeyPh' => "ma_cty = '001' and ngay_ct >= '2025-01-01'",
 *     'pKeyCt' => "ma_vt like 'VT001%'",
 * ]);
 * // $results là một mảng chứa hai resultset (có thể cần xử lý đặc biệt).
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng `sp_executesql` để thực thi dynamic SQL, cần cẩn thận với SQL injection.
 * - Người gọi phải đảm bảo điều kiện truyền vào an toàn (không chứa mã độc).
 * - Kết quả trả về nhiều resultset, cần sử dụng DB::select với multiple results hoặc điều chỉnh ProcedureCaller.
 */
class AsPoFilt1
{
    /**
     * Gọi stored procedure asPOFilt1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là nhiều resultset).
     */
    public static function call(array $params = [])
    {
        // Giá trị mặc định
        $defaultParams = [
            'pKeyPh' => '1=1',
            'pKeyCt' => " ma_kho like '%CT%'",
        ];
        $params = array_merge($defaultParams, $params);

        return ProcedureCaller::call('asPOFilt1', $params);
    }
}