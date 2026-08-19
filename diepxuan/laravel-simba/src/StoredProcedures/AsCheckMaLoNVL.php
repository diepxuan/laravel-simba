<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsCheckMaLoNVL
 *
 * Stored procedure: asCheckMaLoNVL
 * Mục đích: Kiểm tra mã lô nguyên vật liệu (NVL) có tồn tại trong bảng mmdmlonvl với điều kiện loại trừ một stt_rec_pn cụ thể.
 * Procedure thực hiện SELECT mã lô từ bảng mmdmlonvl với điều kiện khớp công ty, mã lô, và khác stt_rec_pn.
 * Sử dụng để kiểm tra tính duy nhất của mã lô NVL khi nhập liệu, đảm bảo không trùng lặp với các phiếu nhập khác.
 * 
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(20)).
 * - @pMa_lo (string, bắt buộc): Mã lô nguyên vật liệu cần kiểm tra (NVARCHAR(20)).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi (stt_rec) của phiếu nhập cần loại trừ (NVARCHAR(50)).
 * 
 * Giá trị trả về:
 * - Resultset chứa cột ma_lo_nvl nếu tìm thấy, ngược lại trả về empty set.
 * - Không có output parameter.
 * 
 * Logic chi tiết:
 * - SELECT ma_lo_nvl FROM mmdmlonvl WHERE ma_cty = @pMa_cty AND ma_lo_nvl = @pMa_lo AND stt_rec_pn <> @pStt_rec
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsCheckMaLoNVL::call([
 *     'pMa_cty' => 'CTY01',
 *     'pMa_lo' => 'L001',
 *     'pStt_rec' => 'PN2025001',
 * ]);
 * // $result là collection chứa các dòng kết quả (nếu có)
 * if ($result->isNotEmpty()) {
 *     // Mã lô đã tồn tại cho phiếu nhập khác
 * } else {
 *     // Mã lô có thể sử dụng (chưa tồn tại hoặc chỉ tồn tại cho chính phiếu này)
 * }
 * ```
 * 
 * Lưu ý:
 * - Cả ba tham số đều bắt buộc, không có giá trị mặc định.
 * - Điều kiện stt_rec_pn <> @pStt_rec nhằm loại trừ chính phiếu nhập hiện tại khi kiểm tra trùng lặp.
 * - Bảng mmdmlonvl lưu danh mục lô nguyên vật liệu, liên kết với phiếu nhập qua stt_rec_pn.
 * - Procedure này thường được gọi trước khi lưu phiếu nhập để đảm bảo mã lô không trùng với phiếu khác cùng công ty.
 */
class AsCheckMaLoNVL
{
    /**
     * Gọi stored procedure asCheckMaLoNVL
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (resultset).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asCheckMaLoNVL', $params);
    }
}