<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOUpdDMCoBomCT
 *
 * Stored procedure: asCOUpdDMCoBomCT
 * Mục đích: Cập nhật định mức nguyên vật liệu - thông tin chi tiết (bảng codmbomct).
 * Procedure thực hiện cập nhật thông tin định mức nguyên vật liệu cho sản phẩm công trình, bao gồm mã vật tư, số lượng, cờ vật tư chính và người sửa.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Lưu ý kiểu VARCHAR(3) thay vì NVARCHAR.
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pMa_vt (string, bắt buộc): Mã vật tư (20 ký tự). Đồng thời là điều kiện WHERE.
 * - @pvt_chinh (string, bắt buộc): Cờ vật tư chính (1 ký tự). Có thể là '1' cho vật tư chính, '0' cho phụ? (cần kiểm tra logic).
 * - @pso_luong (float, bắt buộc): Số lượng định mức (DECIMAL(19,4)).
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
 * 1. Cập nhật bản ghi trong codmbomct với các trường ma_vt, so_luong, vt_chinh, Luser, Ldate.
 *    - Ldate được gán bằng GETDATE().
 *    - Điều kiện WHERE: Ma_cty, Ma_spct và ma_vt (chính là mã vật tư cũ). Lưu ý: mã vật tư có thể thay đổi? Nếu mã vật tư thay đổi, cần xử lý khóa chính? Ở đây điều kiện WHERE dùng @pMa_vt cho cả hai vị trí, nghĩa là mã vật tư không thay đổi (hoặc thay đổi nhưng điều kiện vẫn dùng giá trị cũ). Có thể đây là cập nhật các trường khác, mã vật tư không thay đổi.
 * 2. Gán @pRet = @@ERROR.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOUpdDMCoBomCT::call([
 *     'pMa_cty' => 'A07',
 *     'pMa_spct' => 'SP001',
 *     'pMa_vt' => 'VT001',
 *     'pvt_chinh' => '1',
 *     'pso_luong' => 10.5,
 *     'pUser' => 'admin',
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
 * - Cần đảm bảo mã vật tư tồn tại trong danh mục vật tư (có thể có ràng buộc khóa ngoại).
 * - Trường Ldate được cập nhật tự động, không cần truyền từ bên ngoài.
 */
class AsCOUpdDMCoBomCT
{
    /**
     * Gọi stored procedure asCOUpdDMCoBomCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOUpdDMCoBomCT', $params);
    }
}