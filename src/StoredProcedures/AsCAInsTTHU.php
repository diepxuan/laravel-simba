<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsTTHU.
 *
 * Stored procedure: asCAInsTTHU
 * Mục đích: Thêm mới thanh toán thu (bảng CATTHU - Cash Thanh Toán Thu).
 * Procedure thực hiện insert bản ghi mới vào bảng CATTHU với thông tin thanh toán thu tiền từ khách hàng.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu (stt_rec). Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ (loại chứng từ). Bắt buộc.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Bắt buộc.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Bắt buộc.
 * - @pNgay_lct (smalldatetime): Ngày lập chứng từ. Bắt buộc.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Bắt buộc.
 * - @pDia_chi (nvarchar(255)): Địa chỉ. Default ''.
 * - @pNguoi_gd (nvarchar(30)): Người giao dịch. Default ''.
 * - @pDien_giai (nvarchar(255)): Diễn giải nội dung. Bắt buộc.
 * - @pTk_co (nvarchar(20)): Tài khoản có (thu tiền). Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Bắt buộc.
 * - @pTy_gia (decimal(19,4)): Tỷ giá. Default 1.0.
 * - @pT_tien_nt (decimal(19,4)): Tổng tiền nguyên tệ. Default 0.0.
 * - @pT_tien (decimal(19,4)): Tổng tiền quy đổi. Default 0.0.
 * - @pT_Thue (decimal(19,4)): Tổng thuế. Default 0.0.
 * - @pT_Tt_nt (decimal(19,4)): Tổng thanh toán nguyên tệ. Default 0.0.
 * - @pT_Tt (decimal(19,4)): Tổng thanh toán. Default 0.0.
 * - @pSo_hd (nvarchar(20)): Số hóa đơn liên quan. Default ''.
 * - @pNgay_hd (smalldatetime): Ngày hóa đơn. Default NULL.
 * - @pKy_hd (nvarchar(10)): Kỳ hóa đơn. Default ''.
 * - @pTrang_thai (nvarchar(1)): Trạng thái chứng từ. Default ''.
 * - @pPost2gl (nvarchar(1)): Đã post sang GL. Default ''.
 * - @pLUser (nvarchar(20)): Người dùng thực hiện. Bắt buộc.
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
 * $result = AsCAInsTTHU::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001wCA70000000676668',
 *     'pMa_ct' => 'CA7',
 *     'pSo_ct' => 'THU02944',
 *     'pNgay_ct' => '2026-02-12',
 *     'pNgay_lct' => '2026-02-24',
 *     'pMa_kh' => 'CCNHUNGGOI',
 *     'pDien_giai' => 'thanh toán thu 12.02.26',
 *     'pTk_co' => '1311',
 *     'pMa_nt' => 'VND',
 *     'pTy_gia' => 1,
 *     'pT_tien_nt' => 142000000,
 *     'pT_tien' => 142000000,
 *     'pT_Tt_nt' => 142000000,
 *     'pT_Tt' => 142000000,
 *     'pSo_hd' => 'HD001',
 *     'pNgay_hd' => '2026-02-10',
 *     'pLUser' => 'DUCTN',
 * ]);
 *
 * // Lấy giá trị output parameter
 * $ret = $result->first()->pRet ?? null;
 * if ($ret === 0) {
 *     // Insert thành công
 * } else {
 *     // Có lỗi xảy ra, $ret chứa mã lỗi
 * }
 * ```
 *
 * Lưu ý:
 * - Procedure chỉ thực hiện insert, không kiểm tra trùng số chứng từ.
 * - Cần gọi `asChkSoCt` trước để đảm bảo số chứng từ không trùng.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 *
 * @see AsChkSoCt::call() - Kiểm tra trùng số chứng từ trước khi insert
 */
class AsCAInsTTHU
{
    /**
     * Gọi stored procedure asCAInsTTHU.
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

        return ProcedureCaller::call('asCAInsTTHU', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'   => $paramObj->pNgay_lct ?? null,
            'pMa_kh'      => $paramObj->pMa_kh ?? null,
            'pDia_chi'    => $paramObj->pDia_chi ?? '',
            'pNguoi_gd'   => $paramObj->pNguoi_gd ?? '',
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
            'pTk_co'      => $paramObj->pTk_co ?? null,
            'pMa_nt'      => $paramObj->pMa_nt ?? null,
            'pTy_gia'     => $paramObj->pTy_gia ?? 1.0,
            'pT_tien_nt'  => $paramObj->pT_tien_nt ?? 0.0,
            'pT_tien'     => $paramObj->pT_tien ?? 0.0,
            'pT_Thue'     => $paramObj->pT_Thue ?? 0.0,
            'pT_Tt_nt'    => $paramObj->pT_Tt_nt ?? 0.0,
            'pT_Tt'       => $paramObj->pT_Tt ?? 0.0,
            'pSo_hd'      => $paramObj->pSo_hd ?? '',
            'pNgay_hd'    => $paramObj->pNgay_hd ?? null,
            'pKy_hd'      => $paramObj->pKy_hd ?? '',
            'pTrang_thai' => $paramObj->pTrang_thai ?? '',
            'pPost2gl'    => $paramObj->pPost2gl ?? '',
            'pLUser'      => $paramObj->pLUser ?? null,
            'pRet'        => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAInsTTHU with named parameters (helper method).
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
     * @param null|string $Tk_co      Tài khoản có
     * @param null|string $Ma_nt      Mã ngoại tệ
     * @param null|float  $Ty_gia     Tỷ giá
     * @param null|float  $T_tien_nt  Tổng tiền nguyên tệ
     * @param null|float  $T_tien     Tổng tiền quy đổi
     * @param null|float  $T_Thue     Tổng thuế
     * @param null|float  $T_Tt_nt    Tổng thanh toán nguyên tệ
     * @param null|float  $T_Tt       Tổng thanh toán
     * @param null|string $So_hd      Số hóa đơn
     * @param null|string $Ngay_hd    Ngày hóa đơn
     * @param null|string $Ky_hd      Kỳ hóa đơn
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
        ?string $Tk_co = null,
        ?string $Ma_nt = null,
        ?float $Ty_gia = null,
        ?float $T_tien_nt = null,
        ?float $T_tien = null,
        ?float $T_Thue = null,
        ?float $T_Tt_nt = null,
        ?float $T_Tt = null,
        ?string $So_hd = null,
        ?string $Ngay_hd = null,
        ?string $Ky_hd = null,
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
            'pTk_co'      => $Tk_co,
            'pMa_nt'      => $Ma_nt,
            'pTy_gia'     => $Ty_gia,
            'pT_tien_nt'  => $T_tien_nt,
            'pT_tien'     => $T_tien,
            'pT_Thue'     => $T_Thue,
            'pT_Tt_nt'    => $T_Tt_nt,
            'pT_Tt'       => $T_Tt,
            'pSo_hd'      => $So_hd,
            'pNgay_hd'    => $Ngay_hd,
            'pKy_hd'      => $Ky_hd,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl'    => $Post2gl,
            'pLUser'      => $LUser,
        ]);
    }
}
