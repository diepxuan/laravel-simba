<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:15:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCADelLaiKU.
 *
 * Stored procedure: asCADelLaiKU
 * Mục đích: Xóa bản ghi lãi khế ước (CaLaiKu) theo mã công ty, tháng, năm và mã khế ước (có thể dùng pattern).
 * Procedure thực hiện xóa các bản ghi trong bảng CaLaiKu thỏa mãn điều kiện mã công ty, tháng, năm và mã khế ước bắt đầu bằng chuỗi cung cấp.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pThang (int): Tháng (1-12). Bắt buộc.
 * - @pNam (int): Năm. Bắt buộc.
 * - @pMa_ku (nvarchar(20)): Mã khế ước. Nếu chuỗi không rỗng, sẽ xóa các bản ghi có mã khế ước bắt đầu bằng chuỗi này (dùng LIKE). Nếu chuỗi rỗng, xóa tất cả bản ghi của tháng/năm.
 * - @pRet (int, OUTPUT): Tham số đầu ra chứa mã lỗi (@@error).
 *   - 0: Thành công.
 *   - Khác 0: Mã lỗi SQL Server.
 *
 * Giá trị trả về:
 * - Procedure không trả về result set.
 * - Kết quả được trả về qua output parameter @pRet.
 * - Để lấy giá trị @pRet, cần đọc từ result của ProcedureCaller (có SELECT @pRet).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelLaiKU::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_ku' => 'KU',
 * ]);
 *
 * // Lấy giá trị output parameter
 * $ret = $result->first()->pRet ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Có lỗi xảy ra, $ret chứa mã lỗi
 * }
 * ```
 *
 * Lưu ý:
 * - Bảng CaLaiKu lưu trữ lãi khế ước đã tính từ procedure asCACalLaiKU.
 * - Nếu @pMa_ku là chuỗi rỗng, điều kiện LIKE '%' sẽ xóa tất cả bản ghi của tháng/năm đó.
 * - Procedure này thường được gọi khi muốn hủy tính lãi đã thực hiện trước đó.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCADelLaiKU
{
    /**
     * Gọi stored procedure asCADelLaiKU.
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số.
     *                      Các parameters có thể thiếu, sẽ dùng giá trị default.
     *
     * @return Collection kết quả từ procedure (chứa output parameter pRet)
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCADelLaiKU', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang'  => $paramObj->pThang ?? null,
            'pNam'    => $paramObj->pNam ?? null,
            'pMa_ku'  => $paramObj->pMa_ku ?? null,
            'pRet'    => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCADelLaiKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty Mã công ty
     * @param null|int    $Thang  Tháng
     * @param null|int    $Nam    Năm
     * @param null|string $Ma_ku  Mã khế ước
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?int $Thang = null,
        ?int $Nam = null,
        ?string $Ma_ku = null,
    ): Collection {
        return self::call([
            'pMa_cty' => $Ma_cty,
            'pThang'  => $Thang,
            'pNam'    => $Nam,
            'pMa_ku'  => $Ma_ku,
        ]);
    }
}
