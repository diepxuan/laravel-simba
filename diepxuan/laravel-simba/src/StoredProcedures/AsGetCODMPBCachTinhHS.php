<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsGetCODMPBCachTinhHS
 *
 * Stored procedure: asGetCODMPBCachTinhHS
 * Mục đích: Lấy danh sách cách tính hệ số phân bổ (CODMPBCachTinhHS) theo công ty, module và trạng thái sử dụng.
 * Procedure trả về id và tên cách tính hệ số, có hỗ trợ đa ngôn ngữ.
 * 
 * Tham số:
 * - @pMa_cty (string, tùy chọn): Mã công ty (NVARCHAR(3)).
 *   Giá trị mặc định: NULL (có thể lấy tất cả công ty? nhưng WHERE a.ma_cty = @pMa_cty nên nếu NULL sẽ không khớp).
 * - @pKsd (bit, tùy chọn): Trạng thái sử dụng (0: ngừng sử dụng, 1: đang sử dụng).
 *   Giá trị mặc định: 0
 * - @pModuleId (string, tùy chọn): Mã module (NVARCHAR(8)).
 *   Giá trị mặc định: 'CO'
 * - @pLanguage (string, tùy chọn): Mã ngôn ngữ (NVARCHAR(5)).
 *   Giá trị mặc định: 'vi-VN'
 * 
 * Giá trị trả về:
 * - Procedure trả về một resultset với các cột:
 *   - id (int?): ID cách tính hệ số.
 *   - ten (string): Tên cách tính (ưu tiên bản dịch nếu có).
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * 1. LEFT JOIN CODMPBCachTinhHS a (bảng chính) với CODMPBCachTinhHSResx b (bản dịch) trên điều kiện a.id = b.id AND a.moduleid = b.moduleid AND b.language = @pLanguage.
 * 2. WHERE a.ma_cty = @pMa_cty AND a.moduleID = @pModuleId AND a.ksd = @pKsd.
 * 3. Sử dụng ISNULL(b.ten, a.ten) để ưu tiên giá trị dịch.
 * 
 * Ví dụ gọi:
 * ```php
 * $rows = AsGetCODMPBCachTinhHS::call([
 *     'pMa_cty' => '001',
 *     'pKsd' => 1,
 *     'pModuleId' => 'CO',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * // Hoặc sử dụng giá trị mặc định (cần truyền ít nhất pMa_cty vì NULL sẽ không khớp):
 * $rows = AsGetCODMPBCachTinhHS::call(['pMa_cty' => '001']);
 * foreach ($rows as $row) {
 *     echo "ID: {$row->id}, Tên cách tính: {$row->ten}";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pMa_cty có giá trị mặc định NULL, nhưng điều kiện WHERE a.ma_cty = @pMa_cty nên nếu truyền NULL sẽ không trả về bản ghi nào (trừ khi có bản ghi với ma_cty NULL, nhưng không có).
 *   Do đó, nên luôn truyền mã công ty hợp lệ.
 * - @pKsd mặc định là 0 (ngừng sử dụng), nếu muốn lấy cách tính đang sử dụng cần truyền 1.
 * - Module mặc định là 'CO' (kế toán chi phí).
 * - Ngôn ngữ mặc định là 'vi-VN'.
 * - Bảng CODMPBCachTinhHS lưu các phương pháp tính hệ số phân bổ, dùng trong tính phân bổ chi phí.
 */
class AsGetCODMPBCachTinhHS
{
    /**
     * Gọi stored procedure asGetCODMPBCachTinhHS
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các bản ghi).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asGetCODMPBCachTinhHS', $params);
    }
}