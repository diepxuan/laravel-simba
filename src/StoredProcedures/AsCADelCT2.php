<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 15:32:36
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCADelCT2.
 *
 * Stored procedure: asCADelCT2
 * Mục đích: Xóa bản ghi trong bảng CACT2 (chi tiết chứng từ 2) theo mã công ty và số thứ tự record.
 * Procedure thực hiện xóa các bản ghi trong bảng CACT2 thỏa mãn điều kiện mã công ty và stt_rec.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự record (20 ký tự). Khóa chính của bảng CACT2.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelCT2::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'CT202500001',
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
 * - Bảng CACT2 lưu trữ chi tiết chứng từ loại 2 trong module Cost Accounting.
 * - Procedure này thường được gọi khi hủy một chứng từ chi phí.
 */
class AsCADelCT2
{
    /**
     * Gọi stored procedure asCADelCT2.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCADelCT2', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }
}
