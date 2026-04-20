<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOUpdHsPb
 *
 * Stored procedure: asCOUpdHsPb
 * Mục đích: Cập nhật hệ số phân bổ và tiền nhận phân bổ trong bảng chi tiết phân bổ (codmpb2).
 * Procedure thực hiện UPDATE các trường he_so và tien_nhan cho một bản ghi phân bổ cụ thể, xác định bởi khóa gồm nhiều trường.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pId (int, bắt buộc): ID phân bổ (tham chiếu đến codmpb.id).
 * - @pNam (int, bắt buộc): Năm phân bổ.
 * - @pTHang (int, bắt buộc): Tháng phân bổ.
 * - @pTk (string, bắt buộc): Tài khoản nhận phân bổ (20 ký tự). Tương ứng với tk_nhan_pb.
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pMa_bp (string, bắt buộc): Mã bộ phận (20 ký tự).
 * - @pTk_DU (string, bắt buộc): Tài khoản đối ứng? (20 ký tự). Tuy nhiên không được sử dụng trong điều kiện WHERE. Có thể là thừa? (cần kiểm tra).
 * - @pHs (float, bắt buộc): Hệ số phân bổ mới (DECIMAL(19,4)).
 * - @pTien_nhan (float, bắt buộc): Số tiền nhận phân bổ mới (DECIMAL(19,4)).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu cập nhật thành công (không có lỗi).
 * - @pRet = mã lỗi SQL nếu có lỗi.
 * 
 * Logic chi tiết:
 * 1. UPDATE bảng codmpb2 với các trường he_so = @pHs, tien_nhan = @pTien_nhan.
 * 2. Điều kiện WHERE gồm 7 trường: ma_cty, id, nam, thang, tk_nhan_pb, ma_spct, ma_bp.
 *    - Lưu ý: tham số @pTk được map đến tk_nhan_pb.
 *    - Tham số @pTk_DU không xuất hiện trong WHERE, có thể là dư thừa hoặc dùng cho logic khác (không rõ).
 * 3. Gán @pRet = @@ERROR.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOUpdHsPb::call([
 *     'pMa_cty' => '001',
 *     'pId' => 5,
 *     'pNam' => 2024,
 *     'pTHang' => 3,
 *     'pTk' => '1541',
 *     'pMa_spct' => 'SP001',
 *     'pMa_bp' => 'BP001',
 *     'pTk_DU' => '', // có thể bỏ qua nếu không dùng
 *     'pHs' => 0.5,
 *     'pTien_nhan' => 10000000.00,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Điều kiện WHERE rất chi tiết, đảm bảo chỉ cập nhật đúng một bản ghi (nếu tồn tại).
 * - Nếu không có bản ghi nào thỏa điều kiện, UPDATE không ảnh hưởng hàng nào và @pRet = 0 (thành công).
 * - Tham số @pTk_DU không được sử dụng trong câu lệnh, có thể là tham số dự phòng hoặc dùng cho mục đích khác (ví dụ kiểm tra logic).
 * - Hệ số và tiền nhận có thể được cập nhật độc lập, nhưng procedure này cập nhật cả hai cùng lúc.
 */
class AsCOUpdHsPb
{
    /**
     * Gọi stored procedure asCOUpdHsPb
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOUpdHsPb', $params);
    }
}