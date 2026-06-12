<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsUpdCOdd
 *
 * Stored procedure: asUpdCOdd
 * Mục đích: Cập nhật dữ liệu dở dang (codd) trong phân hệ Cost (CO).
 * Procedure cập nhật các giá trị về sản lượng, tỷ lệ hoàn thành, giá trị dở dang cuối kỳ cho một bản ghi xác định bởi công ty, năm, tháng, mã sản phẩm công trình và tài khoản.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pNam (int, bắt buộc): Năm (INT).
 * - @pThang (int, bắt buộc): Tháng (INT).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (NVARCHAR(20)).
 * - @pTK (string, bắt buộc): Tài khoản (NVARCHAR(20)).
 * - @pSl_kk_ck (decimal, bắt buộc): Sản lượng khai báo cuối kỳ (DECIMAL).
 * - @pTy_le_ht (decimal, bắt buộc): Tỷ lệ hoàn thành (DECIMAL).
 * - @pSl_dd_ck (decimal, bắt buộc): Sản lượng dở dang cuối kỳ (DECIMAL).
 * - @pGt_dd_ck (decimal, bắt buộc): Giá trị dở dang cuối kỳ (DECIMAL).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Logic chi tiết:
 * - UPDATE bảng codd: cập nhật các cột Sl_kk_ck, Ty_le_ht, Sl_dd_ck, Gt_dd_ck với điều kiện Ma_cty = @pMa_cty AND Nam = @pNam AND Thang = @pThang AND Ma_spct = @pMa_spct AND TK = @pTK.
 * - Bắt lỗi: SET @pRet = @@error.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdCOdd::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pThang' => 12,
 *     'pMa_spct' => 'CT001',
 *     'pTK' => '154',
 *     'pSl_kk_ck' => 1000.00,
 *     'pTy_le_ht' => 0.8,
 *     'pSl_dd_ck' => 200.00,
 *     'pGt_dd_ck' => 5000000.00,
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
 * - Tham số decimal có thể truyền giá trị số thực (float) hoặc chuỗi số.
 * - Điều kiện WHERE gồm 5 trường, đảm bảo xác định duy nhất một bản ghi trong bảng codd (bảng dở dang).
 * - Bảng codd lưu thông tin dở dang của sản phẩm công trình theo kỳ kế toán, dùng trong tính giá thành.
 * - Các cột Sl_kk_ck, Sl_dd_ck, Gt_dd_ck có thể liên quan đến sản lượng khai báo, sản lượng dở dang, giá trị dở dang.
 * - Tỷ lệ hoàn thành (Ty_le_ht) có thể dùng để tính giá trị hoàn thành trong kỳ.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 */
class AsUpdCOdd
{
    /**
     * Gọi stored procedure asUpdCOdd
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asUpdCOdd', $params);
    }
}