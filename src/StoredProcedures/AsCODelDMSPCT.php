<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 15:41:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCODelDMSPCT.
 *
 * Stored procedure: asCODelDMSPCT
 * Mục đích: Xóa danh mục sản phẩm công trình (CODMSPCT) sau khi kiểm tra ràng buộc.
 * Procedure thực hiện kiểm tra xem mã sản phẩm công trình có được sử dụng ở các bảng khác không (thông qua hàm afChkExistsCodeDict).
 * Nếu không có ràng buộc, tiến hành xóa bản ghi.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự). Là khóa chính cần xóa.
 * - @pRet (int, output): Kết quả trả về. 0: được xóa, <>0: không xóa được (có ràng buộc hoặc lỗi).
 *
 * Giá trị mặc định:
 * - Không có.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu xóa thành công (không có lỗi).
 * - @pRet = 50004 nếu mã sản phẩm đang được sử dụng (không thể xóa).
 * - @pRet = mã lỗi SQL nếu có lỗi khác (ví dụ lỗi khi xóa).
 *
 * Logic chi tiết:
 * 1. Gọi hàm dbo.afChkExistsCodeDict để kiểm tra mã sản phẩm có tồn tại trong các bảng con không.
 *    - Nếu hàm trả về <>0, tức là mã đang được sử dụng, set @pRet = 50004 và RETURN.
 * 2. Xóa bản ghi trong CODMSPCT với điều kiện Ma_cty và Ma_spct.
 * 3. Gán @pRet = @@error.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCODelDMSPCT::call([
 *     'pMa_cty' => '001',
 *     'pMa_spct' => 'SP001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } elseif ($ret === 50004) {
 *     // Mã sản phẩm đang được sử dụng, không thể xóa
 * } else {
 *     // Lỗi khác
 * }
 * ```
 *
 * Lưu ý:
 * - Hàm afChkExistsCodeDict có thể kiểm tra ràng buộc toàn diện, đảm bảo tính toàn vẹn dữ liệu.
 * - Nếu mã sản phẩm không tồn tại, DELETE sẽ không ảnh hưởng hàng nào và @pRet = 0 (thành công).
 * - Cần đảm bảo mã công ty và mã sản phẩm chính xác.
 */
class AsCODelDMSPCT
{
    /**
     * Gọi stored procedure asCODelDMSPCT.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCODelDMSPCT', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
        ], $connection);
    }
}
