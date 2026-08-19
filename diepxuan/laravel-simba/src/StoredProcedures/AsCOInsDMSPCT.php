<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOInsDMSPCT
 *
 * Stored procedure: asCOInsDMSPCT
 * Mục đích: Thêm mới danh mục sản phẩm công trình (CODMSPCT).
 * Procedure thực hiện chèn một bản ghi mới vào bảng danh mục sản phẩm công trình với đầy đủ thông tin.
 * Các trường ngày tạo (cdate), ngày sửa (ldate) và người dùng (cuser, luser) được tự động điền.
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
 * - @pLUser (string, bắt buộc): Người tạo (20 ký tự). Sẽ được gán cho cả cuser và luser.
 * - @pRet (int, output): Kết quả trả về. Giá trị lỗi SQL (0 thành công, khác 0 lỗi).
 * 
 * Giá trị mặc định:
 * - Không có tham số nào có giá trị mặc định.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu chèn thành công, khác 0 nếu có lỗi (thường là mã lỗi SQL, ví dụ vi phạm khóa chính).
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCOInsDMSPCT::call([
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
 *     // Thêm mới thành công
 * } else {
 *     // Có lỗi xảy ra (có thể trùng mã sản phẩm)
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure gán cdate = GETDATE(), ldate = GETDATE(), cuser = @pLUser, luser = @pLUser.
 * - Nếu mã sản phẩm công trình đã tồn tại (vi phạm khóa chính), SQL Server sẽ ném lỗi và @pRet sẽ nhận giá trị lỗi tương ứng.
 * - Kiểu dữ liệu bit (pKsd) trong PHP có thể truyền giá trị boolean (true/false) hoặc integer (1/0).
 * - Ngày khởi công và ngày kết thúc có thể là NULL? Không, tham số bắt buộc.
 */
class AsCOInsDMSPCT
{
    /**
     * Gọi stored procedure asCOInsDMSPCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOInsDMSPCT', $params);
    }
}