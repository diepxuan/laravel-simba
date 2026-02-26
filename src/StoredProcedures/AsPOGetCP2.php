<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 11:56:28
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPoGetCp2.
 *
 * Stored procedure: asPOGetCP2
 * Mục đích: Lấy danh sách chi phí (POCP2) theo mã công ty và số tham chiếu.
 * Procedure truy vấn bảng POCP2 với khả năng lọc linh hoạt, hỗ trợ tìm kiếm theo pattern.
 *
 * Tham số:
 * - @pMa_cty (string, tùy chọn, mặc định null): Mã công ty (3 ký tự). Nếu null sẽ chuyển thành '%' (tất cả).
 * - @pStt_rec (string, tùy chọn, mặc định null): Số tham chiếu (stt_rec) của chứng từ. Nếu null sẽ chuyển thành '%'.
 * - @pStruct (string, tùy chọn, mặc định '0'): Cấu trúc? Giá trị mặc định '0', nếu null cũng gán thành '0'.
 *
 * Giá trị trả về:
 * - Resultset gồm các cột: ma_cty, stt_rec, stt_rec0, ma_cp, ten_cp, tt_pb, tien_cp_nt, tien_cp, ts_gtgt, thue_gtgt_nt, thue_gtgt, tt_nt, tt.
 * - Dữ liệu được lọc bằng điều kiện LIKE với pattern @pMa_cty + '%' và @pStt_rec + '%', đồng thời @pStruct phải bằng '0'.
 *
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả chi phí của công ty 001
 * $results = AsPoGetCp2::call([
 *     'pMa_cty' => '001',
 * ]);
 * // Lấy chi phí của một chứng từ cụ thể
 * $results = AsPoGetCp2::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'PO202500001',
 * ]);
 * // Lấy tất cả chi phí (không lọc)
 * $results = AsPoGetCp2::call([]);
 * ```
 *
 * Lưu ý:
 * - Tham số @pStruct hiện luôn so sánh bằng '0', có thể dùng để mở rộng sau.
 * - Pattern tìm kiếm sử dụng LIKE, nên có thể dùng ký tự đại diện SQL (%, _) nếu truyền trực tiếp.
 * - Nếu muốn lấy chính xác mã công ty, nên truyền giá trị đầy đủ không kèm '%'.
 */
class AsPOGetCP2 extends StoredProcedure
{
    public const NAME = 'asPOGetCP2';

    /**
     * Gọi stored procedure asPOGetCP2.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (mảng các đối tượng stdClass)
     *               Call stored procedure asPOGetCP2
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
     * Call stored procedure asPOGetCP2 with named parameters.
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
