<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCODelPostCp2GlCt
 *
 * Stored procedure: asCODelPostCp2GlCt
 * Mục đích: Xóa phân bổ chi phí trả trước trong sổ cái (GLCT) và bảng chi tiết khấu hao chi phí trả trước (cokhcptt).
 * Procedure thực hiện kiểm tra ngày khóa sổ, nếu tháng cần xóa đã khóa sổ thì trả về lỗi 50012.
 * Nếu chưa khóa sổ, tiến hành xóa các bút toán phân bổ chi phí trả trước trong GLCT và xóa chi tiết khấu hao.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ct (string, bắt buộc): Mã chứng từ phân bổ (3 ký tự). Ví dụ 'CO3'.
 * - @pNam (int, bắt buộc): Năm cần xóa.
 * - @pThang (int, bắt buộc): Tháng cần xóa.
 * - @pRet (int, output): Kết quả trả về. 0: được xóa, khác 0: lỗi (50012: đã khóa sổ, hoặc mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu xóa thành công (không có lỗi).
 * - @pRet = 50012 nếu tháng cần xóa đã bị khóa sổ (ngày khóa sổ > ngày đầu tháng).
 * - @pRet = mã lỗi SQL nếu có lỗi khác.
 * 
 * Logic chi tiết:
 * 1. Lấy ngày khóa sổ (Ngay_Ks) từ sisetup.
 * 2. Tính ngày đầu tháng của tháng/năm truyền vào: @pDate = '1/{tháng}/{năm}'.
 * 3. Sử dụng hàm dbo.afGetMinMaxDayOfMonth(@pDate,0) để lấy ngày đầu tháng (0: ngày đầu, 1: ngày cuối).
 * 4. So sánh: nếu @Ngay_Ks > @pNgay_ct (ngày khóa sổ sau ngày đầu tháng) tức là tháng đã khóa sổ => trả về lỗi 50012.
 * 5. Nếu chưa khóa sổ:
 *    - Xóa từ bảng cokhcptt (khấu hao chi phí trả trước) với điều kiện Ma_Cty, thang, nam.
 *    - Xóa từ bảng GlCt với điều kiện Ma_Cty, Ma_Ct, thang, nam.
 * 6. Gán @pRet = @@ERROR.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCODelPostCp2GlCt::call([
 *     'pMa_cty' => '001',
 *     'pMa_ct' => 'CO3',
 *     'pNam' => 2024,
 *     'pThang' => 3,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } elseif ($ret === 50012) {
 *     // Tháng đã khóa sổ, không thể xóa
 * } else {
 *     // Lỗi khác
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ xóa dữ liệu của một tháng cụ thể, không xóa toàn bộ.
 * - Kiểm tra khóa sổ chỉ dựa trên ngày đầu tháng, nếu khóa sổ vào giữa tháng thì tháng đó vẫn không cho xóa (an toàn).
 * - Xóa cả hai bảng để đảm bảo đồng bộ dữ liệu.
 * - Cần đảm bảo mã chứng từ @pMa_ct đúng với mã chứng từ phân bổ chi phí trả trước.
 */
class AsCODelPostCp2GlCt
{
    /**
     * Gọi stored procedure asCODelPostCp2GlCt
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCODelPostCp2GlCt', $params);
    }
}