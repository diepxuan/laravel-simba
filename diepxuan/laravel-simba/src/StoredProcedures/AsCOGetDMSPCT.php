<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCOGetDMSPCT
 *
 * Stored procedure: asCOGetDMSPCT
 * Mục đích: Lấy danh sách danh mục sản phẩm công trình (CODMSPCT) kết hợp với tên nhóm sản phẩm công trình.
 * Procedure hỗ trợ lọc theo mã công ty, mã sản phẩm công trình, loại sản phẩm (san_pham) và một cờ cấu trúc (@pStruct) hiện chưa sử dụng.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định ''): Mã công ty (3 ký tự). Sử dụng LIKE với '%' ở sau.
 * - @pMa_spct (string, tùy chọn, mặc định ''): Mã sản phẩm công trình (20 ký tự). Sử dụng LIKE với '%' ở sau.
 * - @pStruct (string, tùy chọn, mặc định '0'): Cờ cấu trúc (1 ký tự). Hiện tại luôn so sánh với '0' trong WHERE, không ảnh hưởng kết quả (có thể dùng cho mở rộng).
 * - @pIsSP (string, tùy chọn, mặc định '0'): Loại sản phẩm (1 ký tự). Giá trị '0' có thể là sản phẩm, '1' là dịch vụ? Cần kiểm tra logic.
 * 
 * Giá trị mặc định:
 * - @pMa_cty = ''
 * - @pMa_spct = ''
 * - @pStruct = '0'
 * - @pIsSP = '0'
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - ma_cty (string)
 *   - ma_spct (string)
 *   - ten_spct (string)
 *   - dvt (string): đơn vị tính.
 *   - ma_nhspct (string): mã nhóm sản phẩm công trình.
 *   - ten_nhspct (string): tên nhóm (lấy từ codmnhspct).
 *   - san_pham (string): loại sản phẩm.
 *   - ksd (bit): cờ sử dụng.
 *   - cdate (datetime): ngày tạo.
 *   - cuser (string): người tạo.
 *   - ldate (datetime): ngày sửa.
 *   - luser (string): người sửa.
 *   - Ngay_kc (smalldatetime): ngày khởi công.
 *   - Ngay_kt (smalldatetime): ngày kết thúc.
 *   - Du_toan (decimal): dự toán.
 *   - Du_toan_NT (decimal): dự toán ngoại tệ.
 *   - Dv_tc (string): đơn vị thi công.
 *   - Ghi_chu (string): ghi chú.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. SELECT từ CODMSPCT a LEFT JOIN codmnhspct b trên mã công ty và mã nhóm.
 * 2. Điều kiện WHERE:
 *    - a.Ma_cty LIKE @pMa_cty + '%'
 *    - a.Ma_spct LIKE @pMa_spct + '%'
 *    - a.san_pham = @pIsSP
 *    - @pStruct = '0' (luôn đúng nếu truyền '0', nếu truyền khác '0' sẽ không trả về bản ghi nào? Thực tế so sánh với giá trị cố định '0', không phải với cột).
 * 3. ORDER BY a.san_pham.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsCOGetDMSPCT::call([
 *     'pMa_cty' => 'Q15',
 *     'pMa_spct' => 'SP',
 *     'pStruct' => '0',
 *     'pIsSP' => '1',
 * ]);
 * // $rows là mảng các đối tượng stdClass hoặc mảng kết hợp.
 * foreach ($rows as $row) {
 *     echo "Mã SPCT: {$row->ma_spct}, Tên: {$row->ten_spct}, Nhóm: {$row->ten_nhspct}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pStruct có vẻ không dùng để lọc dữ liệu thực tế, chỉ là điều kiện cố định. Có thể dùng để tắt/mở một tính năng nào đó trong tương lai.
 * - Nếu truyền @pStruct khác '0', WHERE sẽ sai và không trả về bản ghi nào.
 * - Cột san_pham lọc bằng dấu '=', không dùng LIKE.
 * - Kết quả LEFT JOIN nên các sản phẩm không có nhóm vẫn xuất hiện với ten_nhspct là NULL.
 */
class AsCOGetDMSPCT
{
    /**
     * Gọi stored procedure asCOGetDMSPCT
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCOGetDMSPCT', $params);
    }
}