<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:15:21
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCADelPostLaiKU.
 *
 * Stored procedure: asCADelPostLaiKU
 * Mục đích: Xóa bản ghi post lãi khế ước (CaPostLaiKU) theo mã công ty, tháng, năm, mã chứng từ và mã khế ước.
 * Procedure thực hiện xóa các bản ghi trong bảng CaPostLaiKu thỏa mãn điều kiện đã cung cấp.
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pThang (int): Tháng (1-12). Bắt buộc.
 * - @pNam (int): Năm. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Bắt buộc.
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
 * $result = AsCADelPostLaiKU::call([
 *     'pMa_cty' => '001',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pMa_ct' => 'CA4',
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
 * - Bảng CaPostLaiKu lưu trữ các bản ghi post lãi khế ước sang GL.
 * - Procedure này thường được gọi khi muốn hủy post lãi đã thực hiện trước đó.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCADelPostLaiKU
{
    /**
     * Gọi stored procedure asCADelPostLaiKU.
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

        return ProcedureCaller::call('asCADelPostLaiKU', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang'  => $paramObj->pThang ?? null,
            'pNam'    => $paramObj->pNam ?? null,
            'pMa_ct'  => $paramObj->pMa_ct ?? null,
            'pMa_ku'  => $paramObj->pMa_ku ?? null,
            'pRet'    => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCADelPostLaiKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty Mã công ty
     * @param null|int    $Thang  Tháng
     * @param null|int    $Nam    Năm
     * @param null|string $Ma_ct  Mã chứng từ
     * @param null|string $Ma_ku  Mã khế ước
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?int $Thang = null,
        ?int $Nam = null,
        ?string $Ma_ct = null,
        ?string $Ma_ku = null,
    ): Collection {
        return self::call([
            'pMa_cty' => $Ma_cty,
            'pThang'  => $Thang,
            'pNam'    => $Nam,
            'pMa_ct'  => $Ma_ct,
            'pMa_ku'  => $Ma_ku,
        ]);
    }
}
