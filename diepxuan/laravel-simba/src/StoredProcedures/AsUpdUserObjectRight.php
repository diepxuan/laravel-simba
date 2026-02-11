<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdUserObjectRight
 *
 * Stored procedure: asUpdUserObjectRight
 * Mục đích: Cập nhật quyền đối tượng (Object Right) cho người dùng.
 * Procedure thực hiện xóa bản ghi cũ và thêm bản ghi mới nếu có ít nhất một quyền (View, Edit, Add) được cấp.
 * Quyền được lưu trong bảng sysUserObjectsRight với các cờ dạng ký tự '1' (có quyền) hoặc khác '1' (không có quyền).
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên người dùng (NVARCHAR(20)).
 * - @pMenuID (string, bắt buộc): Mã menu (NVARCHAR(8)).
 * - @pObjectName (string, bắt buộc): Tên đối tượng (NVARCHAR(50)).
 * - @pViewRight (string, bắt buộc): Quyền xem (NVARCHAR(1)). '1' = có quyền, khác '1' = không có quyền.
 * - @pEditRight (string, bắt buộc): Quyền sửa (NVARCHAR(1)). '1' = có quyền, khác '1' = không có quyền.
 * - @pAddRight (string, bắt buộc): Quyền thêm (NVARCHAR(1)). '1' = có quyền, khác '1' = không có quyền.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, không có output parameter.
 * - Kết quả thực thi có thể kiểm tra qua số dòng bị ảnh hưởng (affected rows).
 * 
 * Logic chi tiết:
 * - DELETE từ bảng sysUserObjectsRight với điều kiện UserName = @pUserName AND MenuId = @pMenuID AND ObjectName = @pObjectName (xóa quyền cũ).
 * - Kiểm tra: nếu NOT (cả ba quyền đều khác '1') tức là có ít nhất một quyền bằng '1', thì thực hiện INSERT bản ghi mới với các quyền tương ứng.
 * - Nếu cả ba quyền đều khác '1' (không có quyền nào), không INSERT (người dùng không có quyền với đối tượng này).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdUserObjectRight::call([
 *     'pUserName' => 'john.doe',
 *     'pMenuID' => 'MN001',
 *     'pObjectName' => 'Customer',
 *     'pViewRight' => '1',
 *     'pEditRight' => '0',
 *     'pAddRight' => '1',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Tham số quyền là kiểu NVARCHAR(1), thường truyền '1' hoặc '0' (hoặc các ký tự khác). Logic so sánh là @pViewRight <> '1' (tức là không bằng '1').
 * - Điều kiện NOT (cả ba đều khác '1') tương đương với (ViewRight = '1' OR EditRight = '1' OR AddRight = '1').
 * - Nếu không có quyền nào, bản ghi sẽ bị xóa và không được thêm lại, đồng nghĩa với việc người dùng không có quyền gì với đối tượng.
 * - Procedure không cập nhật (UPDATE) mà dùng cách xóa rồi thêm mới (upsert). Đảm bảo chỉ có tối đa một bản ghi cho mỗi cặp (UserName, MenuID, ObjectName).
 * - Không có output parameter @pRet, lỗi SQL sẽ ném exception (tùy vào cấu hình kết nối).
 * - Bảng sysUserObjectsRight có thể lưu quyền chi tiết cho từng đối tượng (form, report, button) trong một menu.
 * - Cần đảm bảo MenuID và ObjectName tồn tại trong hệ thống.
 */
class AsUpdUserObjectRight
{
    /**
     * Gọi stored procedure asUpdUserObjectRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa resultset nếu có SELECT).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asUpdUserObjectRight', $params);
    }
}