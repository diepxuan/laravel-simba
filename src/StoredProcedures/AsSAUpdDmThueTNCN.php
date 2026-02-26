<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 10:18:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAUpdDmThueTNCN.
 *
 * Stored procedure: asSAUpdDmThueTNCN
 * Mục đích: Sửa thông tin danh mục thuế thu nhập cá nhân.
 * Procedure cập nhật thông tin một bậc thuế thu nhập cá nhân, bao gồm định mức từ, định mức đến, thuế suất, thuế tối đa.
 * Sau khi cập nhật bậc thuế hiện tại, nếu bậc thuế không phải là bậc cao nhất, procedure tự động cập nhật định mức từ của bậc tiếp theo bằng định mức đến của bậc hiện tại (để đảm bảo liên tục).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pBac_thue (string, bắt buộc): Bậc thuế (20 ký tự, lưu dạng chuỗi nhưng có thể so sánh số). Thường là số nguyên.
 * - @pDinh_muc_tu (decimal, bắt buộc): Định mức từ (số tiền bắt đầu của bậc thuế). Kiểu decimal(19,0).
 * - @pDinh_muc_den (decimal, bắt buộc): Định mức đến (số tiền kết thúc của bậc thuế). Kiểu decimal(19,0).
 * - @pThue_suat (decimal, bắt buộc): Thuế suất (tỷ lệ phần trăm). Kiểu decimal(19,4).
 * - @pThue_toi_da (decimal, bắt buộc): Thuế tối đa (số tiền thuế tối đa của bậc). Kiểu decimal(19,4).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAUpdDmThueTNCN::call([
 *     'pMa_cty' => '001',
 *     'pBac_thue' => '3',
 *     'pDinh_muc_tu' => 10000000,
 *     'pDinh_muc_den' => 20000000,
 *     'pThue_suat' => 0.15,
 *     'pThue_toi_da' => 1500000,
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure thực hiện hai cập nhật:
 *   1. Cập nhật thông tin bậc thuế được chỉ định.
 *   2. Nếu bậc thuế không phải là bậc cao nhất (so sánh số), cập nhật định mức từ của bậc tiếp theo bằng định mức đến của bậc hiện tại.
 * - Điều kiện update bậc tiếp theo sử dụng CAST(@pBac_thue AS INT) + 1, nghĩa là bậc thuế phải là số nguyên.
 * - Nếu bậc thuế không phải số nguyên, có thể gây lỗi chuyển đổi.
 * - Cần đảm bảo rằng bậc tiếp theo tồn tại trong bảng, nếu không không có hành động gì.
 * - Người dùng cần có quyền update trên bảng SaDmThueTNCN.
 */
class AsSAUpdDmThueTNCN
{
    /**
     * Gọi stored procedure asSAUpdDmThueTNCN.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDmThueTNCN', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pBac_thue'     => $params['pBac_thue'] ?? null,
            'pDinh_muc_tu'  => $params['pDinh_muc_tu'] ?? null,
            'pDinh_muc_den' => $params['pDinh_muc_den'] ?? null,
            'pThue_suat'    => $params['pThue_suat'] ?? null,
            'pThue_toi_da'  => $params['pThue_toi_da'] ?? null,
            'pRet'          => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSAUpdDmThueTNCN with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Bac_thue = null, ?float $Dinh_muc_tu = null, ?float $Dinh_muc_den = null, ?float $Thue_suat = null, ?float $Thue_toi_da = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'       => $Ma_cty,
            'pBac_thue'     => $Bac_thue,
            'pDinh_muc_tu'  => $Dinh_muc_tu,
            'pDinh_muc_den' => $Dinh_muc_den,
            'pThue_suat'    => $Thue_suat,
            'pThue_toi_da'  => $Thue_toi_da,
            'pRet'          => $Ret,
        ];

        return self::call($params);
    }
}
