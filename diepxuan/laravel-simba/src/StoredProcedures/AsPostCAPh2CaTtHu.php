<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPostCAPh2CaTtHu
 *
 * Stored procedure: asPostCAPh2_CaTtHu
 * Mục đích: Post phiếu chi (CaPh2) vào bảng cân đối phiếu chi (catthu).
 * Procedure thực hiện các bước:
 * 1. Lấy ngày chứng từ (ngay_ct) từ CaPh2, ngày khóa sổ (ngay_ks) và tài khoản từ (tk_tu) từ siSetup.
 * 2. Kiểm tra nếu ngày chứng từ <= ngày khóa sổ thì return (không post).
 * 3. Tính năm tài chính (NamTC) và tháng tài chính (ThangTC) thông qua hàm afNamTC, afThangTC.
 * 4. Xóa các bản ghi cũ trong catthu có cùng mã công ty và số chứng từ.
 * 5. Insert dữ liệu mới từ join giữa CaPh2 và CaCt2 vào catthu, với điều kiện tài khoản (tk) trong CaCt2 bắt đầu bằng tk_tu từ siSetup.
 *    Các thông tin insert: mã công ty, số chứng từ, số chứng từ chi tiết (stt_rec0), mã chứng từ, ngày chứng từ, số chứng từ, mã khách hàng, tài khoản từ, mã ngoại tệ, tỷ giá, tiền phiếu chi (ps_no), tiền phiếu chi ngoại tệ (ps_no_nt), diễn giải, loại thanh toán (cố định 1), mã giao dịch (cố định '1'), năm tài chính, tháng tài chính, ngày tạo, người tạo, ngày sửa, người sửa.
 * 6. Gọi procedure asCARecalCA2 để cập nhật số dư phiếu chi.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 *   Ví dụ: '001'
 * - @pStt_rec (string, bắt buộc): Số chứng từ (stt_rec) – khóa chính của phiếu chi (nvarchar(20)).
 *   Ví dụ: 'PC202500001'
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Nếu ngày chứng từ đã khóa sổ, procedure return ngay.
 * - Số bản ghi insert vào catthu bằng số dòng chi tiết CaCt2 có tk LIKE @pTk_tu + '%'.
 * - Procedure con asCARecalCA2 được gọi để cập nhật số dư.
 * 
 * Logic chi tiết:
 * - Lấy ngay_ct FROM CaPh2 WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - SELECT ngay_ks, tk_tu FROM siSetup WHERE ma_cty = @pMa_cty.
 * - Kiểm tra khóa sổ: IF @pNgay_ct <= @pNgay_ks RETURN.
 * - Gọi hàm dbo.afNamTC, dbo.afThangTC.
 * - DELETE FROM catthu WHERE ma_cty = @pMa_cty AND stt_rec = @pStt_rec.
 * - INSERT INTO catthu SELECT ... FROM CaPh2 p LEFT JOIN CaCt2 c ON p.ma_cty = c.ma_cty AND p.stt_rec = c.stt_rec WHERE c.tk LIKE @pTk_tu + '%'.
 * - EXEC asCARecalCA2 @pMa_cty, @pStt_rec.
 * 
 * Ví dụ gọi:
 * ```php
 * // Post phiếu chi vào cân đối phiếu chi
 * AsPostCAPh2CaTtHu::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PC202500001',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ hoạt động khi ngày chứng từ chưa bị khóa sổ.
 * - Cần đảm bảo dữ liệu trong CaPh2 và CaCt2 đã tồn tại.
 * - Tài khoản từ (tk_tu) trong siSetup xác định các tài khoản chi phù hợp.
 * - Procedure con asCARecalCA2 phải tồn tại trong database.
 * - Các hàm afNamTC và afThangTC phải được định nghĩa.
 */
class AsPostCAPh2CaTtHu
{
    /**
     * Gọi stored procedure asPostCAPh2_CaTtHu
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asPostCAPh2_CaTtHu', $params);
    }
}