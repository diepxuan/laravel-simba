<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdOptFieldInfo
 *
 * Stored procedure: asUpdOptFieldInfo
 * Mục đích: Cập nhật thông tin trường tùy chọn (Optional Field) và xóa thiết lập nếu không sử dụng.
 * Procedure cập nhật tiêu đề (caption) của một trường tùy chọn dựa trên số thứ tự (Stt), đồng thời kiểm tra nếu trường không còn sử dụng (ksd = 0) sẽ xóa các thiết lập liên quan.
 * 
 * Tham số:
 * - @pStt (int, bắt buộc): Số thứ tự (STT) của trường tùy chọn (INT). Đây là khóa điều kiện.
 * - @pCaption (string, bắt buộc): Tiêu đề mới của trường (NVARCHAR(20)).
 * - @pField (string, bắt buộc): Mã trường (NVARCHAR(10)). Dùng để kiểm tra và xóa thiết lập.
 * - @pLUser (string, bắt buộc): Tên người dùng thực hiện cập nhật (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - UPDATE bảng sysOptFieldInfo: cập nhật Caption, Ldate (ngày hiện tại), Luser với điều kiện Stt = @pStt.
 * - Kiểm tra số lượng bản ghi có ksd = '0' (không sử dụng) và Field = @pField. Nếu > 0, thực hiện DELETE từ bảng sysOptFieldsetup với điều kiện Field = @pField (xóa thiết lập của trường không dùng nữa).
 * - Bắt lỗi: SET @pRet = @@error (lỗi của lệnh SQL cuối cùng).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdOptFieldInfo::call([
 *     'pStt' => 5,
 *     'pCaption' => 'Ghi chú thêm',
 *     'pField' => 'OPT1',
 *     'pLUser' => 'admin',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pStt là số thứ tự duy nhất (có thể là khóa chính) trong bảng sysOptFieldInfo.
 * - Cập nhật chỉ thay đổi Caption, Ldate, Luser; không thay đổi trường Field hay các thuộc tính khác.
 * - Điều kiện xóa: nếu có bất kỳ bản ghi nào trong sysOptFieldInfo với cùng Field và ksd = '0' (không sử dụng), toàn bộ thiết lập trong sysOptFieldsetup của trường đó sẽ bị xóa.
 * - Giá trị ksd là chuỗi '0' hoặc '1' (kiểu CHAR?) nhưng trong điều kiện so sánh với '0' (string). Cần đảm bảo kiểu dữ liệu nhất quán.
 * - Lỗi @@error có thể là lỗi của lệnh UPDATE hoặc DELETE (lệnh sau cùng).
 * - Nên đảm bảo rằng @pStt tồn tại trước khi cập nhật, nếu không có bản ghi nào khớp, UPDATE không ảnh hưởng nhưng DELETE vẫn có thể xảy ra nếu điều kiện thỏa mãn.
 */
class AsUpdOptFieldInfo
{
    /**
     * Gọi stored procedure asUpdOptFieldInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdOptFieldInfo', $params);
    }
}