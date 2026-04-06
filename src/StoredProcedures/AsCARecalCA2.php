<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCARecalCA2.
 *
 * Stored procedure: asCARecalCA2
 * Mục đích: Tính toán lại chứng từ loại 2 (CA2 - Cost Accounting 2).
 * Procedure thực hiện tính toán lại các bút toán chi phí loại 2, cập nhật các số liệu phát sinh nợ/có vào bảng CaCt2.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu. Bắt buộc.
 * - @pLUser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
 * - @pRet (int, OUTPUT): Tham số đầu ra chứa mã lỗi (@@error).
 *   - 0: Thành công.
 *   - Khác 0: Mã lỗi SQL Server.
 *
 * Giá trị trả về:
 * - Procedure không trả về result set.
 * - Kết quả được trả về qua output parameter @pRet.
 *
 * Lưu ý:
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCARecalCA2
{
    /**
     * Gọi stored procedure asCARecalCA2.
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

        return ProcedureCaller::call('asCARecalCA2', [
            'pMa_cty'  => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pLUser'   => $paramObj->pLUser ?? null,
            'pRet'     => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCARecalCA2 with named parameters (helper method).
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
