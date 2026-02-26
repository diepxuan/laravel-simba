<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 11:42:40
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPoDelCp3.
 *
 * Stored procedure: asPODelCP3
 * Mục đích: Xóa dữ liệu chi tiết chứng từ POCP3 (Purchase Order - Chi tiết phụ?).
 * Procedure xóa các bản ghi trong bảng POCP3 dựa trên mã công ty và số tham chiếu.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số tham chiếu (stt_rec) của chứng từ cần xóa.
 * - @pRet (int, output): Kết quả trả về: 0 nếu xóa thành công, khác 0 nếu có lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsPoDelCp3::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure này thực hiện DELETE trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 */
class AsPODelCP3 extends StoredProcedure
{
    public const NAME = 'asPODelCP3';

    /**
     * Gọi stored procedure asPODelCP3.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params = []): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $params));
    }
}
