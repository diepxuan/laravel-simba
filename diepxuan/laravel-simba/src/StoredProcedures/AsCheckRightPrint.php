<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCheckRightPrint
 *
 * Stored procedure: asCheckRightPrint
 * Mục đích: Kiểm tra quyền in hóa đơn dựa trên số lần đã in trong lịch sử LogPrint.
 * Procedure đếm số lần in của một hóa đơn (xác định bởi số chứng từ và số seri) và so sánh với giới hạn in (LimitedPrint).
 * Kết quả trả về cờ @pIs_oke (BIT) cho biết có được phép in hay không.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pSo_ct (string, optional, mặc định ''): Số chứng từ (số hóa đơn) (NVARCHAR(20)).
 * - @pSo_seri (string, optional, mặc định ''): Số seri của hóa đơn (NVARCHAR(20)).
 * - @pLimitedPrint (int, optional, mặc định 0): Chế độ giới hạn in:
 *     0: Không giới hạn (luôn cho phép in).
 *     1: Chỉ cho phép in nếu chưa in lần nào (tổng số lần in < 1).
 *     2: Chỉ cho phép in nếu đã in ít nhất một lần (tổng số lần in >= 1).
 * - @pIs_oke (bit, output): Kết quả kiểm tra: 1 nếu được phép in, 0 nếu không được phép.
 * 
 * Giá trị trả về:
 * - Resultset chứa một dòng một cột là giá trị @pIs_oke.
 * - Đồng thời output parameter @pIs_oke cũng được trả về trong mảng kết quả.
 * 
 * Logic chi tiết:
 * - Đếm số lần in từ bảng LogPrint với điều kiện khớp mã công ty, số chứng từ, số seri.
 * - Nếu @pLimitedPrint = 0: luôn đặt @pIs_oke = 1 (cho phép in).
 * - Nếu @pLimitedPrint = 1: cho phép in chỉ khi @pCountPrinted < 1 (chưa in lần nào).
 * - Nếu @pLimitedPrint = 2: cho phép in chỉ khi @pCountPrinted >= 1 (đã in ít nhất một lần).
 * - Cuối cùng SELECT @pIs_oke để trả về resultset.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCheckRightPrint::call([
 *     'pMa_cty' => 'CTY',
 *     'pSo_ct' => 'HD001',
 *     'pSo_seri' => 'SERI001',
 *     'pLimitedPrint' => 1,
 * ]);
 * $isOke = $result['pIs_oke'] ?? $result->first()->pIs_oke ?? null;
 * if ($isOke == 1) {
 *     // Được phép in
 * } else {
 *     // Không được phép in
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pMa_cty bắt buộc, các tham số khác có giá trị mặc định.
 * - Bảng LogPrint lưu lịch sử in ấn, cần có dữ liệu tương ứng để đếm chính xác.
 * - Giá trị @pLimitedPrint thường được cấu hình theo loại chứng từ hoặc quy định in ấn.
 * - Nếu @pSo_ct và @pSo_seri rỗng, COUNT(*) sẽ đếm tất cả bản ghi không có số chứng từ/seri (có thể không đúng ý đồ).
 * - Output parameter @pIs_oke được trả về cả trong resultset và output parameter array.
 */
class AsCheckRightPrint
{
    /**
     * Gọi stored procedure asCheckRightPrint
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter và resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCheckRightPrint', $params);
    }
}