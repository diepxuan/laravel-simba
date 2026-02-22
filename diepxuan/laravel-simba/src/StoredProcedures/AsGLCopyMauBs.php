<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGLCopyMauBs
 *
 * Stored procedure: asGLCopyMauBs
 * Mục đích: Copy cách tính giữa 2 công ty từ bảng GLMauBs (mẫu bảng cân đối).
 * Procedure thực hiện:
 *   1. Xóa dữ liệu cũ trong bảng Glbs (có thể là bảng tạm) cho công ty đích (ma_cty1) và mã mẫu (mau).
 *   2. Chèn dữ liệu từ bảng glmaubs của công ty nguồn (ma_cty2) và mã mẫu (mau) vào công ty đích.
 * Dùng để sao chép cấu hình mẫu báo cáo tài chính (balance sheet template) giữa các công ty.
 * 
 * Tham số:
 * - @pMa_cty1 (string, bắt buộc): Mã công ty đích (3 ký tự). Dữ liệu sẽ được copy đến công ty này.
 * - @pMa_cty2 (string, bắt buộc): Mã công ty nguồn (3 ký tự). Dữ liệu được lấy từ công ty này.
 * - @pMau (string, bắt buộc): Mã mẫu (10 ký tự). Xác định mẫu báo cáo cần copy.
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 là mã lỗi SQL (thường là @@error).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsGLCopyMauBs::call([
 *     'pMa_cty1' => '001',
 *     'pMa_cty2' => '002',
 *     'pMau' => 'BS01',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Copy thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 * 
 * Lưu ý:
 * - Procedure xóa dữ liệu cũ trong bảng Glbs (không phải glmaubs). Cần xác định bảng Glbs là gì (có thể là bảng tạm).
 * - Dữ liệu được copy từ bảng glmaubs (có lẽ là bảng mẫu báo cáo) với các cột: ma_cty, mau, stt, bold, in_ck, ts_nv, cong_no, ngoai_bang, sodu_duong, tk, cach_tinh, ma_so, chi_tieu, tien0, tien, tien_nt0, tien_nt, xtag, xstt, tm.
 * - Chỉ copy các bản ghi phù hợp với mã công ty nguồn và mã mẫu.
 * - Không có kiểm tra ràng buộc khác (như sự tồn tại của công ty, mã mẫu). Cần đảm bảo tham số hợp lệ trước khi gọi.
 */
class AsGLCopyMauBs
{
    /**
     * Gọi stored procedure asGLCopyMauBs
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGLCopyMauBs', $params);
    }
}