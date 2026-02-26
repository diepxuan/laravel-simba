<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 09:49:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsSADelDmXepLoai.
 *
 * Stored procedure: asSADelDmXepLoai
 * Mục đích: Xóa danh mục xếp loại.
 * Procedure xóa một xếp loại khỏi danh mục xếp loại dựa trên mã công ty và mã xếp loại.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_xeploai (string, bắt buộc): Mã xếp loại (1 ký tự).
 * - @pRet (int, output): Kết quả trả về. 0 thành công, khác 0 lỗi (thường là mã lỗi SQL).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsSADelDmXepLoai::call([
 *     'pMa_cty' => '001',
 *     'pMa_xeploai' => 'C',
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
 * - Procedure thực hiện DELETE trên bảng `sadmxeploai`.
 * - Nếu không có bản ghi nào khớp điều kiện, DELETE không ảnh hưởng đến dòng nào, @pRet vẫn là 0 (không có lỗi SQL).
 * - Cần đảm bảo rằng không có ràng buộc khóa ngoại ngăn xóa (nếu có, @pRet sẽ là mã lỗi SQL).
 * - Người dùng cần có quyền DELETE trên bảng sadmxeploai.
 */
class AsSADelDmXepLoai
{
    /**
     * Gọi stored procedure asSADelDmXepLoai.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSADelDmXepLoai', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pMa_xeploai' => $params['pMa_xeploai'] ?? null,
            'pRet'        => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asSADelDmXepLoai with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Ma_xeploai = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'     => $Ma_cty,
            'pMa_xeploai' => $Ma_xeploai,
            'pRet'        => $Ret,
        ];

        return self::call($params);
    }
}
