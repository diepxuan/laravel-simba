<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsLogCT4Delete
 *
 * Stored procedure: asInsLogCT4Delete
 * Mục đích: Ghi log thông tin của một chứng từ (bản ghi) trước khi bị xóa vào bảng LogCt.
 * Procedure này được gọi khi xóa một chứng từ từ một bảng động (ví dụ: CAPH1, CAPH2, ...).
 * Nó đọc cấu trúc bảng đích, lấy giá trị từ tất cả các cột của bản ghi đó, chuyển thành chuỗi định dạng "tên_cột:giá trị" và lưu vào bảng log.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Mã công ty của chứng từ.
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi (20 ký tự). Khóa chính của bản ghi trong bảng đích.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện xóa (20 ký tự).
 * - @pTable (string, bắt buộc): Tên bảng đích (20 ký tự). Ví dụ: 'CAPH1', 'CAPH2'.
 * - @pAction (string, bắt buộc): Hành động (30 ký tự). Thường là 'DELETE' hoặc tên thao tác.
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả gọi có thể là số dòng affected (1 nếu insert thành công) hoặc empty.
 * 
 * Logic chi tiết:
 * 1. Lấy mã chứng từ (ma_ct) từ bảng sidmct dựa trên ph = @pTable.
 * 2. Dùng cursor duyệt qua tất cả các cột của bảng @pTable (lấy từ INFORMATION_SCHEMA.COLUMNS).
 * 3. Với mỗi cột, xác định kiểu dữ liệu (nvarchar, smalldatetime, decimal, int, bit) và động tạo câu lệnh SQL để lấy giá trị của cột đó từ bảng đích với điều kiện stt_rec = @pStt_rec.
 * 4. Giá trị được lấy thông qua sp_executesql và output parameter.
 * 5. Ghép nối chuỗi "tên_cột:giá trị" vào biến @str, mỗi cột một dòng (có ký tự xuống dòng CRLF).
 * 6. Nếu @str là NULL (có thể không tìm thấy bản ghi) thì return (không insert log).
 * 7. INSERT vào bảng LogCt với các giá trị: Ma_cty, Stt_rec, Ma_ct (lấy từ sidmct), Action, Content (chuỗi @str), User, Date (GETDATE()).
 * 
 * Lưu ý:
 * - Procedure này phức tạp và tốn tài nguyên vì sử dụng cursor và động SQL. Chỉ nên gọi khi cần log chi tiết.
 * - Bảng sidmct cần có mapping giữa ph (tên bảng) và ma_ct (mã chứng từ). Nếu không có mapping, @Ma_ct có thể NULL.
 * - Chỉ hỗ trợ một số kiểu dữ liệu: nvarchar, smalldatetime, decimal, int, bit. Các kiểu khác sẽ bị bỏ qua.
 * - Nếu bảng đích không có cột stt_rec, câu lệnh động sẽ lỗi.
 * - Có thể có rủi ro SQL injection nếu @pTable được truyền từ bên ngoài không kiểm soát. Procedure sử dụng nối chuỗi trực tiếp cho tên bảng và tên cột (không parameterized). Tuy nhiên, trong ngữ cảnh hệ thống nội bộ, có thể chấp nhận.
 * - Bảng LogCt có cấu trúc: Ma_cty, Stt_rec, Ma_ct, Action, Content (text), User, Date.
 * - Nếu không tìm thấy bản ghi trong bảng đích, @str sẽ rỗng và không insert log (return).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsLogCT4Delete::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 *     'pUser' => 'admin',
 *     'pTable' => 'CAPH1',
 *     'pAction' => 'DELETE',
 * ]);
 * // $result có thể là số dòng affected hoặc empty
 * ```
 * 
 * Liên quan:
 * - Bảng LogCt: lưu log thao tác chứng từ.
 * - Bảng sidmct: danh mục chứng từ.
 * - Các procedure khác: asInsLogCT4Update (cập nhật log), asInsLogPrint (log in).
 */
class AsInsLogCT4Delete
{
    /**
     * Gọi stored procedure asInsLogCT4Delete
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là số dòng affected hoặc empty).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsLogCT4Delete', $params);
    }
}