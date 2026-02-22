<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsChkCodeExistsBeforeChange
 *
 * Stored procedure: asChkCodeExistsBeforeChange
 * Mục đích: Kiểm tra tồn tại mã trong danh mục trước khi thay đổi (update).
 * Dùng cho các thủ tục cập nhật Danh mục, khi muốn thay đổi giá trị mã.
 * Chỉ dùng cho các danh mục có 1 trường mã (Khách hàng, Vật tư, Hợp đồng, Bộ phận, Kho...).
 * Gọi trực tiếp từ Base - FrameWork.dll.
 * 
 * Tham số (tất cả đều bắt buộc, không có giá trị mặc định):
 * - @pMa_Cty (string): Mã công ty (nvarchar(3)).
 * - @pTable_name (sysname): Tên bảng danh mục (sysname). Ví dụ: 'ARDMKH', 'HRDmKhachHang'.
 * - @pCode_name (sysname): Tên cột mã trong bảng (sysname). Ví dụ: 'MA_KH', 'MA_VT'.
 * - @pOldValue (string): Giá trị mã cũ (nvarchar(20)). Giá trị hiện tại của mã trước khi thay đổi.
 * - @pNewValue (string): Giá trị mã mới (nvarchar(20)). Giá trị dự định thay thế.
 * 
 * Giá trị trả về:
 * - Procedure trả về một số nguyên (single column, single row) là số lượng bản ghi thỏa mãn điều kiện.
 * - Kết quả > 0 nghĩa là mã mới đã tồn tại (trùng với mã khác ngoài mã cũ), = 0 nghĩa là chưa tồn tại, có thể thay đổi.
 * 
 * Logic chi tiết:
 * 1. Nếu @pTable_name = 'GLDMTK' thì gán @pOldValue = '' (chuỗi rỗng). Đây là trường hợp đặc biệt cho bảng danh mục tài khoản.
 * 2. Nếu @pOldValue <> '' (khác rỗng):
 *    - Xây dựng câu SQL động với điều kiện LIKE: (pCode_name LIKE @value + '%' OR @pNewValue LIKE pCode_name + '%')
 *      và loại trừ giá trị cũ: pCode_name <> @oldValue.
 *    - Điều kiện LIKE cho phép kiểm tra mã phân cấp, tránh trùng mã cha/con.
 * 3. Nếu @pOldValue = '' (rỗng):
 *    - Xây dựng câu SQL động với điều kiện chính xác: pCode_name = @value.
 * 4. Luôn có điều kiện bổ sung: ma_cty = @pMa_Cty (cùng công ty).
 * 5. Thực thi câu SQL động bằng sp_executesql, lấy số lượng bản ghi thỏa mãn.
 * 6. Trả về số lượng đó.
 * 
 * Ví dụ gọi:
 * ```php
 * $count = AsChkCodeExistsBeforeChange::call([
 *     'pMa_Cty' => '001',
 *     'pTable_name' => 'ARDMKH',
 *     'pCode_name' => 'MA_KH',
 *     'pOldValue' => 'KH001',
 *     'pNewValue' => 'KH002',
 * ]);
 * // Kết quả: 0 nếu mã KH002 chưa tồn tại (ngoại trừ KH001) trong bảng ARDMKH của công ty 001.
 * 
 * // Trường hợp đổi mã nhưng giữ nguyên giá trị (cùng mã) sẽ trả về 0 vì loại trừ chính nó.
 * $count = AsChkCodeExistsBeforeChange::call([
 *     'pMa_Cty' => '001',
 *     'pTable_name' => 'ARDMKH',
 *     'pCode_name' => 'MA_KH',
 *     'pOldValue' => 'KH001',
 *     'pNewValue' => 'KH001',
 * ]);
 * // Kết quả: 0 (vì điều kiện pCode_name <> @oldValue loại bỏ chính bản ghi đó).
 * 
 * // Trường hợp bảng GLDMTK (danh mục tài khoản) sẽ gán @pOldValue = '' và kiểm tra chính xác.
 * $count = AsChkCodeExistsBeforeChange::call([
 *     'pMa_Cty' => '001',
 *     'pTable_name' => 'GLDMTK',
 *     'pCode_name' => 'TK',
 *     'pOldValue' => '111',
 *     'pNewValue' => '112',
 * ]);
 * // Dù truyền @pOldValue khác rỗng, procedure sẽ gán thành rỗng và kiểm tra chính xác.
 * ```
 * 
 * Lưu ý:
 * - Tất cả tham số đều bắt buộc, không có giá trị mặc định.
 * - Procedure này dùng khi cập nhật mã của một bản ghi danh mục, kiểm tra xem mã mới có trùng với mã khác (ngoài mã cũ) không.
 * - Điều kiện LIKE chỉ áp dụng khi @pOldValue khác rỗng, giúp kiểm tra mã phân cấp.
 * - Khi @pOldValue rỗng (hoặc bảng GLDMTK), kiểm tra chính xác (=) để đảm bảo không trùng bất kỳ mã nào.
 * - Kết quả trả về có thể sử dụng để quyết định có cho phép cập nhật hay không (nếu >0 thì từ chối).
 */
class AsChkCodeExistsBeforeChange
{
    /**
     * Gọi stored procedure asChkCodeExistsBeforeChange
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (số lượng bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asChkCodeExistsBeforeChange', $params);
    }
}