<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOGetDMPB
 *
 * Stored procedure: asCOGetDMPB
 * Mục đích: Lấy danh sách danh mục phân bổ (codmpb) theo mã công ty và module.
 * Procedure trả về các bản ghi phân bổ với đầy đủ thông tin, bao gồm các cờ điều kiện phân bổ (theo sản phẩm công trình, theo bộ phận, theo tài khoản đối ứng).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pModuleId (string, bắt buộc): Mã module (5 ký tự). Dùng để lọc các bản ghi theo module.
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - id (int): ID phân bổ (khóa chính).
 *   - stt (int?): Số thứ tự sắp xếp.
 *   - ten_bt (string): Tên bút toán phân bổ.
 *   - tk_pb (string): Tài khoản phân bổ.
 *   - so_ct (string?): Số chứng từ.
 *   - ksd (bit): Cờ sử dụng (1 đang sử dụng, 0 ngừng sử dụng).
 *   - theospct (bit): Phân bổ theo sản phẩm công trình.
 *   - TheoBP (bit): Phân bổ theo bộ phận.
 *   - TheoTKDU (bit): Phân bổ theo tài khoản đối ứng.
 *   - tien_pb (decimal): Tổng tiền đã phân bổ.
 *   - tien_pb_nt (decimal): Tổng tiền đã phân bổ ngoại tệ.
 *   - cuser (string): Người tạo.
 *   - luser (string): Người sửa.
 *   - tag (bit): Cột giả luôn trả về 0 (dùng cho mục đích giao diện, ví dụ đánh dấu chọn).
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT các trường từ bảng codmpb.
 * 2. Điều kiện WHERE: Ma_cty = @pMa_cty AND moduleid = @pModuleId (không lọc theo ksd).
 * 3. Sắp xếp theo stt.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsCOGetDMPB::call([
 *     'pMa_cty' => '001',
 *     'pModuleId' => 'CO',
 * ]);
 * // $rows là mảng các đối tượng stdClass hoặc mảng kết hợp.
 * foreach ($rows as $row) {
 *     echo "ID: {$row->id}, Tên bút toán: {$row->ten_bt}, TK phân bổ: {$row->tk_pb}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Có thể có nhiều bản ghi cho cùng một mã công ty và module.
 * - Cờ ksd không được lọc trong WHERE (dòng bị comment), nghĩa là trả về cả bản ghi đang sử dụng và ngừng sử dụng.
 * - Cột tag luôn là 0, có thể được dùng để đánh dấu chọn trong giao diện (checkbox).
 * - Các cờ theospct, TheoBP, TheoTKDU quyết định phương pháp phân bổ khi thực hiện tính phân bổ (asCOCalcPb).
 */
class AsCOGetDMPB
{
    /**
     * Gọi stored procedure asCOGetDMPB
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOGetDMPB', $params);
    }
}