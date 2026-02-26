<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 10:16:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSAInsDmXepLoai.
 *
 * Stored procedure: asSAInsDmXepLoai
 * Mục đích: Thêm mới danh mục xếp loại.
 * Procedure thêm một xếp loại mới vào danh mục xếp loại.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_xeploai (string, bắt buộc): Mã xếp loại (1 ký tự).
 * - @pHe_so (decimal, bắt buộc): Hệ số (decimal 19,4).
 * - @pCUser (string, bắt buộc): Tên người dùng thực hiện thêm (20 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSAInsDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'A',
 *     'pHe_so' => 2.5,
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
 * - Procedure thực hiện INSERT vào bảng sadmxeploai với các giá trị được cung cấp.
 * - Các trường cdate và ldate được gán bằng GETDATE() (thời điểm hiện tại).
 * - Trường luser được gán bằng @pCUser (người tạo cũng là người sửa lần cuối).
 * - Trường ksd không được cung cấp, có thể mặc định là 1 (đang sử dụng) nếu cấu trúc bảng cho phép.
 * - Nếu bản ghi đã tồn tại (trùng khóa chính Ma_cty, Ma_xeploai), sẽ xảy ra lỗi violation và @pRet sẽ là mã lỗi SQL.
 * - Cần đảm bảo mã xếp loại là duy nhất trong công ty.
 */
class AsSAInsDmXepLoai
{
    /**
     * Gọi stored procedure asSAInsDmXepLoai.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAInsDmXepLoai', $params, $connection);
    }

    /**
     * Call stored procedure asSAInsDmXepLoai with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_xeploai = null, ?float $He_so = null, ?string $CUser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pMa_xeploai' => $Ma_xeploai,
            'pHe_so'      => $He_so,
            'pCUser'      => $CUser,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
