<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 10:16:27
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAInsDmSanPham.
 *
 * Stored procedure: asSAInsDmSanPham
 * Mục đích: Thêm danh mục sản phẩm.
 * Procedure thêm một sản phẩm mới vào danh mục sản phẩm.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_sanpham (string, bắt buộc): Mã sản phẩm (20 ký tự).
 * - @pTen_sp (string, bắt buộc): Tên sản phẩm (200 ký tự).
 * - @pDvt (string, bắt buộc): Đơn vị tính (50 ký tự).
 * - @pCUser (string, bắt buộc): Tên người dùng thực hiện thêm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAInsDmSanPham::call([
 *     'pMa_cty' => '001',
 *     'pMa_sanpham' => 'SP001',
 *     'pTen_sp' => 'Áo thun cổ tròn',
 *     'pDvt' => 'Cái',
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
 * - Procedure thực hiện INSERT vào bảng SaDmSanPham với các giá trị được cung cấp.
 * - Các trường Cdate và Ldate được gán bằng GETDATE() (thời điểm hiện tại).
 * - Trường Luser được gán bằng @pCUser (người tạo cũng là người sửa lần cuối).
 * - Trường Ksd không được cung cấp, có thể mặc định là 1 (đang sử dụng) nếu cấu trúc bảng cho phép.
 * - Nếu bản ghi đã tồn tại (trùng khóa chính Ma_cty, Ma_sanpham), sẽ xảy ra lỗi violation và @pRet sẽ là mã lỗi SQL.
 * - Cần đảm bảo mã sản phẩm là duy nhất trong công ty.
 */
class AsSAInsDmSanPham
{
    /**
     * Gọi stored procedure asSAInsDmSanPham.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDmSanPham', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDmSanPham with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_sanpham = null, ?string $Ten_sp = null, ?string $Dvt = null, ?string $CUser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pMa_sanpham' => $Ma_sanpham,
            'pTen_sp'     => $Ten_sp,
            'pDvt'        => $Dvt,
            'pCUser'      => $CUser,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
