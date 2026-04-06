<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:32:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsLaiKu.
 *
 * Stored procedure: asCAInsLaiKu
 * Mục đích: Thêm mới lãi lỗ khấu hao (bảng CALAIKU - Cash Lãi Lỗ Khấu Hao).
 * Procedure thực hiện insert bản ghi mới vào bảng CALAIKU với thông tin tính toán lãi lỗ từ khấu hao tài sản cố định.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu (stt_rec). Bắt buộc.
 * - @pMa_ct (nvarchar(3)): Mã chứng từ (loại chứng từ). Bắt buộc.
 * - @pSo_ct (nvarchar(12)): Số chứng từ. Bắt buộc.
 * - @pNgay_ct (smalldatetime): Ngày chứng từ. Bắt buộc.
 * - @pNgay_lct (smalldatetime): Ngày lập chứng từ. Bắt buộc.
 * - @pMa_tscd (nvarchar(20)): Mã tài sản cố định. Bắt buộc.
 * - @pDien_giai (nvarchar(255)): Diễn giải nội dung. Bắt buộc.
 * - @pTk (nvarchar(20)): Tài khoản. Bắt buộc.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Default ''.
 * - @pMa_bp (nvarchar(20)): Mã bộ phận. Default ''.
 * - @pMa_dt (nvarchar(20)): Mã doanh thu. Default ''.
 * - @pMa_cp (nvarchar(20)): Mã chi phí. Default ''.
 * - @pSo_tien (decimal(19,4)): Số tiền lãi/lỗ. Default 0.0.
 * - @pSo_tien_nt (decimal(19,4)): Số tiền nguyên tệ. Default 0.0.
 * - @pTy_gia (decimal(19,4)): Tỷ giá. Default 1.0.
 * - @pMa_nt (nvarchar(3)): Mã ngoại tệ. Default 'VND'.
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
 * $result = AsCAInsLaiKu::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001wCA60000000000001',
 *     'pMa_ct' => 'CA6',
 *     'pSo_ct' => 'LL00001',
 *     'pNgay_ct' => '2026-04-06',
 *     'pNgay_lct' => '2026-04-06',
 *     'pMa_tscd' => 'TSCD001',
 *     'pDien_giai' => 'Tính lãi lỗ khấu hao TSCD 001',
 *     'pTk' => '911',
 *     'pMa_bp' => 'BP001',
 *     'pSo_tien' => 5000000,
 *     'pSo_tien_nt' => 5000000,
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
 * - Procedure chỉ thực hiện insert, không kiểm tra tính hợp lệ của bút toán.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCAInsLaiKu
{
    /**
     * Gọi stored procedure asCAInsLaiKu.
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

        return ProcedureCaller::call('asCAInsLaiKu', [
            'pMa_cty'     => $paramObj->pMa_cty ?? null,
            'pStt_rec'    => $paramObj->pStt_rec ?? null,
            'pMa_ct'      => $paramObj->pMa_ct ?? null,
            'pSo_ct'      => $paramObj->pSo_ct ?? null,
            'pNgay_ct'    => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'   => $paramObj->pNgay_lct ?? null,
            'pMa_tscd'    => $paramObj->pMa_tscd ?? null,
            'pDien_giai'  => $paramObj->pDien_giai ?? null,
            'pTk'         => $paramObj->pTk ?? null,
            'pMa_kh'      => $paramObj->pMa_kh ?? '',
            'pMa_bp'      => $paramObj->pMa_bp ?? '',
            'pMa_dt'      => $paramObj->pMa_dt ?? '',
            'pMa_cp'      => $paramObj->pMa_cp ?? '',
            'pSo_tien'    => $paramObj->pSo_tien ?? 0.0,
            'pSo_tien_nt' => $paramObj->pSo_tien_nt ?? 0.0,
            'pTy_gia'     => $paramObj->pTy_gia ?? 1.0,
            'pMa_nt'      => $paramObj->pMa_nt ?? 'VND',
            'pLUser'      => $paramObj->pLUser ?? null,
            'pRet'        => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAInsLaiKu with named parameters (helper method).
     *
     * @param null|string $Ma_cty     Mã công ty
     * @param null|string $Stt_rec    Số tham chiếu
     * @param null|string $Ma_ct      Mã chứng từ
     * @param null|string $So_ct      Số chứng từ
     * @param null|string $Ngay_ct    Ngày chứng từ
     * @param null|string $Ngay_lct   Ngày lập chứng từ
     * @param null|string $Ma_tscd    Mã tài sản cố định
     * @param null|string $Dien_giai  Diễn giải
     * @param null|string $Tk         Tài khoản
     * @param null|string $Ma_kh      Mã khách hàng
     * @param null|string $Ma_bp      Mã bộ phận
     * @param null|string $Ma_dt      Mã doanh thu
     * @param null|string $Ma_cp      Mã chi phí
     * @param null|float  $So_tien    Số tiền
     * @param null|float  $So_tien_nt Số tiền nguyên tệ
     * @param null|float  $Ty_gia     Tỷ giá
     * @param null|string $Ma_nt      Mã ngoại tệ
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
        ?string $Ma_tscd = null,
        ?string $Dien_giai = null,
        ?string $Tk = null,
        ?string $Ma_kh = null,
        ?string $Ma_bp = null,
        ?string $Ma_dt = null,
        ?string $Ma_cp = null,
        ?float $So_tien = null,
        ?float $So_tien_nt = null,
        ?float $Ty_gia = null,
        ?string $Ma_nt = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'     => $Ma_cty,
            'pStt_rec'    => $Stt_rec,
            'pMa_ct'      => $Ma_ct,
            'pSo_ct'      => $So_ct,
            'pNgay_ct'    => $Ngay_ct,
            'pNgay_lct'   => $Ngay_lct,
            'pMa_tscd'    => $Ma_tscd,
            'pDien_giai'  => $Dien_giai,
            'pTk'         => $Tk,
            'pMa_kh'      => $Ma_kh,
            'pMa_bp'      => $Ma_bp,
            'pMa_dt'      => $Ma_dt,
            'pMa_cp'      => $Ma_cp,
            'pSo_tien'    => $So_tien,
            'pSo_tien_nt' => $So_tien_nt,
            'pTy_gia'     => $Ty_gia,
            'pMa_nt'      => $Ma_nt,
            'pLUser'      => $LUser,
        ]);
    }
}
