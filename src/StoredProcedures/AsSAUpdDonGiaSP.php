<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 07:02:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAUpdDonGiaSP.
 *
 * Stored procedure: asSAUpdDonGiaSP
 * Mục đích: Sửa đơn giá sản phẩm.
 * Procedure cập nhật đơn giá của một sản phẩm trong một kỳ (tháng/năm) cụ thể.
 * Cập nhật trường đơn giá, người sửa và ngày sửa.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (int, bắt buộc): Tháng của đơn giá (1-12).
 * - @pNam (int, bắt buộc): Năm của đơn giá.
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pDon_gia (decimal, bắt buộc): Đơn giá mới. Kiểu decimal(19,4).
 * - @pLUser (string, bắt buộc): Tên người dùng thực hiện sửa (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAUpdDonGiaSP::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_sanpham' => 'SP001',
 *     'pDon_gia' => 150000.5,
 *     'pLUser' => 'admin',
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
 * - Procedure chỉ cập nhật các trường Don_gia, Luser, Ldate của bảng SaDonGiaSP.
 * - Điều kiện update dựa trên bốn khóa: Ma_cty, Thang, Nam, Ma_sanpham.
 * - Ngày sửa (Ldate) được tự động cập nhật bằng GETDATE().
 * - Nếu không có bản ghi nào khớp điều kiện, procedure không báo lỗi nhưng @pRet sẽ là 0 (vì không có lỗi SQL). Cần kiểm tra số dòng bị ảnh hưởng thông qua kết nối database.
 * - Cần đảm bảo bản ghi đã tồn tại trước khi sửa (nếu không, không có hành động gì). Có thể sử dụng procedure asSAInsDonGiaSP để thêm mới.
 */
class AsSAUpdDonGiaSP
{
    /**
     * Gọi stored procedure asSAUpdDonGiaSP.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDonGiaSP', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pThang'      => $params['pThang'] ?? null,
            'pNam'        => $params['pNam'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
            'pDon_gia'    => $params['pDon_gia'] ?? null,
            'pLUser'      => $params['pLUser'] ?? null,
            'pRet'        => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSAUpdDonGiaSP with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Thang = null, ?int $Nam = null, ?string $Ma_sanpham = null, ?float $Don_gia = null, ?string $LUser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pThang'      => $Thang,
            'pNam'        => $Nam,
            'pMa_sanpham' => $Ma_sanpham,
            'pDon_gia'    => $Don_gia,
            'pLUser'      => $LUser,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
