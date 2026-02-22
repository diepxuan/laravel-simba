<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOGetDMPB1
 *
 * Stored procedure: asCOGetDMPB1
 * Mục đích: Lấy danh sách các tài khoản nhận phân bổ theo mã công ty và module.
 * Procedure truy vấn bảng codmpb1 (danh mục phân bổ chi tiết) kết hợp với gldmtk để lấy tên tài khoản.
 * Kết quả trả về danh sách các bản ghi chứa mã công ty, id phân bổ, tài khoản nhận phân bổ, module id và tên tài khoản.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pModuleId (string, bắt buộc): Mã module (5 ký tự). Dùng để lọc các bản ghi theo module.
 * 
 * Giá trị mặc định:
 * - Không có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string): Mã công ty.
 *   - id (int): ID phân bổ (tham chiếu đến codmpb.id?).
 *   - tk_nhan_pb (string): Tài khoản nhận phân bổ.
 *   - ModuleId (string): Mã module.
 *   - ten_tk (string): Tên tài khoản (lấy từ gldmtk). Nếu không có sẽ là chuỗi rỗng.
 * - Không có output parameter.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsCOGetDMPB1::call([
 *     'pMa_cty' => '001',
 *     'pModuleId' => 'CO',
 * ]);
 * // $rows là mảng các đối tượng stdClass hoặc mảng kết hợp chứa dữ liệu.
 * foreach ($rows as $row) {
 *     echo "ID: {$row->id}, TK nhận PB: {$row->tk_nhan_pb}, Tên TK: {$row->ten_tk}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure sử dụng LEFT JOIN với gldmtk để lấy tên tài khoản, nếu không có tên sẽ trả về chuỗi rỗng.
 * - Điều kiện lọc: Ma_cty = @pMa_cty AND moduleid = @pModuleId.
 * - Có thể có nhiều bản ghi cho cùng một id? Có thể, tùy thiết kế bảng codmpb1.
 * - ModuleId có thể là mã module của phân hệ (ví dụ: 'CO' cho phân bổ chi phí).
 */
class AsCOGetDMPB1
{
    /**
     * Gọi stored procedure asCOGetDMPB1
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOGetDMPB1', $params);
    }
}