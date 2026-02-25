<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsAPDelTT
 *
 * Stored procedure: asAPDelTT
 * Mục đích: Xóa tổng hợp (APTT) của một chứng từ Accounts Payable và có thể xóa cả chứng từ thanh toán liên quan.
 * Procedure xóa các bản ghi trong bảng APTT (tổng hợp chứng từ phải trả) dựa trên mã công ty và số chứng từ.
 * Đồng thời xóa bản ghi có số chứng từ thanh toán (stt_rec_pt) nếu được cung cấp.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số chứng từ (20 ký tự) - chứng từ cần xóa.
 * - @pStt_rec_pt (string, bắt buộc): Số chứng từ thanh toán (20 ký tự) - chứng từ thanh toán liên quan cũng cần xóa.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsAPDelTT::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'AP202500001',
 *     'pStt_rec_pt' => 'PT202500001',
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
 * - Procedure xóa hai lần từ bảng APTT: lần đầu với stt_rec, lần thứ hai với stt_rec_pt.
 * - Có thể xóa cùng một bản ghi nếu stt_rec trùng stt_rec_pt (sẽ xóa hai lần nhưng không ảnh hưởng).
 * - Không có kiểm tra ràng buộc khác. Cần đảm bảo chứng từ có thể xóa được trước khi gọi.
 * - Bảng APTT lưu thông tin tổng hợp của chứng từ phải trả (số tiền, trạng thái, v.v.).
 */
class AsAPDelTT
{
    /**
     * Gọi stored procedure asAPDelTT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asAPDelTT', $params);
    }
}