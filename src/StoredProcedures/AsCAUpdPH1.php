<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAUpdPH1.
 *
 * Stored procedure: asCAUpdPH1
 * Mục đích: Cập nhật phiếu thu/chi 1 (bảng CAPH1).
 * Procedure thực hiện update bản ghi trong bảng CAPH1 với thông tin mới.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Default NULL.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Default NULL.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Default NULL.
 * - @pNgay_lct (smalldatetime): Ngày lập chứng từ. Default NULL.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Default NULL.
 * - @pDia_chi (nvarchar(255)): Địa chỉ. Default NULL.
 * - @pNguoi_gd (nvarchar(30)): Người giao dịch. Default NULL.
 * - @pDien_giai (nvarchar(255)): Diễn giải. Default NULL.
 * - @pTk_no (nvarchar(20)): Tài khoản nợ. Default NULL.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Default NULL.
 * - @pTy_gia (decimal): Tỷ giá. Default NULL.
 * - @pT_tien_nt (decimal): Tổng tiền nguyên tệ. Default NULL.
 * - @pT_tien (decimal): Tổng tiền. Default NULL.
 * - @pTrang_thai (nvarchar(1)): Trạng thái. Default NULL.
 * - @pPost2gl (nvarchar(1)): Đã post GL. Default NULL.
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
class AsCAUpdPH1
{
    /**
     * Gọi stored procedure asCAUpdPH1.
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

        return ProcedureCaller::call('asCAUpdPH1', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'   => $paramObj->pNgay_lct ?? null,
            'pMa_kh'      => $paramObj->pMa_kh ?? null,
            'pDia_chi'    => $paramObj->pDia_chi ?? null,
            'pNguoi_gd'   => $paramObj->pNguoi_gd ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
            'pTk_no'      => $paramObj->pTk_no ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTy_gia'     => $paramObj->pTy_gia ?? null,
            'pT_tien_nt'  => $paramObj->pT_tien_nt ?? null,
            'pT_tien'     => $paramObj->pT_tien ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pPost2gl'    => $paramObj->pPost2gl ?? null,
            'pLUser'      => $paramObj->pLUser ?? null,
            'pRet'        => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAUpdPH1 with named parameters (helper method).
     *
     * @param null|string $Ma_cty     Mã công ty
     * @param null|string $Stt_rec    Số tham chiếu
     * @param null|string $Ma_ct      Mã chứng từ
     * @param null|string $So_ct      Số chứng từ
     * @param null|string $Ngay_ct    Ngày chứng từ
     * @param null|string $Ngay_lct   Ngày lập chứng từ
     * @param null|string $Ma_kh      Mã khách hàng
     * @param null|string $Dia_chi    Địa chỉ
     * @param null|string $Nguoi_gd   Người giao dịch
     * @param null|string $Dien_giai  Diễn giải
     * @param null|string $Tk_no      Tài khoản nợ
     * @param null|string $Ma_nt      Mã ngoại tệ
     * @param null|float  $Ty_gia     Tỷ giá
     * @param null|float  $T_tien_nt  Tổng tiền nguyên tệ
     * @param null|float  $T_tien     Tổng tiền
     * @param null|string $Trang_thai Trạng thái
     * @param null|string $Post2gl    Đã post GL
     * @param null|string $LUser      Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Stt_rec = null,
        ?string $Ma_ct = null,
        ?string $So_ct = null,
        ?string $Ngay_ct = null,
        ?string $Ngay_lct = null,
        ?string $Ma_kh = null,
        ?string $Dia_chi = null,
        ?string $Nguoi_gd = null,
        ?string $Dien_giai = null,
        ?string $Tk_no = null,
        ?string $Ma_nt = null,
        ?float $Ty_gia = null,
        ?float $T_tien_nt = null,
        ?float $T_tien = null,
        ?string $Trang_thai = null,
        ?string $Post2gl = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'     => $Ma_cty,
            'pStt_rec'    => $Stt_rec,
            'pMa_ct'      => $Ma_ct,
            'pSo_ct'      => $So_ct,
            'pNgay_ct'    => $Ngay_ct,
            'pNgay_lct'   => $Ngay_lct,
            'pMa_kh'      => $Ma_kh,
            'pDia_chi'    => $Dia_chi,
            'pNguoi_gd'   => $Nguoi_gd,
            'pDien_giai'  => $Dien_giai,
            'pTk_no'      => $Tk_no,
            'pMa_nt'      => $Ma_nt,
            'pTy_gia'     => $Ty_gia,
            'pT_tien_nt'  => $T_tien_nt,
            'pT_tien'     => $T_tien,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl'    => $Post2gl,
            'pLUser'      => $LUser,
        ]);
    }
}
