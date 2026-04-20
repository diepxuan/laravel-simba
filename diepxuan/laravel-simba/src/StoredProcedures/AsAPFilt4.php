<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsAPFilt4
 *
 * Stored procedure: asAPFilt4
 * Mục đích: Lọc danh sách chứng từ công nợ phải trả (AP) loại 4 - header và detail.
 * Procedure thực hiện lọc dữ liệu từ bảng APPH4 (header) và APCT4 (detail) dựa trên điều kiện lọc truyền vào.
 * Trả về hai resultset:
 *   - Resultset 1: Danh sách header với các thông tin chung của chứng từ loại 4.
 *   - Resultset 2: Danh sách detail với các thông tin chi tiết dòng chứng từ loại 4.
 * Điều kiện lọc được xây dựng động qua hai tham số @pKeyPh (điều kiện cho bảng APPH4) và @pKeyCt (điều kiện cho bảng APCT4).
 * 
 * Tham số:
 * - @pKeyPh (string, bắt buộc): Điều kiện lọc cho bảng APPH4 (header). Chuỗi SQL WHERE condition (không bao gồm từ khóa WHERE).
 *   Ví dụ: "ma_cty = 'A01' AND ngay_ct >= '2023-01-01'".
 *   Kiểu dữ liệu: NVARCHAR(1000).
 * - @pKeyCt (string, bắt buộc): Điều kiện lọc cho bảng APCT4 (detail). Chuỗi SQL WHERE condition (không bao gồm từ khóa WHERE).
 *   Ví dụ: "ma_lo = 'LO01'".
 *   Kiểu dữ liệu: NVARCHAR(1000).
 * 
 * Giá trị mặc định:
 * - Không có giá trị mặc định, cả hai tham số đều bắt buộc.
 * 
 * Giá trị trả về:
 * - Procedure trả về hai resultset.
 * - Resultset 1: Các cột: chon (bit), ma_cty, ma_ct, stt_rec, so_ct, ngay_ct, ngay_lct, nt_ph, ma_nt, ty_gia, t_tien, t_tien_nt, trang_thai, ten_trang_thai (rỗng), post2gl, luser, ldate, cuser, cdate.
 * - Resultset 2: Các cột: ma_cty, stt_rec, stt_rec0, ma_nt, ty_gia, tk, ten_tk, tk_cn, ma_kh, ten_kh, dien_giai, ps_co, ps_co_nt, ps_no, ps_no_nt, nh_dk, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * 
 * Logic chi tiết:
 * 1. Xây dựng câu lệnh SQL động cho header, nối với điều kiện WHERE từ @pKeyPh và @pKeyCt.
 *    - Điều kiện: stt_rec phải tồn tại trong APCT4 thỏa @pKeyCt và đồng thời stt_rec đó phải tồn tại trong APPH4 thỏa @pKeyPh.
 * 2. Thực thi câu lệnh header bằng sp_executesql.
 * 3. Xây dựng câu lệnh SQL động cho detail với cùng điều kiện.
 * 4. Thực thi câu lệnh detail bằng sp_executesql.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsAPFilt4::call([
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
 * - Các bảng tham chiếu: APPH4, APCT4, GldmTk, ArdmKh, InDmLo, sidmbp, sidmhd, sidmphi, codmspct.
 * - Khác với asAPFilt1 và asAPFilt3 ở bảng dữ liệu (loại chứng từ 4).
 */
class AsAPFilt4
{
    /**
     * Gọi stored procedure asAPFilt4
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng hai resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asAPFilt4', $params);
    }
}