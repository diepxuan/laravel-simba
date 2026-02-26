<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 09:48:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSADelDmSanPham.
 *
 * Stored procedure: asSADelDmSanPham
 * Mục đích: Xóa danh mục sản phẩm và công đoạn.
 * Procedure xóa một sản phẩm khỏi danh mục sản phẩm, đồng thời xóa tất cả các công đoạn thuộc sản phẩm đó.
 * Thực hiện hai lệnh DELETE: đầu tiên xóa từ bảng SaDmCongDoan (công đoạn), sau đó xóa từ bảng SaDmSanPham (sản phẩm).
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSADelDmSanPham::call([
 *     'pMa_cty' => '001',
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
 * - Procedure thực hiện hai DELETE liên tiếp. Nếu xóa công đoạn thành công nhưng xóa sản phẩm thất bại (do ràng buộc khóa ngoại), @pRet sẽ là mã lỗi SQL của lệnh DELETE thứ hai.
 * - Nếu không có bản ghi nào khớp trong cả hai bảng, DELETE không ảnh hưởng đến dòng nào, @pRet vẫn là 0 (không có lỗi SQL).
 * - Cần đảm bảo rằng không có ràng buộc khóa ngoại khác ngăn xóa (ví dụ: bảng SaDonGiaSP tham chiếu đến mã sản phẩm). Nếu có, @pRet sẽ là mã lỗi SQL.
 * - Người dùng cần có quyền DELETE trên cả hai bảng SaDmCongDoan và SaDmSanPham.
 */
class AsSADelDmSanPham
{
    /**
     * Gọi stored procedure asSADelDmSanPham.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSADelDmSanPham', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
            'pRet'        => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSADelDmSanPham with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_sanpham = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pMa_sanpham' => $Ma_sanpham,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
