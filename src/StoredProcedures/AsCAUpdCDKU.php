<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:35:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAUpdCDKU.
 *
 * Stored procedure: asCAUpdCDKU
 * Mục đích: Cập nhật chứng từ điều chỉnh kho (bảng CDKU).
 * Procedure thực hiện update bản ghi trong bảng CDKU với thông tin mới.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNam (int): Năm. Default NULL.
 * - @pMa_ku (nvarchar(20)): Mã khu vực. Default NULL.
 * - @pTk (nvarchar(20)): Tài khoản. Default NULL.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Default NULL.
 * - @pNgay_ku (smalldatetime): Ngày điều chỉnh. Default NULL.
 * - @pNgay_tt (smalldatetime): Ngày thanh toán. Default NULL.
 * - @pDa_vay (decimal(19,4)): Đã vay. Default NULL.
 * - @pDa_vay_nt (decimal(19,4)): Đã vay nguyên tệ. Default NULL.
 * - @pDa_tt (decimal(19,4)): Đã thanh toán. Default NULL.
 * - @pDa_tt_nt (decimal(19,4)): Đã thanh toán nguyên tệ. Default NULL.
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
class AsCAUpdCDKU
{
    /**
     * Gọi stored procedure asCAUpdCDKU.
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

        return ProcedureCaller::call('asCAUpdCDKU', [
            'pMa_cty'    => $paramObj->pMa_cty ?? null,
            'pNam'       => $paramObj->pNam ?? null,
            'pMa_ku'     => $paramObj->pMa_ku ?? null,
            'pTk'        => $paramObj->pTk ?? null,
            'pMa_nt'     => $paramObj->pMa_nt ?? null,
            'pNgay_ku'   => $paramObj->pNgay_ku ?? null,
            'pNgay_tt'   => $paramObj->pNgay_tt ?? null,
            'pDa_vay'    => $paramObj->pDa_vay ?? null,
            'pDa_vay_nt' => $paramObj->pDa_vay_nt ?? null,
            'pDa_tt'     => $paramObj->pDa_tt ?? null,
            'pDa_tt_nt'  => $paramObj->pDa_tt_nt ?? null,
            'pLUser'     => $paramObj->pLUser ?? null,
            'pRet'       => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAUpdCDKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty    Mã công ty
     * @param null|int    $Nam       Năm
     * @param null|string $Ma_ku     Mã khu vực
     * @param null|string $Tk        Tài khoản
     * @param null|string $Ma_nt     Mã ngoại tệ
     * @param null|string $Ngay_ku   Ngày điều chỉnh
     * @param null|string $Ngay_tt   Ngày thanh toán
     * @param null|float  $Da_vay    Đã vay
     * @param null|float  $Da_vay_nt Đã vay nguyên tệ
     * @param null|float  $Da_tt     Đã thanh toán
     * @param null|float  $Da_tt_nt  Đã thanh toán nguyên tệ
     * @param null|string $LUser     Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?int $Nam = null,
        ?string $Ma_ku = null,
        ?string $Tk = null,
        ?string $Ma_nt = null,
        ?string $Ngay_ku = null,
        ?string $Ngay_tt = null,
        ?float $Da_vay = null,
        ?float $Da_vay_nt = null,
        ?float $Da_tt = null,
        ?float $Da_tt_nt = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'    => $Ma_cty,
            'pNam'       => $Nam,
            'pMa_ku'     => $Ma_ku,
            'pTk'        => $Tk,
            'pMa_nt'     => $Ma_nt,
            'pNgay_ku'   => $Ngay_ku,
            'pNgay_tt'   => $Ngay_tt,
            'pDa_vay'    => $Da_vay,
            'pDa_vay_nt' => $Da_vay_nt,
            'pDa_tt'     => $Da_tt,
            'pDa_tt_nt'  => $Da_tt_nt,
            'pLUser'     => $LUser,
        ]);
    }
}
