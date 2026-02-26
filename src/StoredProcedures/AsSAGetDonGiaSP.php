<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 09:53:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAGetDonGiaSP.
 *
 * Stored procedure: asSAGetDonGiaSP
 * Mục đích: Lấy danh sách đơn giá sản phẩm.
 * Procedure truy vấn danh sách đơn giá sản phẩm của một công ty trong một kỳ (tháng/năm) cụ thể, có thể lọc theo mã sản phẩm.
 * Kết hợp với bảng danh mục sản phẩm để lấy tên sản phẩm và đơn vị tính.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (int, bắt buộc): Tháng của đơn giá (1-12).
 * - @pNam (int, bắt buộc): Năm của đơn giá.
 * - @pMa_sanpham (string, tùy chọn, mặc định ''): Mã sản phẩm (20 ký tự). Nếu rỗng, lấy tất cả sản phẩm.
 *
 * Giá trị trả về:
 * - Procedure trả về một resultset chứa các cột:
 *   + Ma_cty: Mã công ty
 *   + Thang: Tháng (truyền vào)
 *   + Nam: Năm (truyền vào)
 *   + Ma_sanpham: Mã sản phẩm
 *   + Ten_sp: Tên sản phẩm (lấy từ bảng sadmsanpham)
 *   + Dvt: Đơn vị tính
 *   + Don_gia: Đơn giá
 *   + Cuser: Người tạo
 *   + Cdate: Ngày tạo
 *   + Luser: Người sửa cuối
 *   + Ldate: Ngày sửa cuối
 *
 * Ví dụ gọi:
 * ```php
 * // Lấy tất cả đơn giá sản phẩm của công ty '001' tháng 12 năm 2012
 * $result = AsSAGetDonGiaSP::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 12,
 *     'pNam' => 2012,
 * ]);
 *
 * // Lấy đơn giá của sản phẩm 'SP001' trong tháng 2 năm 2025
 * $result = AsSAGetDonGiaSP::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_sanpham' => 'SP001',
 * ]);
 * ```
 *
 * Lưu ý:
 * - Điều kiện WHERE sử dụng LIKE với @pMa_sanpham + '%'. Nếu @pMa_sanpham là rỗng, điều kiện trở thành LIKE '%' (lấy tất cả).
 * - Join với bảng sadmsanpham trên điều kiện b.Ma_cty = @pMa_cty AND a.Ma_sanpham = b.Ma_sanpham.
 * - Các cột Thang và Nam trong kết quả là giá trị truyền vào, không phải lấy từ bảng sadongiasp (vì bảng có thể không có dữ liệu cho tháng/năm đó). Tuy nhiên, điều kiện WHERE không lọc theo Thang và Nam, chỉ lọc theo Ma_cty và Ma_sanpham. Có thể cần xem xét logic này.
 * - Nếu không có đơn giá cho sản phẩm nào, resultset trả về rỗng.
 */
class AsSAGetDonGiaSP
{
    /**
     * Gọi stored procedure asSAGetDonGiaSP.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể là resultset)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAGetDonGiaSP', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pThang'      => $params['pThang'] ?? null,
            'pNam'        => $params['pNam'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSAGetDonGiaSP with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Thang = null, ?int $Nam = null, ?string $Ma_sanpham = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pThang'      => $Thang,
            'pNam'        => $Nam,
            'pMa_sanpham' => $Ma_sanpham,
        ];

        return self::call($params);
    }
}
