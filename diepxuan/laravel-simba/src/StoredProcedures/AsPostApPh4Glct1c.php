<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPostApPh4Glct1c
 *
 * Stored procedure: asPostApPh4_glct_1c
 * Mục đích: Post phiếu kế toán (ApPh4) cho một nhóm điều khoản (nh_dk) cụ thể, trường hợp "1 có nhiều nợ" – tức là có một dòng chi tiết có ps_co <> 0 (bên Có) và nhiều dòng có ps_no <> 0 (bên Nợ).
 * Procedure thực hiện các bước:
 * 1. Lấy ngày chứng từ (ngay_ct) từ ApPh4, năm tài chính (NamTC) và tháng tài chính (ThangTC) thông qua hàm afNamTC, afThangTC.
 * 2. Lấy mã ngoại tệ gốc (ma_nt0) và ngày khóa sổ (ngay_ks) từ siSetup.
 * 3. Kiểm tra nếu ngày chứng từ <= ngày khóa sổ thì return (không post).
 * 4. Insert bút toán bên Có (tk ghi có làm tk):
 *    - Lấy các dòng chi tiết có ps_co <> 0 (bên Có) làm nguồn chính (a).
 *    - Kết hợp với các dòng chi tiết có ps_no <> 0 (bên Nợ) làm đối ứng (b).
 *    - Tính ps_no_nt, ps_co_nt: nếu mã ngoại tệ của dòng chi tiết bằng mã ngoại tệ gốc (@pMa_nt0) thì tiền ngoại tệ = 0.
 *    - Insert vào GLCT với tk = tk từ a (bên Có), tk_du = tk từ b (bên Nợ), ps_no_nt = ps_co_nt từ b, ps_co_nt = ps_no_nt từ b.
 * 5. Insert bút toán bên Nợ (tk ghi nợ làm tk):
 *    - Lấy các dòng chi tiết có ps_no <> 0 (bên Nợ) làm nguồn chính (a), đã tính tiền ngoại tệ.
 *    - Kết hợp với tk từ dòng bên Có (b) làm đối ứng.
 *    - Insert vào GLCT với tk = tk từ a (bên Nợ), tk_du = tk từ b (bên Có), ps_no_nt và ps_co_nt từ a.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pSTT_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của phiếu kế toán (nvarchar(20)).
 *   Ví dụ: 'PK202500001'
 * - @pNh_dk (string, bắt buộc): Nhóm điều khoản (nh_dk) cần post (nvarchar(3)).
 *   Ví dụ: '001'
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày chứng từ đã khóa sổ, procedure return ngay.
 * - Số bản ghi insert vào GLCT = số dòng bên Nợ + số dòng bên Có (thực tế là 2 * số dòng bên Nợ, vì chỉ có 1 dòng bên Có).
 * 
 * Logic chi tiết:
 * - Lấy ngày chứng từ: SELECT ngay_ct FROM ApPh4 WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - Gọi hàm dbo.afNamTC, dbo.afThangTC.
 * - SELECT TOP 1 ma_nt0, ngay_ks FROM siSetup WHERE ma_cty = @pMa_Cty.
 * - Kiểm tra khóa sổ: IF @pNgay_ct <= @pNgay_ks RETURN.
 * - Hai lệnh INSERT GlCt với các sub‑query phức tạp.
 * 
 * Ví dụ gọi:
 * ```php
 * // Post nhóm điều khoản 001 của phiếu kế toán PK202500001, trường hợp 1 có nhiều nợ
 * AsPostApPh4Glct1c::call([
 *     'pMa_cty' => '001',
 *     'pSTT_rec' => 'PK202500001',
 *     'pNh_dk' => '001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ.
 * - Cần đảm bảo dữ liệu trong ApPh4 và ApCt4 đã tồn tại, và nhóm điều khoản chỉ có đúng 1 dòng ps_co <> 0.
 * - Các hàm afNamTC và afThangTC phải được định nghĩa trong database.
 * - Bảng siSetup phải có bản ghi cho công ty tương ứng.
 * - Việc tính tiền ngoại tệ phụ thuộc vào mã ngoại tệ gốc của công ty.
 */
class AsPostApPh4Glct1c
{
    /**
     * Gọi stored procedure asPostApPh4_glct_1c
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asPostApPh4_glct_1c', $params);
    }
}