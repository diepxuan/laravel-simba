<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsFAChkThoiKHTS
 *
 * Stored procedure: asFAChkThoiKHTS
 * Mục đích: Kiểm tra thông tin tạm ngừng khấu hao tài sản cố định (TSCĐ).
 * Procedure đếm số lượng bản ghi trong bảng fadmts thỏa mãn điều kiện:
 * - Mã công ty và mã tài sản khớp.
 * - Tài sản đã được đánh dấu giảm (is_giam = '1').
 * - Ngày giảm (ngay_giam) nhỏ hơn ngày tạm ngừng khấu hao được cung cấp (@pNgay_dung_kh).
 * Kết quả trả về là số lượng bản ghi thỏa mãn (COUNT(*)).
 * 
 * Tham số:
 * - @pma_cty (string, bắt buộc): Mã công ty (3 ký tự). Lưu ý tên tham số trong SQL viết thường.
 * - @pma_ts (string, bắt buộc): Mã tài sản cố định (20 ký tự).
 * - @pNgay_dung_kh (datetime, bắt buộc): Ngày tạm ngừng khấu hao (kiểu SMALLDATETIME).
 * 
 * Giá trị trả về:
 * - Một resultset gồm một cột (không tên) chứa số nguyên (COUNT(*)).
 * - Có thể lấy giá trị đầu tiên của kết quả để biết số lượng bản ghi thỏa mãn.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsFAChkThoiKHTS::call([
 *     'pma_cty' => '001',
 *     'pma_ts' => 'TS001',
 *     'pNgay_dung_kh' => '2025-02-11',
 * ]);
 * // $result là mảng các đối tượng stdClass, mỗi đối tượng có một thuộc tính không tên.
 * // Để lấy giá trị count:
 * $count = $result[0]->{' '} ?? $result[0]->{''} ?? null; // Cẩn thận với tên cột không tên.
 * // Hoặc dùng current() và get_object_vars
 * $first = current($result);
 * $count = $first ? (int) current(get_object_vars($first)) : 0;
 * ```
 * 
 * Lưu ý:
 * - Procedure này dùng để kiểm tra xem tài sản đã bị giảm trước ngày tạm ngừng khấu hao chưa.
 * - Nếu count > 0, có nghĩa tài sản đã giảm trước ngày đó, có thể không được phép tạm ngừng khấu hao.
 * - Tên tham số trong SQL viết thường (pma_cty, pma_ts) nhưng khi gọi có thể dùng cả tên viết hoa hoặc thường.
 */
class AsFAChkThoiKHTS
{
    /**
     * Gọi stored procedure asFAChkThoiKHTS
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (mảng các đối tượng stdClass).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asFAChkThoiKHTS', $params);
    }
}