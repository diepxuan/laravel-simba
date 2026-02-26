<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:39:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelVoucherInfo.
 *
 * Stored procedure: asDelVoucherInfo
 * Purpose:
 *
 * Parameters:
 * - @pVoucher_code (NVARCHAR(50)): input parameter.
 * - @pRet (INT): output parameter.
 *
 * Default values:
 *
 * Returns: Collection of query results.
 *
 * Example call:
 * ```php
 * $params = [
 *     // Provide parameter values
 * ];
 * $result = AsDelVoucherInfo::call($params);
 * ```
 */

/**
 * Class AsDelVoucherInfo.
 *
 * Stored procedure: asDelVoucherInfo
 * Mục đích: Xóa một bản ghi từ bảng sysVoucherInfo (thông tin chứng từ) dựa trên mã chứng từ.
 * Procedure thực hiện DELETE từ bảng sysVoucherInfo với điều kiện khớp Voucher_code.
 *
 * Tham số:
 * - @pVoucher_code (string, bắt buộc): Mã chứng từ (NVARCHAR(50)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 *
 * Logic chi tiết:
 * - DELETE FROM sysVoucherInfo WHERE Voucher_code = @pVoucher_code
 * - SET @pRet = @@error
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsDelVoucherInfo::call([
 *     'pVoucher_code' => 'PC',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, có lỗi SQL
 * }
 * ```
 *
 * Lưu ý:
 * - Tham số @pVoucher_code bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột Voucher_code.
 * - Bảng sysVoucherInfo lưu thông tin về các loại chứng từ (mẫu chứng từ, tên, cấu trúc...).
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelVoucherInfo
{
    /**
     * Gọi stored procedure asDelVoucherInfo.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asDelVoucherInfo', [
            'pVoucher_code' => $params['pVoucher_code'] ?? null,
        ], $connection);
    }
}
