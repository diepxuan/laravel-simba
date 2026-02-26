<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:59:22
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdDashFrequentlyFunction.
 *
 * Stored procedure: asUpdDashFrequentlyFunction
 * Mục đích: Cập nhật khoảng cách giãn dòng giữa các chức năng thường dùng trên dashboard.
 * Procedure cập nhật cờ space (khoảng cách) cho một mục chức năng thường dùng của người dùng trên dashboard.
 *
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên người dùng (NVARCHAR(20)).
 * - @pMenuID (string, bắt buộc): Mã menu (NVARCHAR(8)).
 * - @pDashID (int, bắt buộc): ID dashboard (INT).
 * - @pSpace (bool, bắt buộc): Cờ khoảng cách (BIT). 1 = có khoảng cách, 0 = không có khoảng cách.
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - UPDATE bảng sysDashFrequentlyFunction: cập nhật cột space = @pSpace với điều kiện menuid = @pMenuID AND username = @pUserName AND dashid = @pDashID.
 * - Bắt lỗi: SET @pRet = @@ERROR.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdDashFrequentlyFunction::call([
 *     'pUserName' => 'john.doe',
 *     'pMenuID' => 'MN001',
 *     'pDashID' => 5,
 *     'pSpace' => true,
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
 * - Tham số @pDashID có thể là thứ tự hoặc ID của chức năng trên dashboard.
 * - Cờ space có thể dùng để thêm khoảng cách trực quan giữa các chức năng trên giao diện.
 * - Điều kiện WHERE gồm ba trường: username, menuid, dashid (có thể là khóa chính phức hợp).
 * - Bảng sysDashFrequentlyFunction lưu các chức năng thường dùng (frequently used functions) của từng người dùng trên dashboard, cho phép cá nhân hóa.
 * - Lỗi @@ERROR có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 */
class AsUpdDashFrequentlyFunction
{
    /**
     * Gọi stored procedure asUpdDashFrequentlyFunction.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDashFrequentlyFunction', [
            'pUserName' => $params['pUserName'] ?? null,
            'pMenuID'   => $params['pMenuID'] ?? null,
            'pDashID'   => $params['pDashID'] ?? null,
            'pSpace'    => $params['pSpace'] ?? null,
            'pRet'      => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDashFrequentlyFunction with named parameters.
     */
    public static function callWithParams(?string $UserName = null, ?string $MenuID = null, ?int $DashID = null, ?bool $Space = null, ?int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pMenuID'   => $MenuID,
            'pDashID'   => $DashID,
            'pSpace'    => $Space,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
