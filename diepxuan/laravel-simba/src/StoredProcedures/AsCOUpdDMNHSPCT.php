<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOUpdDMNHSPCT
 *
 * Stored procedure: asCOUpdDMNHSPCT
 * Mục đích: Cập nhật danh mục nhóm sản phẩm công trình (CODMNHSPCT).
 * Procedure thực hiện cập nhật thông tin của một nhóm sản phẩm công trình, bao gồm tên nhóm, cấp, thứ tự nhóm, nhóm mẹ, ghi chú, cờ cộng số lượng, cờ sử dụng và người sửa.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pma_nhspct (string, bắt buộc): Mã nhóm sản phẩm công trình (8 ký tự). Khóa chính.
 * - @pten_nhspct (string, bắt buộc): Tên nhóm sản phẩm công trình (50 ký tự).
 * - @pCap (int, bắt buộc): Cấp nhóm (integer). Ví dụ: 1, 2, 3.
 * - @pStt_nhom (string, bắt buộc): Thứ tự nhóm (18 ký tự). Dùng để sắp xếp trong cây.
 * - @pNhom_me (string, bắt buộc): Mã nhóm mẹ (8 ký tự). Nếu là nhóm gốc có thể là NULL hoặc ''.
 * - @pGhi_chu (string, tùy chọn): Ghi chú (255 ký tự). Có thể là chuỗi rỗng.
 * - @pCong_sl (bool, bắt buộc): Cờ cộng số lượng (bit). Có lẽ dùng để xác định nhóm có cộng số lượng từ các nhóm con không.
 * - @pKsd (bool, bắt buộc): Cờ sử dụng (bit). 1 đang sử dụng, 0 ngừng sử dụng.
 * - @pLUser (string, bắt buộc): Người cập nhật (20 ký tự).
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
 * 1. UPDATE bảng CODMNHSPCT với các trường: ten_nhspct, Cap, Stt_nhom, Nhom_me, ghi_chu, Cong_sl, Ksd, Ldate, Luser.
 *    - Ldate được gán bằng GETDATE().
 * 2. Điều kiện WHERE: Ma_cty = @pMa_cty AND ma_nhspct = @pma_nhspct.
 * 3. Gán @pRet = @@ERROR.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOUpdDMNHSPCT::call([
 *     'pMa_cty' => '001',
 *     'pma_nhspct' => 'NH001',
 *     'pten_nhspct' => 'Nhóm sản phẩm xây dựng',
 *     'pCap' => 1,
 *     'pStt_nhom' => '001',
 *     'pNhom_me' => '',
 *     'pGhi_chu' => 'Nhóm chính',
 *     'pCong_sl' => true,
 *     'pKsd' => true,
 *     'pLUser' => 'admin',
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
 * - Procedure không kiểm tra sự tồn tại của nhóm mẹ (@pNhom_me). Cần đảm bảo mã nhóm mẹ hợp lệ (nếu có).
 * - Cập nhật cả cờ Cong_sl và Ksd, có thể ảnh hưởng đến các tính toán khác (ví dụ tổng hợp số lượng).
 * - Trường Stt_nhom có thể là chuỗi sắp xếp theo thứ tự từ điển, ví dụ '001', '002', ...
 * - Nếu không có bản ghi nào thỏa điều kiện, UPDATE không ảnh hưởng hàng nào và @pRet = 0 (thành công).
 */
class AsCOUpdDMNHSPCT
{
    /**
     * Gọi stored procedure asCOUpdDMNHSPCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOUpdDMNHSPCT', $params);
    }
}