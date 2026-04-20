<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsARFilt1
 *
 * Stored procedure: asARFilt1
 * Mục đích: Lọc danh sách chứng từ công nợ phải thu (AR) loại 1 - header và detail.
 * Procedure thực hiện lọc dữ liệu từ bảng ARPH1 (header) và ARCT1 (detail) dựa trên điều kiện lọc truyền vào.
 * Trả về hai resultset:
 *   - Resultset 1: Danh sách header với các thông tin chung của chứng từ loại 1.
 *   - Resultset 2: Danh sách detail với các thông tin chi tiết dòng chứng từ loại 1.
 * Điều kiện lọc được xây dựng động qua hai tham số @pKeyPh (điều kiện cho bảng ARPH1) và @pKeyCt (điều kiện cho bảng ARCT1).
 * 
 * Tham số:
 * - @pKeyPh (string, bắt buộc): Điều kiện lọc cho bảng ARPH1 (header). Chuỗi SQL WHERE condition (không bao gồm từ khóa WHERE).
 *   Ví dụ: "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'".
 *   Kiểu dữ liệu: NVARCHAR(1000).
 * - @pKeyCt (string, bắt buộc): Điều kiện lọc cho bảng ARCT1 (detail). Chuỗi SQL WHERE condition (không bao gồm từ khóa WHERE).
 *   Ví dụ: "ma_lo = 'LO01'".
 *   Kiểu dữ liệu: NVARCHAR(1000).
 * 
 * Giá trị mặc định:
 * - Không có giá trị mặc định, cả hai tham số đều bắt buộc.
 * 
 * Giá trị trả về:
 * - Procedure trả về hai resultset.
 * - Resultset 1: Các cột: chon (bit), ma_cty, stt_rec, ma_ct, so_ct, ngay_ct, ngay_lct, ma_kh, ten_kh, dia_chi, nguoi_gd, dien_giai, tk_no, ten_tk_no, ma_gd, ma_nt, ty_gia, t_tien_nt, t_tien, du, du_nt, trang_thai, post2gl, cdate, cuser, ldate, luser.
 * - Resultset 2: Các cột: ma_cty, stt_rec, stt_rec0, stt_rec_hd, stt_rec_dh, so_hd, ngay_hd, so_dh, ngay_dh, ma_nt, tt_hd, tt_hd_nt, tien_tt, tien_tt_nt, tien_tt_qd, da_tt, da_tt_nt, du_hd, du_hd_nt, tk, ten_tk, dien_giai, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * 
 * Logic chi tiết:
 * 1. Xây dựng câu lệnh SQL động cho header, nối với điều kiện WHERE từ @pKeyPh và @pKeyCt.
 *    - Điều kiện: stt_rec phải tồn tại trong ARCT1 thỏa @pKeyCt và đồng thời stt_rec đó phải tồn tại trong ARPH1 thỏa @pKeyPh.
 * 2. Thực thi câu lệnh header bằng sp_executesql.
 * 3. Xây dựng câu lệnh SQL động cho detail với cùng điều kiện.
 * 4. Thực thi câu lệnh detail bằng sp_executesql.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsARFilt1::call([
 *     'pKeyPh' => "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'",
 *     'pKeyCt' => "ma_lo = 'LO01'",
 * ]);
 * // $result là mảng chứa hai resultset
 * $headerRows = $result[0] ?? []; // resultset đầu tiên
 * $detailRows = $result[1] ?? []; // resultset thứ hai
 * ```
 * 
 * Lưu ý:
 * - Tham số truyền vào là chuỗi điều kiện SQL, cần đảm bảo an toàn để tránh SQL injection (procedure sử dụng sp_executesql với tham số động).
 * - Procedure không có output parameter.
 * - Cần kết nối database với quyền thực thi stored procedure.
 * - Các bảng tham chiếu: ARPH1, ARCT1, ardmkh, gldmTk, InDmLo, sidmbp, sidmhd, sidmphi, codmspct, artt.
 * - Module Accounts Receivable (AR) - công nợ phải thu.
 */
class AsARFilt1
{
    /**
     * Gọi stored procedure asARFilt1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng hai resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asARFilt1', $params);
    }
}