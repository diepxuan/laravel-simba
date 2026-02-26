<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:07:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsDashFrequentlyFunction.
 *
 * Stored procedure: asInsDashFrequentlyFunction
 * Mục đích: Thêm mới một chức năng thường dùng vào bảng sysDashFrequentlyFunction.
 * Bảng này lưu danh sách các chức năng (menu) mà người dùng thường sử dụng, để hiển thị trên dashboard.
 * Procedure tự động sinh số thứ tự (Stt) mới cho người dùng bằng cách lấy max(Stt) của user đó + 1.
 *
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng (20 ký tự).
 * - @pMenuId (string, bắt buộc): Mã menu (8 ký tự). Mã chức năng trong hệ thống.
 * - @pDashID (int, bắt buộc): ID của dashlet (widget) liên kết. Có thể là dashid từ bảng sysDashBoard.
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
 * 1. Lấy max(Stt) từ bảng sysDashFrequentlyFunction với điều kiện username = @pUserName.
 * 2. Nếu không có bản ghi nào, max là NULL, ISNULL thành 0.
 * 3. Tăng giá trị lên 1 để có Stt mới.
 * 4. INSERT vào sysDashFrequentlyFunction với các giá trị truyền vào, stt = giá trị mới.
 * 5. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Số thứ tự Stt là duy nhất trong phạm vi một người dùng, nhưng có thể trùng giữa các user khác nhau.
 * - Có thể có ràng buộc duy nhất trên (username, menuid) hoặc (username, dashid) để tránh trùng lặp.
 * - Nên đảm bảo @pMenuId và @pDashID tồn tại trong các bảng liên quan.
 * - Việc sinh Stt tự động dựa trên max có thể gây tranh chấp nếu nhiều người cùng thêm chức năng cho cùng user.
 * - Bảng sysDashFrequentlyFunction có thể có khóa chính là (username, stt) hoặc (username, menuid).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsDashFrequentlyFunction::call([
 *     'pUserName' => 'admin',
 *     'pMenuId' => 'MN001',
 *     'pDashID' => 5,
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
 * - Bảng sysDashFrequentlyFunction: lưu chức năng thường dùng của người dùng.
 * - Bảng sysDashBoard: dashlet.
 * - Các procedure khác: asGetDashFrequentlyFunction, asUpdDashFrequentlyFunction, asDelDashFrequentlyFunction.
 */
class AsInsDashFrequentlyFunction
{
    /**
     * Gọi stored procedure asInsDashFrequentlyFunction.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDashFrequentlyFunction', [
            'pUserName' => $params['pUserName'] ?? null,
            'pMenuId'   => $params['pMenuId'] ?? null,
            'pDashID'   => $params['pDashID'] ?? null,
            'pRet'      => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asInsDashFrequentlyFunction with named parameters.
     */
    public static function callWithParams(?string $UserName = null, ?string $MenuId = null, ?int $DashID = null, ?int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pMenuId'   => $MenuId,
            'pDashID'   => $DashID,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
