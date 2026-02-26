<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 10:17:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAInsDonGiaSP.
 *
 * Stored procedure: asSAInsDonGiaSP
 * Mục đích: Thêm mới đơn giá sản phẩm.
 * Procedure thêm một bản ghi đơn giá sản phẩm cho một sản phẩm trong một kỳ (tháng/năm) cụ thể.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pThang (int, bắt buộc): Tháng của đơn giá (1-12).
 * - @pNam (int, bắt buộc): Năm của đơn giá.
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pDon_gia (decimal, bắt buộc): Đơn giá. Kiểu decimal(19,4).
 * - @pCUser (string, bắt buộc): Tên người dùng thực hiện thêm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAInsDonGiaSP::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_sanpham' => 'SP001',
 *     'pDon_gia' => 150000.5,
 *     'pCUser' => 'admin',
 * ]);
 * // Lấy giá trị output parameter
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure thực hiện INSERT vào bảng SaDonGiaSP với các giá trị được cung cấp.
 * - Các trường Cdate và Ldate được gán bằng GETDATE() (thời điểm hiện tại).
 * - Trường Luser được gán bằng @pCUser (người tạo cũng là người sửa lần cuối).
 * - Nếu bản ghi đã tồn tại (trùng khóa chính Ma_cty, Thang, Nam, Ma_sanpham), sẽ xảy ra lỗi violation và @pRet sẽ là mã lỗi SQL.
 * - Cần đảm bảo mã sản phẩm tồn tại trong danh mục sản phẩm (nếu có ràng buộc khóa ngoại).
 */
class AsSAInsDonGiaSP
{
    /**
     * Gọi stored procedure asSAInsDonGiaSP.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDonGiaSP', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDonGiaSP with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?int $Thang = null, ?int $Nam = null, ?string $Ma_sanpham = null, ?float $Don_gia = null, ?string $CUser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pThang'      => $Thang,
            'pNam'        => $Nam,
            'pMa_sanpham' => $Ma_sanpham,
            'pDon_gia'    => $Don_gia,
            'pCUser'      => $CUser,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
