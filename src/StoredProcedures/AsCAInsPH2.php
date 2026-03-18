<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-18 23:58:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsPH2.
 *
 * Stored procedure: asCAInsPH2
 * Mục đích: Thêm mới phiếu thu/chi (bảng CAPH2 - Cash Phiếu 2).
 * Procedure thực hiện insert bản ghi mới vào bảng CAPH2 với đầy đủ thông tin chứng từ thu/chi tiền mặt.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu (stt_rec). Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ (loại chứng từ). Bắt buộc.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Bắt buộc.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Bắt buộc.
 * - @pNgay_lct (smalldatetime): Ngày lập chứng từ. Bắt buộc.
 * - @pKht_tain (bit): Kế hoạch tài chính. Default 0.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Default ''.
 * - @pDia_chi (nvarchar(255)): Địa chỉ. Default ''.
 * - @pNguoi_gd (nvarchar(30)): Người giao dịch. Default ''.
 * - @pDien_giai (nvarchar(255)): Diễn giải nội dung. Bắt buộc.
 * - @pTk_co (nvarchar(20)): Tài khoản có. Bắt buộc.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Bắt buộc.
 * - @pTy_gia (decimal(19,4)): Tỷ giá. Default 1.0.
 * - @pT_tien_nt (decimal(19,4)): Tổng tiền nguyên tệ. Default 0.0.
 * - @pT_tien (decimal(19,4)): Tổng tiền quy đổi. Default 0.0.
 * - @pT_Thue (decimal(19,4)): Tổng thuế. Default 0.0.
 * - @pT_Tt_nt (decimal(19,4)): Tổng thanh toán nguyên tệ. Default 0.0.
 * - @pT_Tt (decimal(19,4)): Tổng thanh toán. Default 0.0.
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
 * $result = AsCAInsPH2::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001wCA40000000676668',
 *     'pMa_ct' => 'CA4',
 *     'pSo_ct' => 'BN02944',
 *     'pNgay_ct' => '2026-02-12',
 *     'pNgay_lct' => '2026-02-24',
 *     'pKht_tain' => 0,
 *     'pMa_kh' => 'CCNHUNGGOI',
 *     'pDien_giai' => 'thanh toán 12.02.26',
 *     'pTk_co' => '11217',
 *     'pMa_nt' => 'VND',
 *     'pTy_gia' => 1,
 *     'pT_tien_nt' => 142000000,
 *     'pT_tien' => 142000000,
 *     'pT_Tt_nt' => 142000000,
 *     'pT_Tt' => 142000000,
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
class AsCAInsPH2
{
    /**
     * Gọi stored procedure asCAInsPH2.
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số.
     *                      Các parameters có thể thiếu, sẽ dùng giá trị default.
     *
     * @return Collection Kết quả từ procedure (chứa output parameter pRet).
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAInsPH2', [
            'pMa_cty'     => $params['pMa_cty'] ?? null,
            'pStt_rec'    => $params['pStt_rec'] ?? null,
            'pMa_ct'      => $params['pMa_ct'] ?? null,
            'pSo_ct'      => $params['pSo_ct'] ?? null,
            'pNgay_ct'    => $params['pNgay_ct'] ?? null,
            'pNgay_lct'   => $params['pNgay_lct'] ?? null,
            'pKht_tain'   => $params['pKht_tain'] ?? 0,
            'pMa_kh'      => $params['pMa_kh'] ?? '',
            'pDia_chi'    => $params['pDia_chi'] ?? '',
            'pNguoi_gd'   => $params['pNguoi_gd'] ?? '',
            'pDien_giai'  => $params['pDien_giai'] ?? null,
            'pTk_co'      => $params['pTk_co'] ?? null,
            'pMa_nt'      => $params['pMa_nt'] ?? null,
            'pTy_gia'     => $params['pTy_gia'] ?? 1.0,
            'pT_tien_nt'  => $params['pT_tien_nt'] ?? 0.0,
            'pT_tien'     => $params['pT_tien'] ?? 0.0,
            'pT_Thue'     => $params['pT_Thue'] ?? 0.0,
            'pT_Tt_nt'    => $params['pT_Tt_nt'] ?? 0.0,
            'pT_Tt'       => $params['pT_Tt'] ?? 0.0,
            'pTrang_thai' => $params['pTrang_thai'] ?? '',
            'pPost2gl'    => $params['pPost2gl'] ?? '',
            'pLUser'      => $params['pLUser'] ?? null,
            'pRet'        => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAInsPH2 with named parameters (helper method).
     *
     * @param string|null $Ma_cty    Mã công ty
     * @param string|null $Stt_rec   Số tham chiếu
     * @param string|null $Ma_ct     Mã chứng từ
     * @param string|null $So_ct     Số chứng từ
     * @param string|null $Ngay_ct   Ngày chứng từ
     * @param string|null $Ngay_lct  Ngày lập chứng từ
     * @param int|float   $Kht_tain  Kế hoạch tài chính
     * @param string|null $Ma_kh     Mã khách hàng
     * @param string|null $Dia_chi   Địa chỉ
     * @param string|null $Nguoi_gd  Người giao dịch
     * @param string|null $Dien_giai Diễn giải
     * @param string|null $Tk_co     Tài khoản có
     * @param string|null $Ma_nt     Mã ngoại tệ
     * @param float|null  $Ty_gia    Tỷ giá
     * @param float|null  $T_tien_nt Tổng tiền nguyên tệ
     * @param float|null  $T_tien    Tổng tiền quy đổi
     * @param float|null  $T_Thue    Tổng thuế
     * @param float|null  $T_Tt_nt   Tổng thanh toán nguyên tệ
     * @param float|null  $T_Tt      Tổng thanh toán
     * @param string|null $Trang_thai Trạng thái
     * @param string|null $Post2gl   Đã post GL
     * @param string|null $LUser     Người dùng
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
        $Kht_tain = 0,
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
            'pKht_tain'   => $Kht_tain,
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
            'pTrang_thai' => $Trang_thai,
            'pPost2gl'    => $Post2gl,
            'pLUser'      => $LUser,
        ]);
    }
}
