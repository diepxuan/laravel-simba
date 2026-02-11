<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOUpdDMCoBomPH
 *
 * Stored procedure: asCOUpdDMCoBomPH
 * Mục đích: Cập nhật định mức nguyên vật liệu - thông tin chung (bảng codmbomph).
 * Procedure thực hiện cập nhật thông tin chung của định mức nguyên vật liệu cho sản phẩm công trình, bao gồm ngày áp dụng, đơn giá lượng, ghi chú và người sửa.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Lưu ý kiểu VARCHAR(3).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pNgay1 (string, bắt buộc): Ngày bắt đầu áp dụng (SMALLDATETIME, định dạng 'YYYY-MM-DD').
 * - @pNgay2 (string, bắt buộc): Ngày kết thúc áp dụng (SMALLDATETIME).
 * - @pDon_gia_luong (float, bắt buộc): Đơn giá lượng (DECIMAL(19,4)). Có thể là đơn giá tính toán cho định mức.
 * - @pGhi_chu (string, tùy chọn): Ghi chú (255 ký tự). Có thể là chuỗi rỗng.
 * - @pUser (string, bắt buộc): Người cập nhật (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu cập nhật thành công (không có lỗi).
 * - @pRet = mã lỗi SQL nếu có lỗi.
 * 
 * Logic chi tiết:
 * 1. Cập nhật bản ghi trong codmbomph với các trường ngay1, ngay2, don_gia_luong, ghi_chu, Luser, Ldate.
 *    - Ldate được gán bằng GETDATE().
 *    - Điều kiện WHERE: Ma_cty và Ma_spct.
 * 2. Gán @pRet = @@ERROR.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOUpdDMCoBomPH::call([
 *     'pMa_cty' => 'A07',
 *     'pMa_spct' => 'SP001',
 *     'pNgay1' => '2012-01-01',
 *     'pNgay2' => '2012-01-31',
 *     'pDon_gia_luong' => 1500000.00,
 *     'pGhi_chu' => 'Định mức cho dự án X',
 *     'pUser' => 'HIEULQ',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Nếu không có bản ghi nào thỏa điều kiện, UPDATE không ảnh hưởng hàng nào và @pRet = 0 (thành công).
 * - Procedure không tạo mới bản ghi nếu chưa tồn tại, chỉ cập nhật.
 * - Cần đảm bảm mã sản phẩm công trình đã có trong codmbomph (có thể được tạo bởi procedure khác, ví dụ asCOInsDMCoBomPH).
 * - Trường Ldate được cập nhật tự động, không cần truyền từ bên ngoài.
 */
class AsCOUpdDMCoBomPH
{
    /**
     * Gọi stored procedure asCOUpdDMCoBomPH
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOUpdDMCoBomPH', $params);
    }
}