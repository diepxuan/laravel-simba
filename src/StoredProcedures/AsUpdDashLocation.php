<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:58:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdDashLocation.
 *
 * Stored procedure: asUpdDashLocation
 * Mục đích: Di chuyển các Dashlet trên dashboard (cập nhật vị trí và kích thước).
 * Procedure cập nhật thông tin vị trí (location, x, y) và kích thước (h, w) của một dashlet cho người dùng cụ thể.
 *
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên người dùng (NVARCHAR(20)).
 * - @pDashIdSrc (int, bắt buộc): ID dashlet nguồn (INT). Dashlet cần di chuyển.
 * - @pLocationTar (int, bắt buộc): Vị trí đích (location) (INT). Có thể là chỉ số cột hoặc khu vực.
 * - @pXTar (int, bắt buộc): Tọa độ X đích (INT). Vị trí pixel hoặc thứ tự trong location.
 * - @pYTar (int, bắt buộc): Tọa độ Y đích (INT). Vị trí pixel hoặc thứ tự trong location.
 * - @pHSrc (int, bắt buộc): Chiều cao (height) của dashlet (INT).
 * - @pWSrc (int, bắt buộc): Chiều rộng (width) của dashlet (INT).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - UPDATE bảng sysDashBoard: cập nhật các cột location, x, y, h, w với điều kiện username = @pUserName AND dashid = @pDashIdSrc.
 * - Bắt lỗi: SET @pRet = @@ERROR.
 *
 * Ví dụ gọi (theo comment trong SQL):
 * ```php
 * $result = AsUpdDashLocation::call([
 *     'pUserName' => 'HIEULQ',
 *     'pDashIdSrc' => 1,
 *     'pLocationTar' => 1,
 *     'pXTar' => 1,
 *     'pYTar' => '1', // SQL truyền string '1' nhưng kiểu INT, có thể tự convert
 *     'pHSrc' => 0,
 *     'pWSrc' => 0,
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
 * - Tham số @pYTar trong ví dụ gốc được truyền là chuỗi '1' nhưng kiểu dữ liệu là INT. Trong PHP có thể truyền số nguyên.
 * - Điều kiện WHERE gồm username và dashid (có thể là khóa chính phức hợp).
 * - Bảng sysDashBoard lưu cấu hình dashboard của từng người dùng: vị trí, kích thước các dashlet (widget).
 * - Các trường location, x, y có thể dùng để sắp xếp dashlet trong giao diện grid.
 * - Lỗi @@ERROR có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 */
class AsUpdDashLocation
{
    /**
     * Gọi stored procedure asUpdDashLocation.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDashLocation', [
            'pUserName'    => $params['pUserName'] ?? null,
            'pDashIdSrc'   => $params['pDashIdSrc'] ?? null,
            'pLocationTar' => $params['pLocationTar'] ?? null,
            'pXTar'        => $params['pXTar'] ?? null,
            'pYTar'        => $params['pYTar'] ?? null,
            'pHSrc'        => $params['pHSrc'] ?? null,
            'pWSrc'        => $params['pWSrc'] ?? null,
            'pRet'         => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDashLocation with named parameters.
     */
    public static function callWithParams(?string $UserName = null, ?int $DashIdSrc = null, ?int $LocationTar = null, ?int $XTar = null, ?int $YTar = null, ?int $HSrc = null, ?int $WSrc = null, ?int $Ret = null): Collection
    {
        $params = [
            'pUserName'    => $UserName,
            'pDashIdSrc'   => $DashIdSrc,
            'pLocationTar' => $LocationTar,
            'pXTar'        => $XTar,
            'pYTar'        => $YTar,
            'pHSrc'        => $HSrc,
            'pWSrc'        => $WSrc,
            'pRet'         => $Ret,
        ];

        return self::call($params);
    }
}
