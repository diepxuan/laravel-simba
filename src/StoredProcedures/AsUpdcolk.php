<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:00:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdcolk.
 *
 * Stored procedure: asUpdcolk
 * Mục đích: Cập nhật số phát sinh (PS) trong bảng colk (có thể là chi tiết công trình).
 * Procedure cập nhật các giá trị Ps_no, Ps_no_nt, Ps_co, Ps_co_nt cho một bản ghi xác định bởi nhiều khóa: công ty, tháng, năm, mã sản phẩm công trình, tài khoản, tài khoản đối ứng.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (NVARCHAR(3)).
 * - @pThang (int, bắt buộc): Tháng (INT).
 * - @pNam (int, bắt buộc): Năm (INT).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (NVARCHAR(20)).
 * - @pTk (string, bắt buộc): Tài khoản (NVARCHAR(20)).
 * - @pTk_du (string, bắt buộc): Tài khoản đối ứng (NVARCHAR(20)).
 * - @pPs_no (decimal, bắt buộc): Phát sinh nợ (DECIMAL).
 * - @pPs_no_nt (decimal, bắt buộc): Phát sinh nợ ngoại tệ (DECIMAL).
 * - @pPs_co (decimal, bắt buộc): Phát sinh có (DECIMAL).
 * - @pPs_co_nt (decimal, bắt buộc): Phát sinh có ngoại tệ (DECIMAL).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - UPDATE bảng colk: cập nhật các cột Ps_no, Ps_no_nt, Ps_co, Ps_co_nt với điều kiện Ma_cty = @pMa_cty AND Thang = @pThang AND Nam = @pNam AND Ma_spct = @pMa_spct AND Tk = @pTk AND Tk_du = @pTk_du.
 * - Cột Tk_du cũng nằm trong điều kiện WHERE nhưng không được cập nhật (có comment trong SET).
 * - Bắt lỗi: SET @pRet = @@error.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdcolk::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 12,
 *     'pNam' => 2025,
 *     'pMa_spct' => 'CT001',
 *     'pTk' => '632',
 *     'pTk_du' => '111',
 *     'pPs_no' => 1000000.00,
 *     'pPs_no_nt' => 0.00,
 *     'pPs_co' => 0.00,
 *     'pPs_co_nt' => 0.00,
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Tham số decimal có thể truyền giá trị số thực (float) hoặc chuỗi số.
 * - Điều kiện WHERE gồm 6 trường, đảm bảo xác định duy nhất một bản ghi trong bảng colk (có thể là bảng chi tiết công trình).
 * - Cột Tk_du được dùng trong điều kiện nhưng không cập nhật (có comment). Có thể Tk_du là khóa phụ.
 * - Bảng colk có thể lưu chi tiết phát sinh theo công trình, sản phẩm, tài khoản, tháng năm.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 */
class AsUpdcolk
{
    /**
     * Gọi stored procedure asUpdcolk.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdcolk', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pThang'    => $params['pThang'] ?? null,
            'pNam'      => $params['pNam'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pTk'       => $params['pTk'] ?? null,
            'pTk_du'    => $params['pTk_du'] ?? null,
            'pPs_no'    => $params['pPs_no'] ?? null,
            'pPs_no_nt' => $params['pPs_no_nt'] ?? null,
            'pPs_co'    => $params['pPs_co'] ?? null,
            'pPs_co_nt' => $params['pPs_co_nt'] ?? null,
            'pRet'      => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdcolk with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Thang = null, ?int $Nam = null, ?string $Ma_spct = null, ?string $Tk = null, ?string $Tk_du = null, ?float $Ps_no = null, ?float $Ps_no_nt = null, ?float $Ps_co = null, ?float $Ps_co_nt = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'   => $Ma_cty,
            'pThang'    => $Thang,
            'pNam'      => $Nam,
            'pMa_spct'  => $Ma_spct,
            'pTk'       => $Tk,
            'pTk_du'    => $Tk_du,
            'pPs_no'    => $Ps_no,
            'pPs_no_nt' => $Ps_no_nt,
            'pPs_co'    => $Ps_co,
            'pPs_co_nt' => $Ps_co_nt,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
