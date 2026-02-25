<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsFADelDMNHTS
 *
 * Stored procedure: asFADelDMNHTS
 * Mục đích: Xóa danh mục nhóm tài sản (NHTS) trong module Tài sản cố định.
 * Procedure thực hiện kiểm tra xem mã nhóm tài sản có tồn tại trong bảng FADMNHTS không thông qua procedure afChkExistsCodeDict.
 * Nếu không tồn tại (afChkExistsCodeDict trả về khác 0), sẽ trả về mã lỗi 50004.
 * Nếu tồn tại (afChkExistsCodeDict trả về 0), tiến hành xóa bản ghi trong bảng FADMNHTS (theo mã công ty, mã nhóm tài sản và loại nhóm) và trả về @@error.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_nhts (string, bắt buộc): Mã nhóm tài sản (8 ký tự).
 * - @pLoai_nh (string, bắt buộc): Loại nhóm (1 ký tự). Giá trị có thể là mã phân loại nhóm tài sản.
 * - @pRet (int, output): Kết quả trả về: 0 - Được phép xóa và xóa thành công, <>0 - Không được phép xóa hoặc có lỗi.
 *   - 50004: Mã NHTS không tồn tại (theo kiểm tra của afChkExistsCodeDict).
 *   - Giá trị khác: Lỗi SQL từ @@error sau khi DELETE.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsFADelDMNHTS::call([
 *     'pMa_cty' => '001',
 *     'pMa_nhts' => 'NH001',
 *     'pLoai_nh' => 'A',
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
 * - Procedure này sử dụng một stored procedure hệ thống khác (afChkExistsCodeDict) để kiểm tra tồn tại mã.
 * - Mã lỗi 50004 có thể là mã lỗi quy ước trong hệ thống Simba.
 * - Điều kiện xóa bao gồm cả Loai_nh, cần truyền đúng loại nhóm.
 * - Nếu xóa thành công, @@error thường là 0 (trừ khi có lỗi trigger hoặc ràng buộc).
 * - Cần đảm bảo quyền DELETE trên bảng FADMNHTS.
 */
class AsFADelDMNHTS
{
    /**
     * Gọi stored procedure asFADelDMNHTS
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet cần được khai báo
        // ProcedureCaller hiện tại chưa hỗ trợ output parameters, cần mở rộng sau.
        return ProcedureCaller::call('asFADelDMNHTS', $params);
    }
}