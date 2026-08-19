<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCODelDMNHSPCT
 *
 * Stored procedure: asCODelDMNHSPCT
 * Mục đích: Xóa danh mục nhóm sản phẩm công trình (CODMNHSPCT) sau khi kiểm tra ràng buộc.
 * Procedure thực hiện kiểm tra xem mã nhóm sản phẩm công trình có được sử dụng ở các bảng khác không (thông qua hàm afChkExistsCodeDict).
 * Nếu không có ràng buộc, tiến hành xóa bản ghi, cập nhật lại các nhóm con tham chiếu đến nhóm bị xóa, và cập nhật cấu trúc cây (asUpdateLevel2Tree).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_nhspct (string, bắt buộc): Mã nhóm sản phẩm công trình (8 ký tự). Là khóa chính cần xóa.
 * - @pRet (int, output): Kết quả trả về. 0: được xóa, <>0: không xóa được (có ràng buộc hoặc lỗi).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu xóa thành công (không có lỗi).
 * - @pRet = 50004 nếu mã nhóm đang được sử dụng (không thể xóa).
 * - @pRet = mã lỗi SQL nếu có lỗi khác (ví dụ lỗi khi xóa).
 * 
 * Logic chi tiết:
 * 1. Gọi hàm dbo.afChkExistsCodeDict để kiểm tra mã nhóm có tồn tại trong các bảng con không.
 *    - Nếu hàm trả về <>0, tức là mã đang được sử dụng, set @pRet = 50004 và RETURN.
 * 2. Lấy giá trị nhom_me của nhóm sắp xóa (nhóm cha của nhóm này).
 * 3. Xóa bản ghi trong CODMNHSPCT với điều kiện Ma_cty và ma_nhspct.
 * 4. Cập nhật các nhóm con có nhom_me = @pMa_nhspct thành nhom_me = nhóm cha vừa lấy (giữ nguyên cấu trúc cây).
 * 5. Gọi procedure asUpdateLevel2Tree để cập nhật lại level và thứ tự cây.
 * 6. Gán @pRet = @@error.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCODelDMNHSPCT::call([
 *     'pMa_cty' => '001',
 *     'pMa_nhspct' => '031',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } elseif ($ret === 50004) {
 *     // Mã nhóm đang được sử dụng, không thể xóa
 * } else {
 *     // Lỗi khác
 * }
 * ```
 * 
 * Lưu ý:
 * - Hàm afChkExistsCodeDict có thể kiểm tra ràng buộc toàn diện, đảm bảo tính toàn vẹn dữ liệu.
 * - Việc cập nhật nhom_me cho các nhóm con giúp duy trì cấu trúc cây (cây nhiều level).
 * - Procedure asUpdateLevel2Tree sẽ tính toán lại level, thứ tự sắp xếp cho toàn bộ danh mục nhóm sản phẩm công trình.
 * - Nếu xóa nhóm gốc (nhom_me là NULL hoặc ''), các nhóm con sẽ trở thành nhóm gốc? Logic hiện tại gán nhom_me = giá trị của nhóm bị xóa (có thể là NULL). Cần kiểm tra thiết kế bảng.
 */
class AsCODelDMNHSPCT
{
    /**
     * Gọi stored procedure asCODelDMNHSPCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCODelDMNHSPCT', $params);
    }
}