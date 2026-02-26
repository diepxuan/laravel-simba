<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 11:44:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPODelCP4.
 *
 * Stored procedure: asPODelCP4
 * Purpose: ================================================
 *
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pStt_rec (nvarchar(20)): Tham số đầu vào.
 * - @pRet (int OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 *
 * Giá trị mặc định: Không có.
 *
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 *
 * Example call:
 * ```php
 * $params = [
 * 'pMa_cty' => '',
 * 'pStt_rec' => '',
 * ];
 * $result = AsPODelCP4::call($params);
 * ```
 */

/**
 * Class AsPoDelCp4.
 *
 * Stored procedure: asPODelCP4
 * Mục đích: Xóa dữ liệu chi tiết chứng từ POCP4 (Purchase Order - Chi tiết phụ?).
 * Procedure xóa các bản ghi trong bảng POCP4 dựa trên mã công ty và số tham chiếu.
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
 * $result = AsPoDelCp4::call([
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
class AsPODelCP4 extends StoredProcedure
{
    public const NAME = 'asPODelCP4';

    public static function call(array $params = []): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $params));
    }
}
