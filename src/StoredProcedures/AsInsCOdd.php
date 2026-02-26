<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:06:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsCOdd.
 *
 * Stored procedure: asInsCOdd
 * Mục đích: Chèn một bản ghi mới vào bảng codd (có thể là bảng chi tiết định mức?).
 * Bảng codd lưu thông tin về số lượng tồn kho, tỷ lệ hoàn thành, giá trị tồn cuối kỳ theo sản phẩm công trình.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pNam (int, bắt buộc): Năm kế toán.
 * - @pThang (int, bắt buộc): Tháng kế toán (1-12).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pTK (string, bắt buộc): Tài khoản (20 ký tự). Có thể là tài khoản kho, tài khoản chi phí.
 * - @pSl_kk_ck (decimal, bắt buộc): Số lượng tồn kho đầu kỳ (hoặc số lượng kết chuyển?). Kiểu decimal, chưa rõ độ chính xác.
 * - @pTy_le_ht (decimal, bắt buộc): Tỷ lệ hoàn thành (%). Kiểu decimal.
 * - @pSl_dd_ck (decimal, bắt buộc): Số lượng tồn cuối kỳ (hoặc số lượng dở dang cuối kỳ). Kiểu decimal.
 * - @pGt_dd_ck (decimal, bắt buộc): Giá trị tồn cuối kỳ (hoặc giá trị dở dang cuối kỳ). Kiểu decimal.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 *
 * Giá trị mặc định:
 * - Không có tham số nào có giá trị mặc định.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công.
 * - @pRet = mã lỗi SQL (ví dụ: 2627 vi phạm ràng buộc duy nhất, 547 vi phạm khóa ngoại).
 *
 * Logic chi tiết:
 * 1. INSERT vào bảng codd với các giá trị truyền vào.
 * 2. Gán @pRet = @@ERROR (lấy mã lỗi của câu lệnh SQL trước đó).
 *
 * Lưu ý:
 * - Bảng codd có khóa chính là gì? Có thể là (ma_cty, nam, thang, ma_spct, TK) hoặc (ma_cty, nam, thang, ma_spct). Cần kiểm tra ràng buộc duy nhất.
 * - Kiểu decimal có thể cần chỉ định độ chính xác và tỷ lệ. Trong stored procedure không chỉ định, nên dùng độ chính xác mặc định của cột.
 * - Nên đảm bảo các giá trị decimal không vượt quá phạm vi cột.
 * - Procedure không kiểm tra trùng lặp trước khi INSERT, nếu vi phạm khóa chính sẽ báo lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsCOdd::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2024,
 *     'pThang' => 12,
 *     'pMa_spct' => 'SP001',
 *     'pTK' => '1541',
 *     'pSl_kk_ck' => 100.5,
 *     'pTy_le_ht' => 80.0,
 *     'pSl_dd_ck' => 20.5,
 *     'pGt_dd_ck' => 2500000.0,
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
 * - Bảng codd: có thể liên quan đến định mức sản phẩm công trình (COdd).
 * - Các procedure khác: asGetCOdd, asUpdCOdd, asDelCOdd.
 */
class AsInsCOdd
{
    /**
     * Gọi stored procedure asInsCOdd.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsCOdd', $params, $connection);
    }

    /**
     * Call stored procedure asInsCOdd with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Nam = null, ?int $Thang = null, ?string $Ma_spct = null, ?string $TK = null, ?float $Sl_kk_ck = null, ?float $Ty_le_ht = null, ?float $Sl_dd_ck = null, ?float $Gt_dd_ck = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'   => $Ma_cty,
            'pNam'      => $Nam,
            'pThang'    => $Thang,
            'pMa_spct'  => $Ma_spct,
            'pTK'       => $TK,
            'pSl_kk_ck' => $Sl_kk_ck,
            'pTy_le_ht' => $Ty_le_ht,
            'pSl_dd_ck' => $Sl_dd_ck,
            'pGt_dd_ck' => $Gt_dd_ck,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
