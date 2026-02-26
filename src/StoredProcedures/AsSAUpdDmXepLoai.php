<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 10:19:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAUpdDmXepLoai.
 *
 * Stored procedure: asSAUpdDmXepLoai
 * Mục đích: Sửa danh mục xếp loại.
 * Procedure cập nhật thông tin của một xếp loại trong danh mục xếp loại.
 * Các thông tin có thể sửa: hệ số, trạng thái sử dụng, người sửa, ngày sửa.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_xeploai (string, bắt buộc): Mã xếp loại (1 ký tự).
 * - @pHe_so (decimal, bắt buộc): Hệ số (decimal 19,4).
 * - @pKsd (bool, bắt buộc): Trạng thái sử dụng (0 = ngừng sử dụng, 1 = đang sử dụng).
 * - @pLUser (string, bắt buộc): Tên người dùng thực hiện sửa (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAUpdDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'A',
 *     'pHe_so' => 2.5,
 *     'pKsd' => true,
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
 * - Procedure chỉ cập nhật các trường He_so, Ksd, Luser, Ldate của bảng sadmxeploai.
 * - Điều kiện update dựa trên hai khóa: Ma_cty, Ma_xeploai.
 * - Ngày sửa (Ldate) được tự động cập nhật bằng GETDATE().
 * - Nếu không có bản ghi nào khớp điều kiện, procedure không báo lỗi nhưng @pRet sẽ là 0 (vì không có lỗi SQL). Cần kiểm tra số dòng bị ảnh hưởng thông qua kết nối database.
 * - Cần đảm bảo bản ghi đã tồn tại trước khi sửa (nếu không, không có hành động gì). Có thể sử dụng procedure asSAInsDmXepLoai để thêm mới.
 */
class AsSAUpdDmXepLoai
{
    /**
     * Gọi stored procedure asSAUpdDmXepLoai.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAUpdDmXepLoai', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pMa_xeploai' => $params['pMa_xeploai'] ?? null,
            'pHe_so'      => $params['pHe_so'] ?? null,
            'pKsd'        => $params['pKsd'] ?? null,
            'pLUser'      => $params['pLUser'] ?? null,
            'pRet'        => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSAUpdDmXepLoai with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_xeploai = null, ?float $He_so = null, ?bool $Ksd = null, ?string $LUser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pMa_xeploai' => $Ma_xeploai,
            'pHe_so'      => $He_so,
            'pKsd'        => $Ksd,
            'pLUser'      => $LUser,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
