<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 09:50:26
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSADelDonGiaSP.
 *
 * Stored procedure: asSADelDonGiaSP
 * Mục đích: Xóa đơn giá sản phẩm.
 * Procedure xóa một bản ghi đơn giá sản phẩm theo khóa: mã công ty, tháng, năm, mã sản phẩm.
 * Thường được gọi khi hủy bỏ hoặc điều chỉnh đơn giá.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (int, bắt buộc): Tháng của đơn giá (1-12).
 * - @pNam (int, bắt buộc): Năm của đơn giá.
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSADelDonGiaSP::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_sanpham' => 'SP001',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure thực hiện DELETE không có điều kiện phụ, chỉ xóa bản ghi khớp đầy đủ bốn khóa.
 * - Nếu không có bản ghi nào khớp, DELETE không ảnh hưởng đến dòng nào, @pRet vẫn là 0 (không có lỗi SQL).
 * - Cần đảm bảo rằng không có ràng buộc khóa ngoại ngăn xóa (nếu có, @pRet sẽ là mã lỗi SQL).
 * - Người dùng cần có quyền DELETE trên bảng SaDonGiaSP.
 */
class AsSADelDonGiaSP
{
    /**
     * Gọi stored procedure asSADelDonGiaSP.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSADelDonGiaSP', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pThang'      => $params['pThang'] ?? null,
            'pNam'        => $params['pNam'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
            'pRet'        => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSADelDonGiaSP with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Thang = null, ?int $Nam = null, ?string $Ma_sanpham = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pThang'      => $Thang,
            'pNam'        => $Nam,
            'pMa_sanpham' => $Ma_sanpham,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
