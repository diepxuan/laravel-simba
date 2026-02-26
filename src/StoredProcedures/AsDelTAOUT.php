<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 23:37:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelTAOUT.
 *
 * Stored procedure: asDelTAOUT
 * Mục đích: Xóa một bản ghi xuất kho (TAOUT) dựa trên mã công ty và số chứng từ.
 * Procedure thực hiện DELETE từ bảng TAOUT với điều kiện khớp Ma_cty và Stt_rec.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (nvarchar(3)).
 * - @pStt_rec (string, bắt buộc): Số chứng từ (stt_rec) (nvarchar(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 *
 * Logic chi tiết:
 * - DELETE FROM TAOUT WHERE Ma_cty = @pMa_cty AND Stt_rec = @pStt_rec
 * - SET @pRet = @@error
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsDelTAOUT::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'OUT202500001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, có lỗi SQL
 * }
 * ```
 *
 * Lưu ý:
 * - Tham số @pMa_cty và @pStt_rec bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột Ma_cty và Stt_rec.
 * - Bảng TAOUT lưu thông tin xuất kho (có thể là phiếu xuất kho, xuất vật tư...).
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelTAOUT
{
    /**
     * Gọi stored procedure asDelTAOUT.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asDelTAOUT', [
            'pMa_cty'  => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec' => $params['pStt_rec'] ?? null,
        ], $connection);
    }
}
