<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAUpdTTHU.
 *
 * Stored procedure: asCAUpdTTHU
 * Mục đích: Cập nhật thông tin thu hồi (bảng TTHU).
 * Procedure thực hiện update bản ghi trong bảng TTHU với thông tin mới.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu. Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ. Default NULL.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Default NULL.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Default NULL.
 * - @pMa_ct_tt (nvarchar(3)): Mã chứng từ thanh toán. Default NULL.
 * - @pStt_rec_tt (nvarchar(20)): Số tham chiếu thanh toán. Default NULL.
 * - @pNgay_ct_tt (smalldatetime): Ngày chứng từ thanh toán. Default NULL.
 * - @pSo_ct_tt (nvarchar(12)): Số chứng từ thanh toán. Default NULL.
 * - @pMa_KH (nvarchar(20)): Mã khách hàng. Default NULL.
 * - @pTk_tu (nvarchar(20)): Tài khoản từ. Default NULL.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Default NULL.
 * - @pTy_gia (decimal): Tỷ giá. Default NULL.
 * - @pTien_pc (decimal): Tiền phát sinh. Default NULL.
 * - @pTien_pc_nt (decimal): Tiền phát sinh nguyên tệ. Default NULL.
 * - @pTien_da_tt (decimal): Tiền đã thanh toán. Default NULL.
 * - @pTien_da_tt_nt (decimal): Tiền đã thanh toán nguyên tệ. Default NULL.
 * - @pTat_toan (bit): Tất toán. Default NULL.
 * - @pDien_giai (nvarchar(255)): Diễn giải. Default NULL.
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
class AsCAUpdTTHU
{
    /**
     * Gọi stored procedure asCAUpdTTHU.
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

        return ProcedureCaller::call('asCAUpdTTHU', [
            'pMa_cty'        => $paramObj->pMa_cty ?? null,
            'pStt_rec'       => $paramObj->pStt_rec ?? null,
            'pMa_ct'         => $paramObj->pMa_ct ?? null,
            'pNgay_ct'       => $paramObj->pNgay_ct ?? null,
            'pSo_ct'         => $paramObj->pSo_ct ?? null,
            'pMa_ct_tt'      => $paramObj->pMa_ct_tt ?? null,
            'pStt_rec_tt'    => $paramObj->pStt_rec_tt ?? null,
            'pNgay_ct_tt'    => $paramObj->pNgay_ct_tt ?? null,
            'pSo_ct_tt'      => $paramObj->pSo_ct_tt ?? null,
            'pMa_KH'         => $paramObj->pMa_KH ?? null,
            'pTk_tu'         => $paramObj->pTk_tu ?? null,
            'pMa_nt'         => $paramObj->pMa_nt ?? null,
            'pTy_gia'        => $paramObj->pTy_gia ?? null,
            'pTien_pc'       => $paramObj->pTien_pc ?? null,
            'pTien_pc_nt'    => $paramObj->pTien_pc_nt ?? null,
            'pTien_da_tt'    => $paramObj->pTien_da_tt ?? null,
            'pTien_da_tt_nt' => $paramObj->pTien_da_tt_nt ?? null,
            'pTat_toan'      => $paramObj->pTat_toan ?? null,
            'pDien_giai'     => $paramObj->pDien_giai ?? null,
            'pLUser'         => $paramObj->pLUser ?? null,
            'pRet'           => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAUpdTTHU with named parameters (helper method).
     *
     * @param null|string $Ma_cty        Mã công ty
     * @param null|string $Stt_rec       Số tham chiếu
     * @param null|string $Ma_ct         Mã chứng từ
     * @param null|string $Ngay_ct       Ngày chứng từ
     * @param null|string $So_ct         Số chứng từ
     * @param null|string $Ma_ct_tt      Mã chứng từ thanh toán
     * @param null|string $Stt_rec_tt    Số tham chiếu thanh toán
     * @param null|string $Ngay_ct_tt    Ngày chứng từ thanh toán
     * @param null|string $So_ct_tt      Số chứng từ thanh toán
     * @param null|string $Ma_KH         Mã khách hàng
     * @param null|string $Tk_tu         Tài khoản từ
     * @param null|string $Ma_nt         Mã ngoại tệ
     * @param null|float  $Ty_gia        Tỷ giá
     * @param null|float  $Tien_pc       Tiền phát sinh
     * @param null|float  $Tien_pc_nt    Tiền phát sinh nguyên tệ
     * @param null|float  $Tien_da_tt    Tiền đã thanh toán
     * @param null|float  $Tien_da_tt_nt Tiền đã thanh toán nguyên tệ
     * @param null|bool   $Tat_toan      Tất toán
     * @param null|string $Dien_giai     Diễn giải
     * @param null|string $LUser         Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Stt_rec = null,
        ?string $Ma_ct = null,
        ?string $Ngay_ct = null,
        ?string $So_ct = null,
        ?string $Ma_ct_tt = null,
        ?string $Stt_rec_tt = null,
        ?string $Ngay_ct_tt = null,
        ?string $So_ct_tt = null,
        ?string $Ma_KH = null,
        ?string $Tk_tu = null,
        ?string $Ma_nt = null,
        ?float $Ty_gia = null,
        ?float $Tien_pc = null,
        ?float $Tien_pc_nt = null,
        ?float $Tien_da_tt = null,
        ?float $Tien_da_tt_nt = null,
        ?bool $Tat_toan = null,
        ?string $Dien_giai = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'        => $Ma_cty,
            'pStt_rec'       => $Stt_rec,
            'pMa_ct'         => $Ma_ct,
            'pNgay_ct'       => $Ngay_ct,
            'pSo_ct'         => $So_ct,
            'pMa_ct_tt'      => $Ma_ct_tt,
            'pStt_rec_tt'    => $Stt_rec_tt,
            'pNgay_ct_tt'    => $Ngay_ct_tt,
            'pSo_ct_tt'      => $So_ct_tt,
            'pMa_KH'         => $Ma_KH,
            'pTk_tu'         => $Tk_tu,
            'pMa_nt'         => $Ma_nt,
            'pTy_gia'        => $Ty_gia,
            'pTien_pc'       => $Tien_pc,
            'pTien_pc_nt'    => $Tien_pc_nt,
            'pTien_da_tt'    => $Tien_da_tt,
            'pTien_da_tt_nt' => $Tien_da_tt_nt,
            'pTat_toan'      => $Tat_toan,
            'pDien_giai'     => $Dien_giai,
            'pLUser'         => $LUser,
        ]);
    }
}
