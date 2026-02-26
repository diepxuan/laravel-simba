<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 00:14:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsTAOUT.
 *
 * Stored procedure: asInsTAOUT
 * Mục đích: Chèn một bản ghi xuất kho (hoặc chứng từ xuất) vào bảng TAOUT.
 * Bảng TAOUT lưu thông tin chi tiết xuất kho (có thể liên quan đến hàng hóa, thuế, tài khoản).
 * Procedure tự động tính tháng và năm tài chính dựa trên ngày chứng từ và mã công ty thông qua hàm dbo.afThangTC, dbo.afNamTC.
 * Các cột thời gian tạo/cập nhật (cdate, ldate) được gán bằng GETDATE(), người dùng (cuser, luser) bằng @pLUser.
 *
 * Tham số:
 * - @pMa_cty (string, bắt buộc): Mã công ty (3 ký tự).
 * - @pStt_rec (string, bắt buộc): Số thứ tự bản ghi (20 ký tự). Khóa chính?.
 * - @pStt_rec0 (string, bắt buộc): Số thứ tự bản ghi chi tiết (3 ký tự). Phân biệt các dòng trong cùng stt_rec.
 * - @pMa_ct (string, bắt buộc): Mã chứng từ (3 ký tự). Loại chứng từ xuất.
 * - @pNgay_ct (smalldatetime, bắt buộc): Ngày chứng từ.
 * - @pThang (int, bắt buộc): Tháng (không được sử dụng, vì được tính tự động). Có thể truyền giá trị tùy ý.
 * - @pNam (int, bắt buộc): Năm (không được sử dụng, tính tự động). Có thể truyền giá trị tùy ý.
 * - @pNgay_lct (smalldatetime, bắt buộc): Ngày lập chứng từ? (có thể ngày hạch toán).
 * - @pSo_ct (string, bắt buộc): Số chứng từ (12 ký tự).
 * - @pSo_seri (string, bắt buộc): Số seri (12 ký tự). Số seri hóa đơn.
 * - @pSo_seri_mhd (string, bắt buộc): Số seri mẫu hóa đơn (11 ký tự).
 * - @pMa_kh (string, bắt buộc): Mã khách hàng (20 ký tự).
 * - @pTen_kh (string, bắt buộc): Tên khách hàng (100 ký tự, Unicode).
 * - @pDia_chi (string, bắt buộc): Địa chỉ khách hàng (255 ký tự, Unicode).
 * - @pMa_so_thue (string, bắt buộc): Mã số thuế (20 ký tự).
 * - @pMa_vt (string, bắt buộc): Mã vật tư (20 ký tự).
 * - @pTen_vt (string, bắt buộc): Tên vật tư (100 ký tự, Unicode).
 * - @pSo_luong (decimal, bắt buộc): Số lượng xuất (độ chính xác 19,4).
 * - @pGia (decimal, bắt buộc): Giá xuất (đơn giá nội tệ) (19,4).
 * - @pGia_nt (decimal, bắt buộc): Giá xuất ngoại tệ (19,4).
 * - @pMa_nt (string, bắt buộc): Mã ngoại tệ (3 ký tự).
 * - @pTy_gia (decimal, bắt buộc): Tỷ giá (19,4).
 * - @pT_tien (decimal, bắt buộc): Thành tiền nội tệ (19,4).
 * - @pT_tien_nt (decimal, bắt buộc): Thành tiền ngoại tệ (19,4).
 * - @pMa_thue (string, bắt buộc): Mã thuế (20 ký tự).
 * - @pThue_suat (decimal, bắt buộc): Thuế suất (19,4).
 * - @pT_thue (decimal, bắt buộc): Tiền thuế nội tệ (19,4).
 * - @pT_thue_nt (decimal, bắt buộc): Tiền thuế ngoại tệ (19,4).
 * - @pTk_thue (string, bắt buộc): Tài khoản thuế (20 ký tự).
 * - @pTk_du (string, bắt buộc): Tài khoản dư (20 ký tự). Có thể là tài khoản đối ứng.
 * - @pMa_spct (string, bắt buộc): Mã sản phẩm công trình (20 ký tự).
 * - @pMa_lo (string, bắt buộc): Mã lô (20 ký tự).
 * - @pMa_bp (string, bắt buộc): Mã bộ phận (20 ký tự).
 * - @pMa_hd (string, bắt buộc): Mã hợp đồng (20 ký tự).
 * - @pGhi_chu (string, bắt buộc): Ghi chú (255 ký tự, Unicode).
 * - @pLUser (string, bắt buộc): Người dùng thực hiện (20 ký tự). Sẽ được gán cho cuser và luser.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 *
 * Giá trị mặc định:
 * - Không có.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 *
 * Logic chi tiết:
 * 1. INSERT vào TAOUT với các giá trị truyền vào.
 * 2. Cột thang = dbo.afThangTC(@pMa_cty, @pNgay_ct) (hàm tính tháng tài chính).
 * 3. Cột nam = dbo.afNamTC(@pMa_cty, @pNgay_ct) (hàm tính năm tài chính).
 * 4. Cột cdate, ldate = GETDATE().
 * 5. Cột cuser, luser = @pLUser.
 * 6. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Bảng TAOUT có khóa chính có thể là (ma_cty, stt_rec, stt_rec0) hoặc (stt_rec, stt_rec0).
 * - Các hàm afThangTC và afNamTC cần tồn tại trong database, trả về tháng/năm tài chính theo quy tắc của công ty.
 * - Tham số @pThang và @pNam không được sử dụng (bị comment). Tuy nhiên vẫn cần truyền để khớp với signature.
 * - Các giá trị decimal với độ chính xác 19,4 (tổng 19 chữ số, 4 chữ số thập phân).
 * - Nên đảm bảo các mã tham chiếu (ma_kh, ma_vt, ma_nt, ma_thue, ...) tồn tại trong các bảng danh mục.
 * - Có thể có ràng buộc khóa ngoại với các bảng khác.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsTAOUT::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => 'XK001',
 *     'pStt_rec0' => '001',
 *     'pMa_ct' => 'XK',
 *     'pNgay_ct' => '2025-02-11',
 *     'pThang' => 2,
 *     'pNam' => 2025,
 *     'pNgay_lct' => '2025-02-11',
 *     'pSo_ct' => 'HD001',
 *     'pSo_seri' => 'AB/2025',
 *     'pSo_seri_mhd' => 'MHD01',
 *     'pMa_kh' => 'KH001',
 *     'pTen_kh' => 'Công ty ABC',
 *     'pDia_chi' => 'Hà Nội',
 *     'pMa_so_thue' => '0123456789',
 *     'pMa_vt' => 'VT001',
 *     'pTen_vt' => 'Vật tư A',
 *     'pSo_luong' => 10.5,
 *     'pGia' => 1000000.0,
 *     'pGia_nt' => 0.0,
 *     'pMa_nt' => 'VND',
 *     'pTy_gia' => 1.0,
 *     'pT_tien' => 10500000.0,
 *     'pT_tien_nt' => 10500000.0,
 *     'pMa_thue' => 'VAT10',
 *     'pThue_suat' => 10.0,
 *     'pT_thue' => 1050000.0,
 *     'pT_thue_nt' => 1050000.0,
 *     'pTk_thue' => '3331',
 *     'pTk_du' => '1541',
 *     'pMa_spct' => 'SPCT001',
 *     'pMa_lo' => 'LO001',
 *     'pMa_bp' => 'BP001',
 *     'pMa_hd' => 'HD001',
 *     'pGhi_chu' => 'Xuất kho bán hàng',
 *     'pLUser' => 'admin',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 *
 * Liên quan:
 * - Bảng TAOUT: lưu chi tiết xuất kho.
 * - Các hàm dbo.afThangTC, dbo.afNamTC: tính tháng/năm tài chính.
 * - Các procedure khác: asGetTAOUT, asUpdTAOUT, asDelTAOUT.
 */
class AsInsTAOUT
{
    /**
     * Gọi stored procedure asInsTAOUT.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsTAOUT', [
            'pMa_cty'      => $params['pMa_cty'] ?? null,
            'pStt_rec'     => $params['pStt_rec'] ?? null,
            'pStt_rec0'    => $params['pStt_rec0'] ?? null,
            'pMa_ct'       => $params['pMa_ct'] ?? null,
            'pNgay_ct'     => $params['pNgay_ct'] ?? null,
            'pThang'       => $params['pThang'] ?? null,
            'pNam'         => $params['pNam'] ?? null,
            'pNgay_lct'    => $params['pNgay_lct'] ?? null,
            'pSo_ct'       => $params['pSo_ct'] ?? null,
            'pSo_seri'     => $params['pSo_seri'] ?? null,
            'pSo_seri_mhd' => $params['pSo_seri_mhd'] ?? null,
            'pMa_kh'       => $params['pMa_kh'] ?? null,
            'pTen_kh'      => $params['pTen_kh'] ?? null,
            'pDia_chi'     => $params['pDia_chi'] ?? null,
            'pMa_so_thue'  => $params['pMa_so_thue'] ?? null,
            'pMa_vt'       => $params['pMa_vt'] ?? null,
            'pTen_vt'      => $params['pTen_vt'] ?? null,
            'pSo_luong'    => $params['pSo_luong'] ?? null,
            'pGia'         => $params['pGia'] ?? null,
            'pGia_nt'      => $params['pGia_nt'] ?? null,
            'pMa_nt'       => $params['pMa_nt'] ?? null,
            'pTy_gia'      => $params['pTy_gia'] ?? null,
            'pT_tien'      => $params['pT_tien'] ?? null,
            'pT_tien_nt'   => $params['pT_tien_nt'] ?? null,
            'pMa_thue'     => $params['pMa_thue'] ?? null,
            'pThue_suat'   => $params['pThue_suat'] ?? null,
            'pT_thue'      => $params['pT_thue'] ?? null,
            'pT_thue_nt'   => $params['pT_thue_nt'] ?? null,
            'pTk_thue'     => $params['pTk_thue'] ?? null,
            'pTk_du'       => $params['pTk_du'] ?? null,
            'pMa_spct'     => $params['pMa_spct'] ?? null,
            'pMa_lo'       => $params['pMa_lo'] ?? null,
            'pMa_bp'       => $params['pMa_bp'] ?? null,
            'pMa_hd'       => $params['pMa_hd'] ?? null,
            'pGhi_chu'     => $params['pGhi_chu'] ?? null,
            'pLUser'       => $params['pLUser'] ?? null,
            'pRet'         => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asInsTAOUT with named parameters.
     */
    public static function callWithParams(?string $Ma_cty = null, ?string $Stt_rec = null, ?string $Stt_rec0 = null, ?string $Ma_ct = null, ?string $Ngay_ct = null, ?int $Thang = null, ?int $Nam = null, ?string $Ngay_lct = null, ?string $So_ct = null, ?string $So_seri = null, ?string $So_seri_mhd = null, ?string $Ma_kh = null, ?string $Ten_kh = null, ?string $Dia_chi = null, ?string $Ma_so_thue = null, ?string $Ma_vt = null, ?string $Ten_vt = null, ?float $So_luong = null, ?float $Gia = null, ?float $Gia_nt = null, ?string $Ma_nt = null, ?float $Ty_gia = null, ?float $T_tien = null, ?float $T_tien_nt = null, ?string $Ma_thue = null, ?float $Thue_suat = null, ?float $T_thue = null, ?float $T_thue_nt = null, ?string $Tk_thue = null, ?string $Tk_du = null, ?string $Ma_spct = null, ?string $Ma_lo = null, ?string $Ma_bp = null, ?string $Ma_hd = null, ?string $Ghi_chu = null, ?string $LUser = null, ?int $Ret = null): Collection
    {
        $params = [
            'pMa_cty'      => $Ma_cty,
            'pStt_rec'     => $Stt_rec,
            'pStt_rec0'    => $Stt_rec0,
            'pMa_ct'       => $Ma_ct,
            'pNgay_ct'     => $Ngay_ct,
            'pThang'       => $Thang,
            'pNam'         => $Nam,
            'pNgay_lct'    => $Ngay_lct,
            'pSo_ct'       => $So_ct,
            'pSo_seri'     => $So_seri,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pMa_kh'       => $Ma_kh,
            'pTen_kh'      => $Ten_kh,
            'pDia_chi'     => $Dia_chi,
            'pMa_so_thue'  => $Ma_so_thue,
            'pMa_vt'       => $Ma_vt,
            'pTen_vt'      => $Ten_vt,
            'pSo_luong'    => $So_luong,
            'pGia'         => $Gia,
            'pGia_nt'      => $Gia_nt,
            'pMa_nt'       => $Ma_nt,
            'pTy_gia'      => $Ty_gia,
            'pT_tien'      => $T_tien,
            'pT_tien_nt'   => $T_tien_nt,
            'pMa_thue'     => $Ma_thue,
            'pThue_suat'   => $Thue_suat,
            'pT_thue'      => $T_thue,
            'pT_thue_nt'   => $T_thue_nt,
            'pTk_thue'     => $Tk_thue,
            'pTk_du'       => $Tk_du,
            'pMa_spct'     => $Ma_spct,
            'pMa_lo'       => $Ma_lo,
            'pMa_bp'       => $Ma_bp,
            'pMa_hd'       => $Ma_hd,
            'pGhi_chu'     => $Ghi_chu,
            'pLUser'       => $LUser,
            'pRet'         => $Ret,
        ];

        return self::call($params);
    }
}
