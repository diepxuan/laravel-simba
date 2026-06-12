<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOUpdDMSPCT
 *
 * Stored procedure: asCOUpdDMSPCT
 * Mục đích: Cập nhật danh mục sản phẩm công trình (CODMSPCT).
 * Procedure thực hiện cập nhật thông tin của một sản phẩm công trình dựa trên mã công ty và mã sản phẩm công trình.
 * Các thông tin cập nhật bao gồm: tên sản phẩm, đơn vị tính, mã nhóm sản phẩm công trình, loại sản phẩm, cờ sử dụng,
 * ngày khởi công, ngày kết thúc, dự toán, dự toán ngoại tệ, đơn vị thi công, ghi chú, và thông tin người cập nhật.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự). Khóa chính.
 * - @pTen_spct (string, bắt buộc): Tên sản phẩm công trình (100 ký tự).
 * - @pNgay_kc (string, bắt buộc): Ngày khởi công (SMALLDATETIME, định dạng 'YYYY-MM-DD').
 * - @pNgay_kt (string, bắt buộc): Ngày kết thúc (SMALLDATETIME).
 * - @pDu_toan (float, bắt buộc): Dự toán (số tiền) - DECIMAL(19,4).
 * - @pDu_toan_NT (float, bắt buộc): Dự toán ngoại tệ - DECIMAL(19,4).
 * - @pDv_tc (string, bắt buộc): Đơn vị thi công (100 ký tự).
 * - @pGhi_chu (string, tùy chọn): Ghi chú (255 ký tự). Có thể là chuỗi rỗng.
 * - @pDvt (string, bắt buộc): Đơn vị tính (8 ký tự).
 * - @pMa_nhspct (string, bắt buộc): Mã nhóm sản phẩm công trình (20 ký tự).
 * - @pSan_pham (string, bắt buộc): Loại sản phẩm (1 ký tự). Ví dụ: '1' cho sản phẩm, '0' cho dịch vụ? (cần kiểm tra logic).
 * - @pKsd (bool, bắt buộc): Cờ sử dụng (bit). 1 = đang sử dụng, 0 = ngừng sử dụng.
 * - @pLUser (string, bắt buộc): Người cập nhật (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. Giá trị lỗi SQL (0 thành công, khác 0 lỗi).
 * 
 * Giá trị mặc định:
 * - Không có tham số nào có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu cập nhật thành công, khác 0 nếu có lỗi (thường là mã lỗi SQL).
 * - Nếu không có bản ghi nào thỏa mãn điều kiện WHERE, UPDATE sẽ không ảnh hưởng đến hàng nào và @pRet vẫn là 0 (không có lỗi).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOUpdDMSPCT::call([
 *     'pMa_cty' => '001',
 *     'pMa_spct' => 'SP001',
 *     'pTen_spct' => 'Xây dựng nhà máy A',
 *     'pNgay_kc' => '2024-01-01',
 *     'pNgay_kt' => '2024-12-31',
 *     'pDu_toan' => 1000000000.00,
 *     'pDu_toan_NT' => 1000000000.00,
 *     'pDv_tc' => 'Công ty XD ABC',
 *     'pGhi_chu' => 'Dự án trọng điểm',
 *     'pDvt' => 'Cái',
 *     'pMa_nhspct' => 'NH001',
 *     'pSan_pham' => '1',
 *     'pKsd' => true,
 *     'pLUser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure chỉ cập nhật các trường được liệt kê, không thay đổi các trường khác (ví dụ: mã sản phẩm, mã công ty không thay đổi).
 * - Trường Ldate được tự động cập nhật bằng GETDATE() (thời điểm thực thi procedure).
 * - Nên đảm bảo mã sản phẩm công trình tồn tại trước khi gọi, nếu không sẽ không có bản ghi nào được cập nhật (vẫn thành công nhưng không thay đổi dữ liệu).
 * - Kiểu dữ liệu bit (pKsd) trong PHP có thể truyền giá trị boolean (true/false) hoặc integer (1/0). SQL Server sẽ chuyển đổi phù hợp.
 */
class AsCOUpdDMSPCT
{
    /**
     * Gọi stored procedure asCOUpdDMSPCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOUpdDMSPCT', $params);
    }
}