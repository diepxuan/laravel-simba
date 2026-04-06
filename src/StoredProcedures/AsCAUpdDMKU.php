<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:47:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAUpdDMKU.
 *
 * Stored procedure: asCAUpdDMKU
 * Mục đích: Cập nhật định mức kho (bảng DMKU).
 * Procedure thực hiện update bản ghi trong bảng DMKU với thông tin mới.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_ku (nvarchar(20)): Mã khu vực. Default NULL.
 * - @pTen_ku (nvarchar(255)): Tên khu vực. Default NULL.
 * - @pSo_ku (decimal): Số khu vực. Default NULL.
 * - @pNgay_vay (smalldatetime): Ngày vay. Default NULL.
 * - @pNgay_ky (smalldatetime): Ngày ký. Default NULL.
 * - @pThoi_han (int): Thời hạn. Default NULL.
 * - @pTinh_theo (nvarchar(1)): Tính theo. Default NULL.
 * - @pPhuong_phap (nvarchar(1)): Phương pháp. Default NULL.
 * - @pKy_tt_goc (int): Kỳ thanh toán gốc. Default NULL.
 * - @pKy_tt_lai (int): Kỳ thanh toán lãi. Default NULL.
 * - @pNgay_dh (smalldatetime): Ngày đến hạn. Default NULL.
 * - @pMa_hd (nvarchar(20)): Mã hợp đồng. Default NULL.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Default NULL.
 * - @pTien_nt (decimal): Tiền nguyên tệ. Default NULL.
 * - @pTien (decimal): Tiền. Default NULL.
 * - @pLai_suat (decimal): Lãi suất. Default NULL.
 * - @pLs_qh (decimal): Lãi suất quá hạn. Default NULL.
 * - @pTk_vay (nvarchar(20)): Tài khoản vay. Default NULL.
 * - @pTk_cp (nvarchar(20)): Tài khoản chi phí. Default NULL.
 * - @pTk_cp_pt (nvarchar(20)): Tài khoản chi phí phân bổ. Default NULL.
 * - @pGhi_chu (nvarchar(255)): Ghi chú. Default NULL.
 * - @pKsd (bit): Khóa sử dụng. Default NULL.
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
class AsCAUpdDMKU
{
    /**
     * Gọi stored procedure asCAUpdDMKU.
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

        return ProcedureCaller::call('asCAUpdDMKU', [
            'pMa_cty'      => $paramObj->pMa_cty ?? null,
            'pMa_ku'       => $paramObj->pMa_ku ?? null,
            'pTen_ku'      => $paramObj->pTen_ku ?? null,
            'pSo_ku'       => $paramObj->pSo_ku ?? null,
            'pNgay_vay'    => $paramObj->pNgay_vay ?? null,
            'pNgay_ky'     => $paramObj->pNgay_ky ?? null,
            'pThoi_han'    => $paramObj->pThoi_han ?? null,
            'pTinh_theo'   => $paramObj->pTinh_theo ?? null,
            'pPhuong_phap' => $paramObj->pPhuong_phap ?? null,
            'pKy_tt_goc'   => $paramObj->pKy_tt_goc ?? null,
            'pKy_tt_lai'   => $paramObj->pKy_tt_lai ?? null,
            'pNgay_dh'     => $paramObj->pNgay_dh ?? null,
            'pMa_hd'       => $paramObj->pMa_hd ?? null,
            'pMa_nt'       => $paramObj->pMa_nt ?? null,
            'pTien_nt'     => $paramObj->pTien_nt ?? null,
            'pTien'        => $paramObj->pTien ?? null,
            'pLai_suat'    => $paramObj->pLai_suat ?? null,
            'pLs_qh'       => $paramObj->pLs_qh ?? null,
            'pTk_vay'      => $paramObj->pTk_vay ?? null,
            'pTk_cp'       => $paramObj->pTk_cp ?? null,
            'pTk_cp_pt'    => $paramObj->pTk_cp_pt ?? null,
            'pGhi_chu'     => $paramObj->pGhi_chu ?? null,
            'pKsd'         => $paramObj->pKsd ?? null,
            'pLUser'       => $paramObj->pLUser ?? null,
            'pRet'         => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAUpdDMKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty      Mã công ty
     * @param null|string $Ma_ku       Mã khu vực
     * @param null|string $Ten_ku      Tên khu vực
     * @param null|float  $So_ku       Số khu vực
     * @param null|string $Ngay_vay    Ngày vay
     * @param null|string $Ngay_ky     Ngày ký
     * @param null|int    $Thoi_han    Thời hạn
     * @param null|string $Tinh_theo   Tính theo
     * @param null|string $Phuong_phap Phương pháp
     * @param null|int    $Ky_tt_goc   Kỳ thanh toán gốc
     * @param null|int    $Ky_tt_lai   Kỳ thanh toán lãi
     * @param null|string $Ngay_dh     Ngày đến hạn
     * @param null|string $Ma_hd       Mã hợp đồng
     * @param null|string $Ma_nt       Mã ngoại tệ
     * @param null|float  $Tien_nt     Tiền nguyên tệ
     * @param null|float  $Tien        Tiền
     * @param null|float  $Lai_suat    Lãi suất
     * @param null|float  $Ls_qh       Lãi suất quá hạn
     * @param null|string $Tk_vay      Tài khoản vay
     * @param null|string $Tk_cp       Tài khoản chi phí
     * @param null|string $Tk_cp_pt    TK chi phí phân bổ
     * @param null|string $Ghi_chu     Ghi chú
     * @param null|bool   $Ksd         Khóa sử dụng
     * @param null|string $LUser       Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ma_ku = null,
        ?string $Ten_ku = null,
        ?float $So_ku = null,
        ?string $Ngay_vay = null,
        ?string $Ngay_ky = null,
        ?int $Thoi_han = null,
        ?string $Tinh_theo = null,
        ?string $Phuong_phap = null,
        ?int $Ky_tt_goc = null,
        ?int $Ky_tt_lai = null,
        ?string $Ngay_dh = null,
        ?string $Ma_hd = null,
        ?string $Ma_nt = null,
        ?float $Tien_nt = null,
        ?float $Tien = null,
        ?float $Lai_suat = null,
        ?float $Ls_qh = null,
        ?string $Tk_vay = null,
        ?string $Tk_cp = null,
        ?string $Tk_cp_pt = null,
        ?string $Ghi_chu = null,
        ?bool $Ksd = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'      => $Ma_cty,
            'pMa_ku'       => $Ma_ku,
            'pTen_ku'      => $Ten_ku,
            'pSo_ku'       => $So_ku,
            'pNgay_vay'    => $Ngay_vay,
            'pNgay_ky'     => $Ngay_ky,
            'pThoi_han'    => $Thoi_han,
            'pTinh_theo'   => $Tinh_theo,
            'pPhuong_phap' => $Phuong_phap,
            'pKy_tt_goc'   => $Ky_tt_goc,
            'pKy_tt_lai'   => $Ky_tt_lai,
            'pNgay_dh'     => $Ngay_dh,
            'pMa_hd'       => $Ma_hd,
            'pMa_nt'       => $Ma_nt,
            'pTien_nt'     => $Tien_nt,
            'pTien'        => $Tien,
            'pLai_suat'    => $Lai_suat,
            'pLs_qh'       => $Ls_qh,
            'pTk_vay'      => $Tk_vay,
            'pTk_cp'       => $Tk_cp,
            'pTk_cp_pt'    => $Tk_cp_pt,
            'pGhi_chu'     => $Ghi_chu,
            'pKsd'         => $Ksd,
            'pLUser'       => $LUser,
        ]);
    }
}
