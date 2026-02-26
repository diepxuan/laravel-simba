<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 15:23:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsAPDelPost2TT_APTT.
 *
 * Stored procedure: asAPDelPost2TT_APTT
 * Mục đích: Xóa phân bổ chứng từ Accounts Payable và cập nhật lại số tiền phân bổ trên hóa đơn.
 * Procedure thực hiện xóa một bản ghi phân bổ (chi tiết thanh toán) và điều chỉnh lại số tiền đã phân bổ trên hóa đơn gốc.
 * Quy trình:
 *   1. Lấy thông tin tiền đã phân bổ trước đó từ bảng APTT (tien_tt, tien_tt_nt).
 *   2. Xóa bản ghi phân bổ có stt_rec và stt_rec_hd tương ứng.
 *   3. Cập nhật lại hóa đơn gốc (stt_rec_hd) giảm số tiền phân bổ, tăng dư hóa đơn, và kiểm tra trạng thái tất toán.
 *   4. Xử lý transaction: rollback nếu có lỗi.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số chứng từ phân bổ (20 ký tự) - chứng từ thanh toán.
 * - @pStt_rec_hd (string, bắt buộc): Số chứng từ hóa đơn (20 ký tự) - hóa đơn gốc được phân bổ.
 * - @pTien_tt (decimal, bắt buộc): Số tiền phân bổ cần xóa (tiền Việt Nam).
 * - @pTien_tt_nt (decimal, bắt buộc): Số tiền phân bổ cần xóa (tiền ngoại tệ).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL). Nếu có lỗi, trả về 50163.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsAPDelPost2TT_APTT::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PT202500001',
 *     'pStt_rec_hd' => 'HD202500001',
 *     'pTien_tt' => 1000000.00,
 *     'pTien_tt_nt' => 1000000.00,
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa phân bổ thành công
 * } else {
 *     // Có lỗi xảy ra, có thể là lỗi 50163
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure sử dụng transaction và try-catch để đảm bảo tính toàn vẹn dữ liệu.
 * - Nếu có lỗi xảy ra, transaction sẽ rollback và trả về mã lỗi 50163 ("Xảy ra lỗi, hành động bị huỷ, khôi phục trạng thái!").
 * - Cập nhật trạng thái tất toán (tat_toan) tự động: nếu dư hóa đơn sau khi điều chỉnh bằng 0 thì tat_toan = 1, ngược lại 0.
 * - Các trường được cập nhật trên hóa đơn gốc: tien_tt, tien_tt_nt, du_hd, du_hd_nt, tat_toan.
 * - Cần đảm bảo số tiền xóa (@pTien_tt, @pTien_tt_nt) khớp với số tiền phân bổ thực tế.
 */
class AsAPDelPost2TT_APTT
{
    /**
     * Gọi stored procedure asAPDelPost2TT_APTT.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPDelPost2TT_APTT', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pStt_rec'    => $params['pStt_rec'] ?? null,
            'pStt_rec_hd' => $params['pStt_rec_hd'] ?? null,
            'pTien_tt'    => $params['pTien_tt'] ?? 0.0,
            'pTien_tt_nt' => $params['pTien_tt_nt'] ?? 0.0,
        ], $connection);
    }
}
