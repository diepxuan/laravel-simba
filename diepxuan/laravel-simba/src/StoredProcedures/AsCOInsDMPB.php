<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOInsDMPB
 *
 * Stored procedure: asCOInsDMPB
 * Mục đích: Thêm mới danh mục phân bổ (codmpb) nếu chưa tồn tại (kiểm tra theo mã công ty, tài khoản phân bổ và module).
 * Procedure tự động sinh ID bằng cách lấy max(id) hiện có + 1. Nếu đã tồn tại bản ghi với cùng tài khoản phân bổ và module, trả về 0.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt (int, bắt buộc): Số thứ tự sắp xếp.
 * - @pTen_bt (string, bắt buộc): Tên bút toán phân bổ (50 ký tự).
 * - @pTk_pb (string, bắt buộc): Tài khoản phân bổ (20 ký tự).
 * - @pSo_ct (string, bắt buộc): Số chứng từ (12 ký tự). Có thể là số chứng từ mặc định.
 * - @pKsd (string, bắt buộc): Cờ sử dụng (1 ký tự). '0' hay '1'? Kiểu NVARCHAR(1).
 * - @pUser (string, bắt buộc): Người tạo (20 ký tự).
 * - @pTheoSPCT (bool, bắt buộc): Phân bổ theo sản phẩm công trình (bit).
 * - @pTheoBP (bool, bắt buộc): Phân bổ theo bộ phận (bit).
 * - @pTheoTKDU (bool, bắt buộc): Phân bổ theo tài khoản đối ứng (bit).
 * - @pModuleId (string, bắt buộc): Mã module (5 ký tự).
 * - @pRet (int, output): Kết quả trả về. >0: ID mới được thêm, 0: đã tồn tại (không thêm).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = ID mới (integer >0) nếu thêm thành công.
 * - @pRet = 0 nếu đã tồn tại bản ghi với cùng mã công ty, tk_pb và moduleid.
 * 
 * Logic chi tiết:
 * 1. Kiểm tra EXISTS: SELECT * FROM COdmpb WHERE Ma_cty = @pma_cty AND tk_pb = @pTK_pb AND moduleid = @pModuleId.
 * 2. Nếu không tồn tại:
 *    - Lấy max(id) trong COdmpb cho mã công ty đó, cộng thêm 1 (nếu không có bản ghi nào thì max(id) là NULL, ISNULL thành 0).
 *    - INSERT vào codmpb với các giá trị truyền vào, cdate = GETDATE(), cuser = @pUser, ldate = GETDATE(), luser = @pUser.
 *    - Gán @pRet = @ID (ID mới).
 * 3. Nếu đã tồn tại:
 *    - Gán @pRet = 0.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOInsDMPB::call([
 *     'pMa_cty' => '001',
 *     'pStt' => 1,
 *     'pTen_bt' => 'Phân bổ chi phí quản lý',
 *     'pTk_pb' => '1541',
 *     'pSo_ct' => 'PB001',
 *     'pKsd' => '1',
 *     'pUser' => 'admin',
 *     'pTheoSPCT' => true,
 *     'pTheoBP' => false,
 *     'pTheoTKDU' => false,
 *     'pModuleId' => 'CO',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret > 0) {
 *     // Thêm thành công, ID mới là $ret
 * } else {
 *     // Đã tồn tại, không thêm
 * }
 * ```
 * 
 * Lưu ý:
 * - Việc sinh ID tự động dựa trên max(id) có thể gây tranh chấp trong môi trường multi-user, nhưng stored procedure chạy trong transaction ngầm.
 * - Kiểm tra tồn tại chỉ dựa trên tk_pb và moduleid, không dựa trên id hay stt. Có thể có nhiều bản ghi cùng tk_pb nhưng khác module? Điều kiện bao gồm cả moduleid nên phân biệt.
 * - Các cờ TheoSPCT, TheoBP, TheoTKDU được lưu dưới dạng bit, trong PHP có thể truyền boolean hoặc integer.
 * - Trường ksd kiểu NVARCHAR(1) nhưng thường lưu '0' hoặc '1'. Có thể nên chuyển sang bit nhưng thiết kế hiện tại là string.
 */
class AsCOInsDMPB
{
    /**
     * Gọi stored procedure asCOInsDMPB
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOInsDMPB', $params);
    }
}