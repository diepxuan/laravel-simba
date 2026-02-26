<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:13:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsTaIn.
 *
 * Stored procedure: asInsTaIn
 * Mục đích: Chèn một bản ghi nhập kho vào bảng TaIn.
 * Bảng TaIn lưu thông tin chi tiết nhập kho (có thể liên quan đến hàng hóa, thuế nhập khẩu, thuế TTĐB, VAT).
 * Procedure kiểm tra trùng lặp dựa trên so_ct0 + seri0 (số chứng từ nhập + số seri) trong cùng mã công ty.
 * Nếu trùng, trả về mã lỗi 50211 và không INSERT.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi (20 ký tự). Khóa chính?.
 * - @pStt_rec0 (string, bắt buộc): Số thứ tự bản ghi chi tiết (3 ký tự). Phân biệt các dòng trong cùng stt_rec.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (3 ký tự). Loại chứng từ nhập.
 * - @pMa_bp (string, bắt buộc): Mã bộ phận (20 ký tự). Bộ phận nhận hàng.
 * - @pNgay_ct (smalldatetime, bắt buộc): Ngày chứng từ.
 * - @pSo_seri_mhd (string, bắt buộc): Số seri mẫu hóa đơn (11 ký tự).
 * - @pNgay_ct0 (smalldatetime, bắt buộc): Ngày chứng từ gốc? (có thể ngày hóa đơn).
 * - @pSo_ct (string, bắt buộc): Số chứng từ (12 ký tự). Số chứng từ nhập.
 * - @pSo_ct0 (string, bắt buộc): Số chứng từ gốc (12 ký tự). Số hóa đơn nhập.
 * - @pSo_seri0 (string, bắt buộc): Số seri gốc (12 ký tự). Số seri hóa đơn nhập.
 * - @pMau_bc (int, bắt buộc): Mẫu báo cáo (nguyên). Có thể liên quan đến mẫu in.
 * - @pMa_kh (string, bắt buộc): Mã khách hàng (20 ký tự). Nhà cung cấp.
 * - @pTen_kh (string, bắt buộc): Tên khách hàng (100 ký tự, Unicode).
 * - @pDia_chi (string, bắt buộc): Địa chỉ khách hàng (255 ký tự, Unicode).
 * - @pMa_so_thue (string, bắt buộc): Mã số thuế (20 ký tự).
 * - @pMa_vt (string, bắt buộc): Mã vật tư (20 ký tự).
 * - @pTen_vt (string, bắt buộc): Tên vật tư (100 ký tự, Unicode).
 * - @pSo_luong (decimal, bắt buộc): Số lượng nhập (độ chính xác 19,4).
 * - @pGia_nt (decimal, bắt buộc): Giá nhập ngoại tệ (19,4).
 * - @pTien_hang_nt (decimal, bắt buộc): Tiền hàng ngoại tệ (19,4).
 * - @pThue_nk_nt (decimal, bắt buộc): Thuế nhập khẩu ngoại tệ (19,4).
 * - @pThue_ttdb_nt (decimal, bắt buộc): Thuế tiêu thụ đặc biệt ngoại tệ (19,4).
 * - @pT_tien_nt (decimal, bắt buộc): Tổng tiền ngoại tệ (19,4).
 * - @pThue_suat (decimal, bắt buộc): Thuế suất (19,4). Có thể là thuế VAT.
 * - @pT_thue_nt (decimal, bắt buộc): Tiền thuế ngoại tệ (19,4).
 * - @pMa_nt (string, bắt buộc): Mã ngoại tệ (3 ký tự).
 * - @pTy_gia (decimal, bắt buộc): Tỷ giá (19,4).
 * - @pGia (decimal, bắt buộc): Giá nhập nội tệ (19,4).
 * - @pTien_hang (decimal, bắt buộc): Tiền hàng nội tệ (19,4).
 * - @pThue_nk (decimal, bắt buộc): Thuế nhập khẩu nội tệ (19,4).
 * - @pThue_ttdb (decimal, bắt buộc): Thuế tiêu thụ đặc biệt nội tệ (19,4).
 * - @pT_tien (decimal, bắt buộc): Tổng tiền nội tệ (19,4).
 * - @pT_thue (decimal, bắt buộc): Tiền thuế nội tệ (19,4).
 * - @pTk_thue_no (string, bắt buộc): Tài khoản thuế nợ (20 ký tự).
 * - @pTk_du (string, bắt buộc): Tài khoản dư (20 ký tự). Tài khoản đối ứng.
 * - @pGhi_chu (string, bắt buộc): Ghi chú (255 ký tự, Unicode).
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pMa_lo (string, bắt buộc): Mã lô (20 ký tự).
 * - @pVAT_NK (bool, optional, mặc định = 1): Cờ VAT nhập khẩu (bit). 1 = có VAT nhập khẩu, 0 = không.
 * - @pStt_rec_pc (string, bắt buộc): Số thứ tự bản ghi phân bổ? (20 ký tự). Có thể liên kết với chứng từ khác.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL hoặc 50211 nếu trùng).
 *
 * Giá trị mặc định:
 * - @pVAT_NK có giá trị mặc định = 1.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công.
 * - @pRet = 50211 nếu đã tồn tại bản ghi có cùng ma_cty và so_ct0+'SIMBA'+so_seri0 (trùng số chứng từ và seri).
 * - @pRet = mã lỗi SQL khác nếu có lỗi INSERT.
 *
 * Logic chi tiết:
 * 1. Kiểm tra EXISTS: SELECT so_seri0 FROM tain WHERE ma_cty = @pMa_cty AND so_ct0+'SIMBA'+so_seri0 = @pSo_ct0 + 'SIMBA' + @pSo_seri0.
 * 2. Nếu tồn tại, gán @pRet = 50211 và RETURN.
 * 3. Nếu không trùng, INSERT vào TaIn với các giá trị truyền vào.
 * 4. Cột cdate, ldate = GETDATE().
 * 5. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Bảng TaIn có khóa chính có thể là (ma_cty, stt_rec, stt_rec0) hoặc (stt_rec, stt_rec0).
 * - Kiểm tra trùng dựa trên so_ct0 + 'SIMBA' + so_seri0 (chuỗi nối với hằng 'SIMBA' để tránh nhầm lẫn?).
 * - Mã lỗi 50211 có thể là mã lỗi nghiệp vụ tự định nghĩa (trùng chứng từ nhập).
 * - Các giá trị decimal với độ chính xác 19,4.
 * - Cột VAT_NK có giá trị mặc định 1 (có VAT nhập khẩu). Có thể truyền 0 nếu không có.
 * - Nên đảm bảo các mã tham chiếu (ma_kh, ma_vt, ma_nt, ...) tồn tại trong các bảng danh mục.
 * - Có thể có ràng buộc khóa ngoại với các bảng khác.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsTaIn::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'NK001',
 *     'pStt_rec0' => '001',
 *     'pMa_ct' => 'NK',
 *     'pMa_bp' => 'BP001',
 *     'pNgay_ct' => '2025-02-11',
 *     'pSo_seri_mhd' => 'MHD01',
 *     'pNgay_ct0' => '2025-02-10',
 *     'pSo_ct' => 'HD001',
 *     'pSo_ct0' => 'HDNCC001',
 *     'pSo_seri0' => 'SERI001',
 *     'pMau_bc' => 1,
 *     'pMa_kh' => 'NCC001',
 *     'pTen_kh' => 'Công ty cung cấp',
 *     'pDia_chi' => 'Hà Nội',
 *     'pMa_so_thue' => '0123456789',
 *     'pMa_vt' => 'VT001',
 *     'pTen_vt' => 'Vật tư A',
 *     'pSo_luong' => 100.0,
 *     'pGia_nt' => 10.0,
 *     'pTien_hang_nt' => 1000.0,
 *     'pThue_nk_nt' => 100.0,
 *     'pThue_ttdb_nt' => 0.0,
 *     'pT_tien_nt' => 1100.0,
 *     'pThue_suat' => 10.0,
 *     'pT_thue_nt' => 100.0,
 *     'pMa_nt' => 'USD',
 *     'pTy_gia' => 23000.0,
 *     'pGia' => 230000.0,
 *     'pTien_hang' => 23000000.0,
 *     'pThue_nk' => 2300000.0,
 *     'pThue_ttdb' => 0.0,
 *     'pT_tien' => 25300000.0,
 *     'pT_thue' => 2300000.0,
 *     'pTk_thue_no' => '3331',
 *     'pTk_du' => '1541',
 *     'pGhi_chu' => 'Nhập kho từ NCC',
 *     'pMa_spct' => 'SPCT001',
 *     'pMa_lo' => 'LO001',
 *     'pVAT_NK' => true,
 *     'pStt_rec_pc' => '',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } elseif ($ret === 50211) {
 *     // Trùng số chứng từ + seri
 * } else {
 *     // Lỗi SQL khác
 * }
 * ```
 *
 * Liên quan:
 * - Bảng TaIn: lưu chi tiết nhập kho.
 * - Các procedure khác: asGetTaIn, asUpdTaIn, asDelTaIn.
 */
class AsInsTaIn
{
    /**
     * Gọi stored procedure asInsTaIn.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsTaIn', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pStt_rec0'     => $params['pStt_rec0'] ?? null,
            'pMa_ct'        => $params['pMa_ct'] ?? null,
            'pMa_bp'        => $params['pMa_bp'] ?? null,
            'pNgay_ct'      => $params['pNgay_ct'] ?? null,
            'pSo_seri_mhd'  => $params['pSo_seri_mhd'] ?? null,
            'pNgay_ct0'     => $params['pNgay_ct0'] ?? null,
            'pSo_ct'        => $params['pSo_ct'] ?? null,
            'pSo_ct0'       => $params['pSo_ct0'] ?? null,
            'pSo_seri0'     => $params['pSo_seri0'] ?? null,
            'pMau_bc'       => $params['pMau_bc'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pTen_kh'       => $params['pTen_kh'] ?? null,
            'pDia_chi'      => $params['pDia_chi'] ?? null,
            'pMa_so_thue'   => $params['pMa_so_thue'] ?? null,
            'pMa_vt'        => $params['pMa_vt'] ?? null,
            'pTen_vt'       => $params['pTen_vt'] ?? null,
            'pSo_luong'     => $params['pSo_luong'] ?? null,
            'pGia_nt'       => $params['pGia_nt'] ?? null,
            'pTien_hang_nt' => $params['pTien_hang_nt'] ?? null,
            'pThue_nk_nt'   => $params['pThue_nk_nt'] ?? null,
            'pThue_ttdb_nt' => $params['pThue_ttdb_nt'] ?? null,
            'pT_tien_nt'    => $params['pT_tien_nt'] ?? null,
            'pThue_suat'    => $params['pThue_suat'] ?? null,
            'pT_thue_nt'    => $params['pT_thue_nt'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTy_gia'       => $params['pTy_gia'] ?? null,
            'pGia'          => $params['pGia'] ?? null,
            'pTien_hang'    => $params['pTien_hang'] ?? null,
            'pThue_nk'      => $params['pThue_nk'] ?? null,
            'pThue_ttdb'    => $params['pThue_ttdb'] ?? null,
            'pT_tien'       => $params['pT_tien'] ?? null,
            'pT_thue'       => $params['pT_thue'] ?? null,
            'pTk_thue_no'   => $params['pTk_thue_no'] ?? null,
            'pTk_du'        => $params['pTk_du'] ?? null,
            'pGhi_chu'      => $params['pGhi_chu'] ?? null,
            'pMa_spct'      => $params['pMa_spct'] ?? null,
            'pMa_lo'        => $params['pMa_lo'] ?? null,
            'pVAT_NK'       => $params['pVAT_NK'] ?? null,
            'pStt_rec_pc'   => $params['pStt_rec_pc'] ?? null,
            'pRet'          => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asInsTaIn with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, ?string $Stt_rec0 = null, ?string $Ma_ct = null, ?string $Ma_bp = null, ?string $Ngay_ct = null, ?string $So_seri_mhd = null, ?string $Ngay_ct0 = null, ?string $So_ct = null, ?string $So_ct0 = null, ?string $So_seri0 = null, ?int $Mau_bc = null, ?string $Ma_kh = null, ?string $Ten_kh = null, ?string $Dia_chi = null, ?string $Ma_so_thue = null, ?string $Ma_vt = null, ?string $Ten_vt = null, ?float $So_luong = null, ?float $Gia_nt = null, ?float $Tien_hang_nt = null, ?float $Thue_nk_nt = null, ?float $Thue_ttdb_nt = null, ?float $T_tien_nt = null, ?float $Thue_suat = null, ?float $T_thue_nt = null, ?string $Ma_nt = null, ?float $Ty_gia = null, ?float $Gia = null, ?float $Tien_hang = null, ?float $Thue_nk = null, ?float $Thue_ttdb = null, ?float $T_tien = null, ?float $T_thue = null, ?string $Tk_thue_no = null, ?string $Tk_du = null, ?string $Ghi_chu = null, ?string $Ma_spct = null, ?string $Ma_lo = null, ?bool $VAT_NK = null, ?string $Stt_rec_pc = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'       => $Ma_cty,
            'pStt_rec'      => $Stt_rec,
            'pStt_rec0'     => $Stt_rec0,
            'pMa_ct'        => $Ma_ct,
            'pMa_bp'        => $Ma_bp,
            'pNgay_ct'      => $Ngay_ct,
            'pSo_seri_mhd'  => $So_seri_mhd,
            'pNgay_ct0'     => $Ngay_ct0,
            'pSo_ct'        => $So_ct,
            'pSo_ct0'       => $So_ct0,
            'pSo_seri0'     => $So_seri0,
            'pMau_bc'       => $Mau_bc,
            'pMa_kh'        => $Ma_kh,
            'pTen_kh'       => $Ten_kh,
            'pDia_chi'      => $Dia_chi,
            'pMa_so_thue'   => $Ma_so_thue,
            'pMa_vt'        => $Ma_vt,
            'pTen_vt'       => $Ten_vt,
            'pSo_luong'     => $So_luong,
            'pGia_nt'       => $Gia_nt,
            'pTien_hang_nt' => $Tien_hang_nt,
            'pThue_nk_nt'   => $Thue_nk_nt,
            'pThue_ttdb_nt' => $Thue_ttdb_nt,
            'pT_tien_nt'    => $T_tien_nt,
            'pThue_suat'    => $Thue_suat,
            'pT_thue_nt'    => $T_thue_nt,
            'pMa_nt'        => $Ma_nt,
            'pTy_gia'       => $Ty_gia,
            'pGia'          => $Gia,
            'pTien_hang'    => $Tien_hang,
            'pThue_nk'      => $Thue_nk,
            'pThue_ttdb'    => $Thue_ttdb,
            'pT_tien'       => $T_tien,
            'pT_thue'       => $T_thue,
            'pTk_thue_no'   => $Tk_thue_no,
            'pTk_du'        => $Tk_du,
            'pGhi_chu'      => $Ghi_chu,
            'pMa_spct'      => $Ma_spct,
            'pMa_lo'        => $Ma_lo,
            'pVAT_NK'       => $VAT_NK,
            'pStt_rec_pc'   => $Stt_rec_pc,
            'pRet'          => $Ret,
        ];

        return self::call($params);
    }
}
