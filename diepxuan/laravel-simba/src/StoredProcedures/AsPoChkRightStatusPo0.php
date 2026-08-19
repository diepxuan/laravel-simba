<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsPoChkRightStatusPo0
 *
 * Stored procedure: asPOChkRightStatusPO0
 * Mục đích: Kiểm tra trạng thái chứng từ trước khi sửa/xóa đơn đặt hàng (Purchase Order).
 * Procedure kiểm tra xem chứng từ có tồn tại và trả về thông tin định dạng: mã chứng từ | ngày chứng từ | số chứng từ.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số tham chiếu (stt_rec) của chứng từ cần kiểm tra.
 * - @pLanguage (string, tùy chọn, mặc định 'vi-VN'): Ngôn ngữ định dạng ngày tháng. Hỗ trợ 'vi-VN' (định dạng 103) hoặc khác (định dạng 101).
 * 
 * Giá trị trả về:
 * - Một dòng chứa chuỗi thông báo định dạng: "ma_ct | ngay_ct | so_ct"
 * - Nếu không tìm thấy, trả về null.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsPoChkRightStatusPo0::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 *     'pLanguage' => 'vi-VN',
 * ]);
 * ```
 * 
 * Lưu ý:
 * - Procedure này thường được gọi trước khi thực hiện sửa/xóa chứng để đảm bảo chứng từ ở trạng thái hợp lệ.
 * - Ngày tháng được định dạng theo quy tắc của SQL Server (101 hoặc 103) tùy ngôn ngữ.
 */
class AsPoChkRightStatusPo0
{
    /**
     * Gọi stored procedure asPOChkRightStatusPO0
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (thường là một chuỗi hoặc null).
     */
    public static function call(array $params = [])
    {
        // Giá trị mặc định cho pLanguage
        $defaultParams = ['pLanguage' => 'vi-VN'];
        $params = array_merge($defaultParams, $params);

        return ProcedureCaller::call('asPOChkRightStatusPO0', $params);
    }
}