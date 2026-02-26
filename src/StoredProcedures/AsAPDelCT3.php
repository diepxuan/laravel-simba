<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 15:20:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsAPDelCT3.
 *
 * Stored procedure: asAPDelCT3
 * Mục đích: Xóa chi tiết 3 (APCT3) của một chứng từ Accounts Payable.
 * Procedure xóa các bản ghi trong bảng APCT3 (chi tiết chứng từ phải trả) dựa trên mã công ty và số chứng từ.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số chứng từ (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsAPDelCT3::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AP202500001',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ xóa các bản ghi trong bảng APCT3 có khớp mã công ty và số chứng từ.
 * - Không có kiểm tra ràng buộc khác. Cần đảm bảo chứng từ có thể xóa được trước khi gọi.
 * - Bảng APCT3 lưu chi tiết nào đó của Accounts Payable (có thể là phân bổ, kế hoạch thanh toán, v.v.).
 */
class AsAPDelCT3
{
    /**
     * Gọi stored procedure asAPDelCT3.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPDelCT3', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }
}
