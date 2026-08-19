<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPostArPh4Glct
 *
 * Stored procedure: asPostArPh4_glct
 * Mục đích: Post phiếu kế toán (ArPh4) vào sổ cái (GLCT).
 * Procedure thực hiện các bước:
 * 1. Kiểm tra ngày khóa sổ: nếu ngày chứng từ (ngay_ct từ ArPh4) <= ngày khóa sổ (ngay_ks từ siSetup) thì return (không post).
 * 2. Xóa các bút toán cũ trên GLCT của chứng từ này.
 * 3. Duyệt qua các nhóm điều khoản (nh_dk) riêng biệt trong chi tiết phiếu (ArCt4) của chứng từ.
 *    - Với mỗi nhóm, kiểm tra số lượng dòng có ps_no <> 0.
 *      + Nếu có đúng 1 dòng ps_no <> 0: gọi procedure asPostArPh4_glct_1n (1 nợ nhiều có).
 *      + Ngược lại: gọi procedure asPostArPh4_glct_1c (1 có nhiều nợ).
 * 4. Sau khi xử lý tất cả nhóm, cập nhật trạng thái post2gl = '1' trên ArPh4.
 * 
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pstt_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của phiếu kế toán (nvarchar(20)).
 *   Ví dụ: 'PK202500001'
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày chứng từ đã khóa sổ, procedure return ngay.
 * - Kết quả thực tế phụ thuộc vào các procedure con được gọi (asPostArPh4_glct_1n, asPostArPh4_glct_1c).
 * 
 * Logic chi tiết:
 * - Kiểm tra khóa sổ: SELECT ngay_ct FROM ArPh4 WHERE stt_rec = @pstt_rec; SELECT ngay_ks FROM siSetup WHERE ma_cty = @pMa_Cty.
 * - DELETE FROM glct WHERE stt_rec = @pStt_rec AND ma_cty = @pma_cty.
 * - DECLARE cursor nh_dk: SELECT nh_dk FROM ArCt4 WHERE stt_rec = @pSTT_rec GROUP BY nh_dk.
 * - Với mỗi @nh_dk:
 *   - SELECT COUNT(ps_no) FROM ArCt4 WHERE Stt_rec = @pStt_rec AND Nh_dk = @Nh_dk AND ps_no <> 0.
 *   - Nếu count = 1: EXEC asPostArPh4_glct_1n @pMa_cty, @pSTT_rec, @NH_dk.
 *   - Ngược lại: EXEC asPostArPh4_glct_1c @pMa_cty, @pSTT_rec, @NH_dk.
 * - UPDATE ArPh4 SET post2gl = '1' WHERE stt_rec = @pStt_rec.
 * 
 * Ví dụ gọi:
 * ```php
 * // Post phiếu kế toán vào sổ cái
 * AsPostArPh4Glct::call([
 *     'pma_cty' => '001',
 *     'pstt_rec' => 'PK202500001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ.
 * - Cần đảm bảo các procedure con asPostArPh4_glct_1n và asPostArPh4_glct_1c đã tồn tại trong database.
 * - Việc sử dụng cursor có thể ảnh hưởng hiệu năng với số lượng nhóm lớn.
 * - Bảng siSetup phải có bản ghi cho công ty tương ứng.
 */
class AsPostArPh4Glct
{
    /**
     * Gọi stored procedure asPostArPh4_glct
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asPostArPh4_glct', $params);
    }
}