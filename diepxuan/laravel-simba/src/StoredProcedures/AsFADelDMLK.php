<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsFADelDMLK
 *
 * Stored procedure: asFADelDMLK
 * Mục đích: Xóa danh mục liên kết (LK) của tài sản cố định trong module Tài sản cố định.
 * Procedure thực hiện xóa bản ghi trong bảng FaDmLK dựa trên mã công ty, mã tài sản, mã tài sản thay thế (?) và mã liên kết.
 * Lưu ý: Phần kiểm tra tồn tại mã liên kết thông qua afChkExistsCodeDict đã bị comment, chỉ còn thao tác DELETE thuần túy.
 * Kết quả trả về là giá trị @@error (0 nếu thành công, khác 0 nếu có lỗi).
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_ts (string, bắt buộc): Mã tài sản cố định (20 ký tự).
 * - @pMa_Ts_Tgng (string, bắt buộc): Mã tài sản thay thế? (20 ký tự). (Tham số này có vẻ không được sử dụng trong điều kiện DELETE, có thể là thừa).
 * - @pMa_lk (string, bắt buộc): Mã liên kết (20 ký tự).
 * - @pRet (int, output): Kết quả trả về: 0 - Xóa thành công, <>0 - Lỗi SQL (giá trị @@error).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsFADelDMLK::call([
 *     'pMa_cty' => '001',
 *     'pMa_ts' => 'TS001',
 *     'pMa_Ts_Tgng' => 'TS002',
 *     'pMa_lk' => 'LK001',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, mã lỗi: $ret
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pMa_Ts_Tgng không xuất hiện trong mệnh đề WHERE của DELETE, có thể là dư thừa hoặc dùng cho mục đích khác.
 * - Điều kiện xóa: Ma_cty, Ma_ts, Ma_lk khớp. Cần đảm bảo bản ghi tồn tại trước khi xóa.
 * - Nếu có ràng buộc khóa ngoại hoặc trigger, DELETE có thể thất bại.
 * - Giá trị @pRet là @@error, thường là 0 nếu không có lỗi.
 */
class AsFADelDMLK
{
    /**
     * Gọi stored procedure asFADelDMLK
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asFADelDMLK', $params);
    }
}