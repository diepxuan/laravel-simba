<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:15:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCADelCDKU.
 *
 * Stored procedure: asCADelCDKU
 * Mục đích: Xóa chi tiết khế ước (cacdku) theo mã công ty, năm, mã khế ước.
 * Procedure thực hiện xóa các bản ghi trong bảng cacdku (chi tiết khế ước) thỏa mãn điều kiện.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNam (int): Năm của khế ước. Bắt buộc.
 * - @pMa_ku (nvarchar(20)): Mã khế ước. Bắt buộc.
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
 * $result = AsCADelCDKU::call([
 *     'pMa_cty' => '001',
 *     'pNam' => 2025,
 *     'pMa_ku' => 'KU001',
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
 * - Procedure sử dụng TRY...CATCH để bắt lỗi SQL.
 * - Xóa tất cả chi tiết khế ước của một năm và mã khế ước cụ thể.
 * - Bảng cacdku lưu trữ chi tiết khế ước (có thể bao gồm các khoản vay, trả nợ).
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCADelCDKU
{
    /**
     * Gọi stored procedure asCADelCDKU.
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

        return ProcedureCaller::call('asCADelCDKU', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam'    => $paramObj->pNam ?? null,
            'pMa_ku'  => $paramObj->pMa_ku ?? null,
            'pRet'    => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCADelCDKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty Mã công ty
     * @param null|int    $Nam    Năm
     * @param null|string $Ma_ku  Mã khế ước
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?int $Nam = null,
        ?string $Ma_ku = null,
    ): Collection {
        return self::call([
            'pMa_cty' => $Ma_cty,
            'pNam'    => $Nam,
            'pMa_ku'  => $Ma_ku,
        ]);
    }
}
