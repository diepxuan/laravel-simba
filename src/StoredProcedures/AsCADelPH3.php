<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:15:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCADelPH3.
 *
 * Stored procedure: asCADelPH3
 * Mục đích: Xóa phiếu thu/chi (bảng CAPH3 - Cash Phiếu 3) theo mã công ty và số tham chiếu.
 * Procedure thực hiện xóa bản ghi khỏi bảng CAPH3 dựa trên số tham chiếu (stt_rec).
 * Trả về kết quả qua output parameter @pRet: 0 nếu xóa thành công, khác 0 nếu có lỗi (mã lỗi SQL).
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu (stt_rec) của phiếu cần xóa. Bắt buộc.
 * - @pLUser (nvarchar(20)): Người dùng thực hiện xóa. Bắt buộc.
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
 * $result = AsCADelPH3::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001wCA40000000676668',
 *     'pLUser' => 'DUCTN',
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
 * - Procedure chỉ thực hiện xóa dựa trên stt_rec.
 * - Cần đảm bảo stt_rec tồn tại trước khi xóa.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 *
 * @see AsCAGetPH3::call() - Kiểm tra phiếu tồn tại trước khi xóa
 */
class AsCADelPH3
{
    /**
     * Gọi stored procedure asCADelPH3.
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

        return ProcedureCaller::call('asCADelPH3', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pLUser'   => $paramObj->pLUser ?? null,
            'pRet'     => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCADelPH3 with named parameters (helper method).
     *
     * @param null|string $Ma_cty  Mã công ty
     * @param null|string $Stt_rec Số tham chiếu
     * @param null|string $LUser   Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Stt_rec = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'  => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pLUser'   => $LUser,
        ]);
    }
}
