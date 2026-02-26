<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 11:49:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Illuminate\Support\Collection;

/**
 * Class AsPoFilt0.
 *
 * Stored procedure: asPOFilt0
 * Mục đích: Lọc danh sách chứng từ đơn đặt hàng (POPH0) và chi tiết (POCT0) dựa trên điều kiện truyền vào.
 * Procedure sử dụng dynamic SQL để xây dựng câu truy vấn linh hoạt, trả về hai resultset:
 *   - Resultset 1: Thông tin chứng từ POPH0 (header) kèm thông tin bộ phận.
 *   - Resultset 2: Chi tiết hàng hóa POCT0 kèm thông tin kho, lô, bộ phận, hợp đồng, phí, sản phẩm.
 *
 * Tham số:
 * - @pKeyPh (string, bắt buộc): Điều kiện WHERE dạng chuỗi để lọc bảng POPH0 (không bao gồm từ khóa WHERE).
 * - @pKeyCt (string, bắt buộc): Điều kiện WHERE dạng chuỗi để lọc bảng POCT0 (không bao gồm từ khóa WHERE).
 *
 * Giá trị trả về:
 * - Hai resultset được trả về liên tiếp.
 *   + Resultset 1: các cột: chon, ma_cty, stt_rec, ma_ct, ma_bp, ten_bp, nguoi_dn, dien_giai, ngay_ct, so_ct, ngay_lct, han_giao, t_so_luong, post2gl, trang_thai, tao_tu_dhb, cdate, cuser, ldate, luser.
 *   + Resultset 2: các cột: ma_cty, stt_rec, stt_rec0, ma_vt, ten_vt, tk_vt, so_luong, dvt, so_luong_qd, ton, ton_all, ton_mua, ton_mua_all, ton_ban, ton_ban_all, stt_rec_dhb, stt_rec0_dhb, so_dhb, ma_kho, ten_kho, dia_chi, ma_vitri, ten_vitri, ma_lo, ten_lo, ma_bp, ten_bp, ma_hd, ten_hd, ma_phi, ten_phi, ma_spct, ten_spct.
 *
 * Ví dụ gọi:
 * ```php
 * $results = AsPoFilt0::call([
 *     'pKeyPh' => "ma_cty = '001' and ngay_ct >= '2025-01-01'",
 *     'pKeyCt' => "ma_vt like 'VT001%'",
 * ]);
 * // $results là một mảng chứa hai resultset (có thể cần xử lý đặc biệt).
 * ```
 *
 * Lưu ý:
 * - Procedure sử dụng `sp_executesql` để thực thi dynamic SQL, cần cẩn thận với SQL injection.
 * - Người gọi phải đảm bảo điều kiện truyền vào an toàn (không chứa mã độc).
 * - Kết quả trả về nhiều resultset, cần sử dụng DB::select với multiple results hoặc điều chỉnh ProcedureCaller.
 */
class AsPOFilt0 extends StoredProcedure
{
    public const NAME = 'asPOFilt0';

    /**
     * Call stored procedure asPOFilt0.
     *
     * @param array $params Procedure parameters
     */
    public static function call(array $params = []): Collection
    {
        return parent::call(array_merge([
            'pKeyPh' => $params['pKeyPh'] ?? null,
            'pKeyCt' => $params['pKeyCt'] ?? null,
        ], $params));
    }

    /**
     * Call stored procedure asPOFilt0 with named parameters.
     */
    public static function callWithParams(?string $KeyPh = null, ?string $KeyCt = null): Collection
    {
        $params = [
            'pKeyPh' => $KeyPh,
            'pKeyCt' => $KeyCt,
        ];

        return self::call($params);
    }
}
