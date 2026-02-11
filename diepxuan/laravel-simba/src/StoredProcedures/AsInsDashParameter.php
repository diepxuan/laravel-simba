<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsDashParameter
 *
 * Stored procedure: asInsDashParameter
 * Mục đích: Thêm mới một tham số cấu hình cho dashlet vào bảng sysDashParameter.
 * Bảng này lưu các tham số tùy chỉnh của dashlet (widget) trên dashboard người dùng.
 * Có logic đặc biệt: nếu tên tham số là '@pDashID' thì giá trị tham số sẽ được gán bằng @pDashID (ID dashlet).
 * 
 * Tham số:
 * - @pDashID (int, bắt buộc): ID của dashlet (widget) liên kết.
 * - @pUsername (string, bắt buộc): Tên đăng nhập của người dùng (20 ký tự).
 * - @pStt (int, bắt buộc): Số thứ tự của tham số trong dashlet. Có thể dùng để sắp xếp.
 * - @pParaname (string, bắt buộc): Tên tham số (50 ký tự, Unicode). Ví dụ: '@pDashID', '@pReportID'.
 * - @pParavalue (string, bắt buộc): Giá trị tham số (200 ký tự, Unicode).
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. Kiểm tra nếu @pParaname = '@pDashID' thì gán @pParavalue = @pDashID (chuyển số nguyên thành chuỗi).
 * 2. INSERT vào sysDashParameter với các giá trị truyền vào (đã điều chỉnh nếu có).
 * 3. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Logic đặc biệt trên chỉ áp dụng khi tên tham số chính xác là '@pDashID'. Có thể dùng để tự động điền giá trị dashid.
 * - Có thể có ràng buộc duy nhất trên (dashid, username, paraname) hoặc (dashid, username, stt).
 * - Giá trị tham số được lưu dưới dạng chuỗi NVARCHAR(200), có thể lưu số, ngày, chuỗi JSON.
 * - Nên đảm bảo @pDashID và @pUsername tồn tại trong bảng sysDashBoard.
 * - Tham số @pStt có thể được dùng để xác định thứ tự hiển thị hoặc nhóm tham số.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsDashParameter::call([
 *     'pDashID' => 10,
 *     'pUsername' => 'admin',
 *     'pStt' => 1,
 *     'pParaname' => '@pReportID',
 *     'pParavalue' => 'RPT001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysDashParameter: lưu tham số cấu hình dashlet.
 * - Bảng sysDashBoard: dashlet.
 * - Các procedure khác: asGetDashParameter, asUpdDashParameter, asDelDashParameter.
 */
class AsInsDashParameter
{
    /**
     * Gọi stored procedure asInsDashParameter
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsDashParameter', $params);
    }
}