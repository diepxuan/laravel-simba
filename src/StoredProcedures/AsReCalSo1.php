<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:09:31
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsReCalSo1.
 *
 * Stored procedure: asReCalSo1
 * Mục đích: Tính và cập nhật lại số liệu cho một đơn hàng bán (sales order).
 * Procedure thực hiện ba công việc chính:
 * 1. Cập nhật số lượng hóa đơn (sl_hd, sl_hd_qd) cho từng dòng chi tiết đơn hàng (soct1)
 *    dựa trên tổng hợp dữ liệu từ bảng chi tiết hóa đơn (soct3) với điều kiện stt_rec_px = '' (chưa có phiếu xuất).
 * 2. Cập nhật số lượng đã xuất (sl_xuat, sl_xuat_qd) cho từng dòng chi tiết đơn hàng (soct1)
 *    dựa trên tổng hợp dữ liệu từ:
 *    - Bảng chi tiết phiếu xuất (soct2)
 *    - Bảng chi tiết hóa đơn (soct3) kết hợp với header hóa đơn (soph3) khi có điều kiện:
 *      + soph3.ma_gd = '1' (Hóa đơn kiêm phiếu xuất)
 *      + stt_rec_px = '' (chưa có phiếu xuất?)
 * 3. Kiểm tra và cập nhật trạng thái đơn hàng (soPh1, soCt):
 *    - Nếu tất cả các dòng chi tiết có số lượng (so_luong) <= số lượng đã xuất (sl_xuat)
 *      thì cập nhật trạng thái thành '5' (hoàn thành).
 *    - Ngược lại, cập nhật trạng thái thành '2' (thực hiện).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec_dh (string, bắt buộc): Số thứ tự bản ghi của đơn hàng bán (stt_rec_dh).
 *
 * Giá trị trả về:
 * - Không trả về resultset nào. Procedure thực hiện cập nhật trực tiếp trên các bảng soct1, soPh1, soCt.
 *
 * Ví dụ gọi:
 * ```php
 * AsReCalSo1::call([
 *     'pMa_cty' => '901',
 *     'pStt_rec_dh' => 'DH001',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Procedure sử dụng các bảng: soct1 (chi tiết đơn hàng bán), soct2 (chi tiết phiếu xuất), soct3 (chi tiết hóa đơn), soPh1 (header đơn hàng), soCt (bảng tổng hợp?), soph3 (header hóa đơn).
 * - Trạng thái:
 *   + '2': Đang thực hiện (thực hiện)
 *   + '5': Hoàn thành (hoan thanh)
 * - Cột sl_hd (số lượng hóa đơn) và sl_hd_qd (số lượng quy đổi hóa đơn) được tính từ tổng so_luong, so_luong_qd trong soct3 với điều kiện stt_rec_px = ''.
 * - Cột sl_xuat (số lượng đã xuất) và sl_xuat_qd (số lượng quy đổi đã xuất) được tính từ tổng so_luong, so_luong_qd trong soct2 và soct3 (với điều kiện đặc biệt).
 * - Điều kiện nhóm: stt_rec0_dh, ma_vt.
 * - Procedure này thuộc nhóm Recalculate (asReCal*), liên quan đến module Bán hàng (SO).
 */
class AsReCalSo1
{
    /**
     * Gọi stored procedure asReCalSo1.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (không có resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asReCalSo1', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pStt_rec_dh' => $params['pStt_rec_dh'] ?? null,
            'pstt_rec_dh' => $params['pstt_rec_dh'] ?? null,
            'pma_cty'     => $params['pma_cty'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asReCalSo1 with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec_dh = null, mixed $stt_rec_dh = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pStt_rec_dh' => $Stt_rec_dh,
            'pstt_rec_dh' => $stt_rec_dh,
            'pma_cty'     => $ma_cty,
        ];

        return self::call($params);
    }
}
