<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:47:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAUpdLaiKu.
 *
 * Stored procedure: asCAUpdLaiKu
 * Mục đích: Cập nhật lãi lỗ kho (bảng LaiKu).
 * Procedure thực hiện update bản ghi trong bảng LaiKu với thông tin lãi lỗ mới.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pNgay_tra (smalldatetime): Ngày trả. Default NULL.
 * - @pMa_ku (nvarchar(20)): Mã khu vực. Default NULL.
 * - @pNam (int): Năm. Default NULL.
 * - @pThang (int): Tháng. Default NULL.
 * - @pTien_lai_tk (decimal): Tiền lãi trong kỳ. Default NULL.
 * - @pTien_lai_tk_nt (decimal): Tiền lãi trong kỳ nguyên tệ. Default NULL.
 * - @pTien_goc_tk (decimal): Tiền gốc trong kỳ. Default NULL.
 * - @pTien_goc_tk_nt (decimal): Tiền gốc trong kỳ nguyên tệ. Default NULL.
 * - @pTien_lai_qh (decimal): Tiền lãi quá hạn. Default NULL.
 * - @pTien_lai_qh_nt (decimal): Tiền lãi quá hạn nguyên tệ. Default NULL.
 * - @pTien_goc_qh (decimal): Tiền gốc quá hạn. Default NULL.
 * - @pTien_goc_qh_nt (decimal): Tiền gốc quá hạn nguyên tệ. Default NULL.
 * - @pSua_lai (bit): Sửa lãi. Default NULL.
 * - @pSua_goc (bit): Sửa gốc. Default NULL.
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
class AsCAUpdLaiKu
{
    /**
     * Gọi stored procedure asCAUpdLaiKu.
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

        return ProcedureCaller::call('asCAUpdLaiKu', [
            'pMa_cty'         => $paramObj->pMa_cty ?? null,
            'pNgay_tra'       => $paramObj->pNgay_tra ?? null,
            'pMa_ku'          => $paramObj->pMa_ku ?? null,
            'pNam'            => $paramObj->pNam ?? null,
            'pThang'          => $paramObj->pThang ?? null,
            'pTien_lai_tk'    => $paramObj->pTien_lai_tk ?? null,
            'pTien_lai_tk_nt' => $paramObj->pTien_lai_tk_nt ?? null,
            'pTien_goc_tk'    => $paramObj->pTien_goc_tk ?? null,
            'pTien_goc_tk_nt' => $paramObj->pTien_goc_tk_nt ?? null,
            'pTien_lai_qh'    => $paramObj->pTien_lai_qh ?? null,
            'pTien_lai_qh_nt' => $paramObj->pTien_lai_qh_nt ?? null,
            'pTien_goc_qh'    => $paramObj->pTien_goc_qh ?? null,
            'pTien_goc_qh_nt' => $paramObj->pTien_goc_qh_nt ?? null,
            'pSua_lai'        => $paramObj->pSua_lai ?? null,
            'pSua_goc'        => $paramObj->pSua_goc ?? null,
            'pLUser'          => $paramObj->pLUser ?? null,
            'pRet'            => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAUpdLaiKu with named parameters (helper method).
     *
     * @param null|string $Ma_cty         Mã công ty
     * @param null|string $Ngay_tra       Ngày trả
     * @param null|string $Ma_ku          Mã khu vực
     * @param null|int    $Nam            Năm
     * @param null|int    $Thang          Tháng
     * @param null|float  $Tien_lai_tk    Tiền lãi trong kỳ
     * @param null|float  $Tien_lai_tk_nt Tiền lãi trong kỳ nguyên tệ
     * @param null|float  $Tien_goc_tk    Tiền gốc trong kỳ
     * @param null|float  $Tien_goc_tk_nt Tiền gốc trong kỳ nguyên tệ
     * @param null|float  $Tien_lai_qh    Tiền lãi quá hạn
     * @param null|float  $Tien_lai_qh_nt Tiền lãi quá hạn nguyên tệ
     * @param null|float  $Tien_goc_qh    Tiền gốc quá hạn
     * @param null|float  $Tien_goc_qh_nt Tiền gốc quá hạn nguyên tệ
     * @param null|bool   $Sua_lai        Sửa lãi
     * @param null|bool   $Sua_goc        Sửa gốc
     * @param null|string $LUser          Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ngay_tra = null,
        ?string $Ma_ku = null,
        ?int $Nam = null,
        ?int $Thang = null,
        ?float $Tien_lai_tk = null,
        ?float $Tien_lai_tk_nt = null,
        ?float $Tien_goc_tk = null,
        ?float $Tien_goc_tk_nt = null,
        ?float $Tien_lai_qh = null,
        ?float $Tien_lai_qh_nt = null,
        ?float $Tien_goc_qh = null,
        ?float $Tien_goc_qh_nt = null,
        ?bool $Sua_lai = null,
        ?bool $Sua_goc = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'         => $Ma_cty,
            'pNgay_tra'       => $Ngay_tra,
            'pMa_ku'          => $Ma_ku,
            'pNam'            => $Nam,
            'pThang'          => $Thang,
            'pTien_lai_tk'    => $Tien_lai_tk,
            'pTien_lai_tk_nt' => $Tien_lai_tk_nt,
            'pTien_goc_tk'    => $Tien_goc_tk,
            'pTien_goc_tk_nt' => $Tien_goc_tk_nt,
            'pTien_lai_qh'    => $Tien_lai_qh,
            'pTien_lai_qh_nt' => $Tien_lai_qh_nt,
            'pTien_goc_qh'    => $Tien_goc_qh,
            'pTien_goc_qh_nt' => $Tien_goc_qh_nt,
            'pSua_lai'        => $Sua_lai,
            'pSua_goc'        => $Sua_goc,
            'pLUser'          => $LUser,
        ]);
    }
}
