<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:15:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCADelDMKU.
 *
 * Stored procedure: asCADelDMKU
 * Mục đích: Xóa danh mục khế ước (CADMKU) theo mã công ty và mã khế ước.
 * Procedure thực hiện kiểm tra tồn tại mã khế ước bằng hàm afChkExistsCodeDict trước khi xóa.
 * Nếu mã tồn tại (có bản ghi liên quan) thì trả về lỗi 50004, ngược lại xóa bản ghi trong bảng CADMKU.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL hoặc 50004).
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_ku (nvarchar(20)): Mã khế ước. Bắt buộc.
 * - @pRet (int, OUTPUT): Tham số đầu ra chứa mã lỗi (@@error).
 *   - 0: Thành công.
 *   - 50004: Mã khế ước tồn tại trong các bản ghi liên quan, không được xóa.
 *   - Khác 0: Mã lỗi SQL Server.
 *
 * Giá trị trả về:
 * - Procedure không trả về result set.
 * - Kết quả được trả về qua output parameter @pRet.
 * - Để lấy giá trị @pRet, cần đọc từ result của ProcedureCaller (có SELECT @pRet).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsCADelDMKU::call([
 *     'pMa_cty' => '001',
 *     'pMa_ku' => 'KU001',
 * ]);
 *
 * // Lấy giá trị output parameter
 * $ret = $result->first()->pRet ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else if ($ret === 50004) {
 *     // Mã khế ước tồn tại trong các bản ghi liên quan, không được xóa
 * } else {
 *     // Có lỗi SQL khác
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure gọi hàm hệ thống afChkExistsCodeDict để kiểm tra ràng buộc khóa ngoại.
 * - Bảng CADMKU lưu trữ danh mục khế ước (loan agreements).
 * - Mã lỗi 50004 là lỗi custom của ứng dụng, chỉ định không thể xóa do tồn tại bản ghi liên quan.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCADelDMKU
{
    /**
     * Gọi stored procedure asCADelDMKU.
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

        return ProcedureCaller::call('asCADelDMKU', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ku'  => $paramObj->pMa_ku ?? null,
            'pRet'    => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCADelDMKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty Mã công ty
     * @param null|string $Ma_ku  Mã khế ước
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ma_ku = null,
    ): Collection {
        return self::call([
            'pMa_cty' => $Ma_cty,
            'pMa_ku'  => $Ma_ku,
        ]);
    }
}
