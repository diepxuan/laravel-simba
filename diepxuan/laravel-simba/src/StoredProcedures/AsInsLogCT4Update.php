<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsLogCT4Update
 *
 * Stored procedure: asInsLogCT4Update
 * Mục đích: Ghi log giá trị cũ của chứng từ trước khi cập nhật vào bảng LogCt.
 * Procedure này được gọi khi cập nhật một chứng từ, lưu lại trạng thái hiện tại (trước khi thay đổi) để audit.
 * Nó xác định bảng đích dựa trên mã công ty và mã chứng từ (từ sidmct), sau đó đọc tất cả các cột (với một số điều kiện lọc) của bản ghi đó và chuyển thành chuỗi định dạng "tên_cột:giá trị".
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự). Mã công ty của chứng từ.
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi (20 ký tự). Khóa chính của bản ghi trong bảng đích.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (3 ký tự). Ví dụ: 'CP1', 'CP2'. Dùng để tra cứu tên bảng từ sidmct.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện cập nhật (20 ký tự).
 * - @pAction (string, bắt buộc): Hành động (30 ký tự). Thường là 'UPDATE' hoặc tên thao tác.
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả gọi có thể là số dòng affected (1 nếu insert thành công) hoặc empty.
 * 
 * Logic chi tiết:
 * 1. Lấy tên bảng (ph) từ bảng sidmct với điều kiện ma_cty = @pMa_cty và ma_ct = @pMa_ct. Nếu không tìm thấy, return (không insert log).
 * 2. Dùng cursor duyệt qua các cột của bảng @table_name (lấy từ INFORMATION_SCHEMA.COLUMNS) với điều kiện: kiểu dữ liệu không phải nvarchar HOặc nvarchar có character_maximum_length < 51 (loại bỏ các cột text lớn).
 * 3. Với mỗi cột, xác định kiểu dữ liệu (nvarchar, smalldatetime, decimal, int, bit) và động tạo câu lệnh SQL để lấy giá trị của cột đó từ bảng đích với điều kiện stt_rec = @pStt_rec.
 * 4. Giá trị được lấy thông qua sp_executesql và output parameter.
 * 5. Ghép nối chuỗi "tên_cột:giá trị" vào biến @str, mỗi cột một dòng (có ký tự xuống dòng CRLF).
 * 6. INSERT vào bảng LogCt với các giá trị: Ma_cty, Stt_rec, Ma_ct, Action, Content (ISNULL(@str,'')), User, Date (GETDATE()).
 * 
 * Lưu ý:
 * - So với asInsLogCT4Delete, procedure này lọc bớt các cột nvarchar có độ dài lớn (>=51) để tránh log quá nhiều dữ liệu (có thể là các cột memo, description).
 * - Bảng sidmct cần có mapping giữa ma_cty, ma_ct và ph (tên bảng). Nếu không có mapping, không log.
 * - Chỉ hỗ trợ một số kiểu dữ liệu: nvarchar (độ dài nhỏ), smalldatetime, decimal, int, bit. Các kiểu khác sẽ bị bỏ qua.
 * - Nếu bảng đích không có cột stt_rec, câu lệnh động sẽ lỗi.
 * - Có thể có rủi ro SQL injection tương tự do nối chuỗi tên bảng và tên cột.
 * - Bảng LogCt có cấu trúc: Ma_cty, Stt_rec, Ma_ct, Action, Content (text), User, Date.
 * - Nếu không tìm thấy bản ghi trong bảng đích, giá trị lấy ra có thể NULL, nhưng vẫn insert log với content rỗng (ISNULL(@str,'')).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsLogCT4Update::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 *     'pMa_ct' => 'CP1',
 *     'pUser' => 'admin',
 *     'pAction' => 'UPDATE',
 * ]);
 * // $result có thể là số dòng affected hoặc empty
 * ```
 * 
 * Liên quan:
 * - Bảng LogCt: lưu log thao tác chứng từ.
 * - Bảng sidmct: danh mục chứng từ.
 * - Các procedure khác: asInsLogCT4Delete (log xóa), asInsLogPrint (log in).
 */
class AsInsLogCT4Update
{
    /**
     * Gọi stored procedure asInsLogCT4Update
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là số dòng affected hoặc empty).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsLogCT4Update', $params);
    }
}