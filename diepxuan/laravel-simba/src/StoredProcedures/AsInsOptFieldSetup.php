<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsInsOptFieldSetup
 *
 * Stored procedure: asInsOptFieldSetup
 * Mục đích: Thêm mới một bản ghi vào bảng sysOptFieldSetup (thiết lập trường tùy chọn).
 * Bảng này lưu cấu hình các trường tùy chọn cho chứng từ (voucher), xác định trường nào áp dụng cho master, detail.
 * Cột Stt luôn được gán giá trị '1' (có thể là mặc định hoặc chỉ có một bản ghi cho mỗi voucher_code + field).
 * 
 * Tham số:
 * - @pVoucher_code (string, bắt buộc): Mã chứng từ (3 ký tự). Ví dụ: 'CP1', 'CP2'.
 * - @pField (string, bắt buộc): Tên trường (10 ký tự). Tên trường tùy chọn.
 * - @pMaster (bool, bắt buộc): Áp dụng cho master (bit). 1 = trường này có trong phần master của chứng từ.
 * - @pDetail (bool, bắt buộc): Áp dụng cho detail (bit). 1 = trường này có trong phần detail (chi tiết) của chứng từ.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 * 
 * Giá trị mặc định:
 * - Không có.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 * 
 * Logic chi tiết:
 * 1. INSERT vào sysOptFieldSetup với các giá trị truyền vào, Stt = '1' (chuỗi).
 * 2. Gán @pRet = @@ERROR.
 * 
 * Lưu ý:
 * - Bảng sysOptFieldSetup có khóa chính có thể là (Voucher_code, field) hoặc (Stt, Voucher_code, field).
 * - Cột Stt kiểu gì? Có thể là NVARCHAR(1) và luôn là '1'. Có thể dùng để phân loại nếu có nhiều thiết lập.
 * - Trường Master và Detail độc lập: một trường có thể có trong cả master và detail (cả hai đều 1), hoặc chỉ một trong hai.
 * - Nên đảm bảo voucher_code tồn tại trong danh mục chứng từ.
 * - Nếu đã có bản ghi với cùng voucher_code và field, INSERT sẽ gây lỗi vi phạm khóa chính.
 * - Procedure không kiểm tra trùng lặp trước khi INSERT.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsInsOptFieldSetup::call([
 *     'pVoucher_code' => 'CP1',
 *     'pField' => 'Ma_kh',
 *     'pMaster' => true,
 *     'pDetail' => false,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 * 
 * Liên quan:
 * - Bảng sysOptFieldSetup: lưu thiết lập trường tùy chọn.
 * - Các procedure khác: asGetOptFieldSetup, asUpdOptFieldSetup, asDelOptFieldSetup.
 */
class AsInsOptFieldSetup
{
    /**
     * Gọi stored procedure asInsOptFieldSetup
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter @pRet).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asInsOptFieldSetup', $params);
    }
}