<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGLCrtKC1
 *
 * Stored procedure: asGLCrtKC1
 * Mục đích: Thực hiện thao tác tạo bút toán kết chuyển tự động chi tiết dựa trên thông tin danh mục và khoảng thời gian.
 * Procedure này tính toán số phát sinh (nợ/có) của tài khoản nguồn, nhóm theo đối tượng (bộ phận, hợp đồng, sản phẩm công trình, phí) tùy theo cấu hình, sau đó tạo các bút toán kết chuyển chi tiết sang tài khoản đích.
 * 
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (nvarchar(3)). Không có giá trị mặc định.
 * - @pstt (int, bắt buộc): Số thứ tự danh mục kết chuyển (stt trong bảng gldmkc). Không có giá trị mặc định.
 * - @ptk (string, bắt buộc): Tài khoản nguồn (nvarchar(20)). Không có giá trị mặc định.
 * - @ptk_du (string, bắt buộc): Tài khoản đích (nvarchar(20)). Không có giá trị mặc định.
 * - @pten_bt (string, bắt buộc): Tên bút toán (nvarchar(100)). Không có giá trị mặc định.
 * - @pkc_bp (string, bắt buộc): Cờ kết chuyển theo bộ phận (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @pkc_hd (string, bắt buộc): Cờ kết chuyển theo hợp đồng (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @pkc_spct (string, bắt buộc): Cờ kết chuyển theo sản phẩm công trình (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @pkc_phi (string, bắt buộc): Cờ kết chuyển theo phí (nvarchar(1)). '1' có, '0' không. Không có giá trị mặc định.
 * - @ploai_kc (string, bắt buộc): Loại kết chuyển (nvarchar(1)). '1' ghi nợ, '2' ghi có, '3' kết chuyển lại lỗ, '4' kết chuyển thue GTGT. Không có giá trị mặc định.
 * - @pkc_dt_ps (string, bắt buộc): Cờ kết chuyển theo đối tượng có phát sinh (nvarchar(1)). '1' chỉ kết chuyển các đối tượng có phát sinh, '0' kết chuyển tất cả. Không có giá trị mặc định.
 * - @pngay1 (datetime, bắt buộc): Ngày bắt đầu kỳ kết chuyển (smalldatetime). Không có giá trị mặc định.
 * - @pngay2 (datetime, bắt buộc): Ngày kết thúc kỳ kết chuyển (smalldatetime). Không có giá trị mặc định.
 * - @pstt_rec (string, bắt buộc): Số chứng từ (20 ký tự). Không có giá trị mặc định.
 * - @pma_ct (string, bắt buộc): Mã chứng từ (nvarchar(3)). Không có giá trị mặc định.
 * - @pso_ct (string, bắt buộc): Số chứng từ (12 ký tự). Không có giá trị mặc định.
 * - @puser (string, bắt buộc): Người thực hiện (nvarchar(20)). Không có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset.
 * - Không có output parameter.
 * - Tác động: tạo các bút toán kết chuyển trong bảng glct.
 * 
 * Logic chi tiết:
 * 1. Lấy tháng và năm kế toán từ ngày kết thúc.
 * 2. Xác định tài khoản có chi tiết hay không (tk_isct, tk_du_isct) từ bảng gldmtk.
 * 3. Tạo bảng tạm #slkc1 để tổng hợp phát sinh (nợ/có) của tài khoản nguồn trong kỳ, nhóm theo tài khoản và đối tượng (ma_bp, ma_hd, ma_spct, ma_phi).
 * 4. Tạo trường xgroup để gom nhóm theo các cờ kết chuyển.
 * 5. Chèn dữ liệu vào bảng tạm #slkc với việc nhóm theo xgroup (nếu @pkc_dt_ps = 1 thì chỉ lấy các nhóm có xgroup khác rỗng).
 * 6. Áp dụng loại kết chuyển để điều chỉnh số liệu (zero out một bên nợ/có, xử lý kết chuyển lại lỗ, kết chuyển thue GTGT).
 * 7. Duyệt qua từng dòng trong bảng tạm bằng cursor, với mỗi dòng:
 *    - Xác định tài khoản đích chi tiết nếu tài khoản nguồn chi tiết.
 *    - Tính toán lại số liệu nếu là kết chuyển thue GTGT (so sánh dư 133 và phát sinh 333).
 *    - Xác định mã ngoại tệ của tài khoản nguồn.
 *    - Tạo stt_rec0 theo thứ tự AAA, AAB, ...
 *    - Nếu số phát sinh khác 0, tạo hai bút toán: xuôi (tk nguồn nợ/đích có) và đảo (tk đích nợ/nguồn có).
 * 8. Mỗi cặp bút toán có cùng stt_rec0, cập nhật các thông tin diễn giải, ngày chứng từ, người tạo.
 * 
 * Ví dụ gọi:
 * ```php
 * AsGLCrtKC1::call([
 *     'pma_cty' => 'A01',
 *     'pstt' => 1,
 *     'ptk' => '641',
 *     'ptk_du' => '511',
 *     'pten_bt' => 'Kc doanh thu',
 *     'pkc_bp' => '1',
 *     'pkc_hd' => '0',
 *     'pkc_spct' => '0',
 *     'pkc_phi' => '1',
 *     'ploai_kc' => '2',
 *     'pkc_dt_ps' => '1',
 *     'pngay1' => '2023-01-01',
 *     'pngay2' => '2023-01-25',
 *     'pstt_rec' => 'A01KCxxx',
 *     'pma_ct' => 'KCG',
 *     'pso_ct' => '000000KC',
 *     'puser' => 'locpv',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure này được gọi bởi asGLCrtKC, không nên gọi trực tiếp trừ khi có đầy đủ thông tin danh mục.
 * - Việc tính toán phát sinh dựa trên bảng glct, cần đảm bảo dữ liệu đã được cập nhật đúng.
 * - Các bút toán được tạo ra sẽ ảnh hưởng đến sổ cái và báo cáo tài chính.
 * - Bảng tạm và cursor được sử dụng có thể ảnh hưởng hiệu năng với dữ liệu lớn.
 * - Kết chuyển thue GTGT có logic riêng liên quan đến tài khoản 133 và 333.
 */
class AsGLCrtKC1
{
    /**
     * Gọi stored procedure asGLCrtKC1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (không có resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGLCrtKC1', $params);
    }
}