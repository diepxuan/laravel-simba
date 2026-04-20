<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPostArPh3Glct
 *
 * Stored procedure: asPostArPh3_glct
 * Mục đích: Post chi tiết thanh toán công nợ phải thu (ArPh3) vào sổ cái (GLCT).
 * Procedure thực hiện các bước:
 * 1. Lấy ngày chứng từ (ngay_ct) từ ArPh3, năm tài chính (NamTC) và tháng tài chính (ThangTC) thông qua hàm afNamTC, afThangTC.
 * 2. Kiểm tra nếu ngày chứng từ <= ngày khóa sổ (từ siSetup) thì return (không post).
 * 3. Xóa các bút toán cũ trên GLCT của chứng từ này.
 * 4. Tạo bảng tạm #ct tổng hợp chi tiết thanh toán từ ArCt3 kết hợp với artt, nhóm theo tk_pt, ma_lo, ma_hd, ma_bp, ma_phi, ma_spct.
 *    - Tính tổng tiền thanh toán (tien) và tiền ngoại tệ (tien_nt) – tiền ngoại tệ chỉ tính nếu mã ngoại tệ của chứng từ khác mã ngoại tệ gốc (ma_nt0) của công ty.
 *    - Tạo stt_iden tự động và stt_rec0 dạng '001', '002', ...
 * 5. Insert bút toán bên Nợ (ps_no) vào GLCT: tk = tk_no từ ArPh3, tk_du = tk_pt từ #ct, ps_no_nt = tien_nt, ps_co_nt = 0.
 * 6. Insert bút toán bên Có (ps_co) vào GLCT: tk = tk_pt từ #ct, tk_du = tk_no từ ArPh3, ps_no_nt = 0, ps_co_nt = tien_nt.
 * 7. Cập nhật trạng thái post2gl = '1' trên ArPh3.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pStt_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của chứng thanh toán công nợ phải thu (nvarchar(20)).
 *   Ví dụ: 'AR202500001'
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày chứng từ đã khóa sổ, procedure return.
 * - Số bản ghi insert vào GLCT = 2 * số dòng trong #ct (mỗi dòng tạo 2 bút toán đối ứng).
 * 
 * Logic chi tiết:
 * - Kiểm tra khóa sổ: SELECT ngay_ks FROM siSetup WHERE ma_cty = @pMa_cty.
 * - DELETE FROM glct WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - Tạo #ct với IDENTITY, stt_rec0, tk_pt, ma_lo, ma_hd, ma_bp, ma_phi, ma_spct, SUM(tien_tt), SUM(tien_tt_nt) với điều kiện ngoại tệ.
 * - UPDATE #ct SET stt_rec0 = RIGHT('000' + CAST(stt_iden AS NVARCHAR(3)), 3).
 * - Hai lần INSERT GlCt với tham số tương ứng.
 * - UPDATE ArPh3 SET post2gl = '1' WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * 
 * Ví dụ gọi:
 * ```php
 * // Post chứng từ thanh toán công nợ phải thu vào sổ cái
 * AsPostArPh3Glct::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AR202500001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ.
 * - Cần đảm bảo dữ liệu trong ArPh3, ArCt3, artt đã tồn tại và có quan hệ.
 * - Bảng siSetup phải có bản ghi cho công ty tương ứng.
 * - Việc post sẽ tạo các bút toán đối ứng trên sổ cái, cần kiểm tra kỹ trước khi thực hiện.
 */
class AsPostArPh3Glct
{
    /**
     * Gọi stored procedure asPostArPh3_glct
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asPostArPh3_glct', $params);
    }
}