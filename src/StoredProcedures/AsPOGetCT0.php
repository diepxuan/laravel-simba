<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 12:01:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPoGetCt0.
 *
 * Stored procedure: asPOGetCT0
 * Mục đích: Lấy danh sách chi tiết hàng hóa (POCT0) theo mã công ty và số tham chiếu.
 * Procedure truy vấn bảng POCT0 với khả năng lọc linh hoạt, hỗ trợ tìm kiếm theo pattern.
 *
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định null): Mã công ty (3 ký tự). Nếu null sẽ chuyển thành '%' (tất cả).
 * - @pStt_rec (string, tùy chọn, mặc định null): Số tham chiếu (stt_rec) của chứng từ. Nếu null sẽ chuyển thành '%'.
 * - @pStruct (string, tùy chọn, mặc định '0'): Cấu trúc? Giá trị mặc định '0', nếu null cũng gán thành '0'.
 *
 * Giá trị trả về:
 * - Resultset gồm các cột: ma_cty, stt_rec, stt_rec0, ma_vt, ten_vt, tk_vt, so_luong, dvt, so_luong_qd, ton, ton_all, ton_mua, ton_mua_all, ton_ban, ton_ban_all, stt_rec_dhb, stt_rec0_dhb, so_dhb, ma_kho, ten_kho, dia_chi, ma_vitri, ten_vitri, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 * - Dữ liệu được lọc bằng điều kiện LIKE với pattern @pMa_cty + '%' và @pStt_rec + '%', đồng thời @pStruct phải bằng '0'.
 *
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả chi tiết hàng hóa của công ty 001
 * $results = AsPoGetCt0::call([
 *     'pMa_cty' => '001',
 * ]);
 * // Lấy chi tiết của một chứng từ cụ thể
 * $results = AsPoGetCt0::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 * ]);
 * // Lấy tất cả chi tiết (không lọc)
 * $results = AsPoGetCt0::call([]);
 * ```
 *
 * Lưu ý:
 * - Tham số @pStruct hiện luôn so sánh bằng '0', có thể dùng để mở rộng sau.
 * - Pattern tìm kiếm sử dụng LIKE, nên có thể dùng ký tự đại diện SQL (%, _) nếu truyền trực tiếp.
 * - Nếu muốn lấy chính xác mã công ty, nên truyền giá trị đầy đủ không kèm '%'.
 */
class AsPOGetCT0 extends StoredProcedure
{
    public const NAME = 'asPOGetCT0';

    /**
     * Gọi stored procedure asPOGetCT0.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (mảng các đối tượng stdClass)
     *               Call stored procedure asPOGetCT0
     */
    public static function call(array $params): Collection
    {
        return parent::call(array_merge([
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStruct'  => $params['pStruct'] ?? null,
        ], $params));
    }

    /**
     * Call stored procedure asPOGetCT0 with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, ?string $Struct = null): Collection
    {
        $params = [
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStruct'  => $Struct,
        ];

        return self::call($params);
    }
}
