<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:32:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsCDKU.
 *
 * Stored procedure: asCAInsCDKU
 * Mục đích: Thêm mới chứng từ điều chỉnh khấu hao (bảng CACDKU - Cash Adjustment Khấu Hao).
 * Procedure thực hiện insert bản ghi mới vào bảng CACDKU với thông tin điều chỉnh khấu hao tài sản cố định.
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
 * - @pTk_cp (nvarchar(20)): Tài khoản chi phí. Bắt buộc.
 * - @pTk_kh (nvarchar(20)): Tài khoản khấu hao. Bắt buộc.
 * - @pNguyen_gia (decimal(19,4)): Nguyên giá tài sản. Default 0.0.
 * - @pTy_le_kh (decimal(19,4)): Tỷ lệ khấu hao (%). Default 0.0.
 * - @pSo_kh (decimal(19,4)): Số khấu hao tháng. Default 0.0.
 * - @pSo_kh_luy_ke (decimal(19,4)): Số khấu hao lũy kế. Default 0.0.
 * - @pSo_kh_cn (decimal(19,4)): Số khấu hao cần điều chỉnh. Default 0.0.
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
 * $result = AsCAInsCDKU::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001wCA50000000000001',
 *     'pMa_ct' => 'CA5',
 *     'pSo_ct' => 'DC00001',
 *     'pNgay_ct' => '2026-04-06',
 *     'pNgay_lct' => '2026-04-06',
 *     'pMa_tscd' => 'TSCD001',
 *     'pDien_giai' => 'Điều chỉnh khấu hao TSCD 001',
 *     'pTk_cp' => '6422',
 *     'pTk_kh' => '214',
 *     'pNguyen_gia' => 100000000,
 *     'pTy_le_kh' => 10,
 *     'pSo_kh' => 833333.33,
 *     'pSo_kh_luy_ke' => 25000000,
 *     'pSo_kh_cn' => 100000,
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
class AsCAInsCDKU
{
    /**
     * Gọi stored procedure asCAInsCDKU.
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

        return ProcedureCaller::call('asCAInsCDKU', [
            'pMa_cty'       => $paramObj->pMa_cty ?? null,
            'pStt_rec'      => $paramObj->pStt_rec ?? null,
            'pMa_ct'        => $paramObj->pMa_ct ?? null,
            'pSo_ct'        => $paramObj->pSo_ct ?? null,
            'pNgay_ct'      => $paramObj->pNgay_ct ?? null,
            'pNgay_lct'     => $paramObj->pNgay_lct ?? null,
            'pMa_tscd'      => $paramObj->pMa_tscd ?? null,
            'pDien_giai'    => $paramObj->pDien_giai ?? null,
            'pTk_cp'        => $paramObj->pTk_cp ?? null,
            'pTk_kh'        => $paramObj->pTk_kh ?? null,
            'pNguyen_gia'   => $paramObj->pNguyen_gia ?? 0.0,
            'pTy_le_kh'     => $paramObj->pTy_le_kh ?? 0.0,
            'pSo_kh'        => $paramObj->pSo_kh ?? 0.0,
            'pSo_kh_luy_ke' => $paramObj->pSo_kh_luy_ke ?? 0.0,
            'pSo_kh_cn'     => $paramObj->pSo_kh_cn ?? 0.0,
            'pLUser'        => $paramObj->pLUser ?? null,
            'pRet'          => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAInsCDKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty       Mã công ty
     * @param null|string $Stt_rec      Số tham chiếu
     * @param null|string $Ma_ct        Mã chứng từ
     * @param null|string $So_ct        Số chứng từ
     * @param null|string $Ngay_ct      Ngày chứng từ
     * @param null|string $Ngay_lct     Ngày lập chứng từ
     * @param null|string $Ma_tscd      Mã tài sản cố định
     * @param null|string $Dien_giai    Diễn giải
     * @param null|string $Tk_cp        Tài khoản chi phí
     * @param null|string $Tk_kh        Tài khoản khấu hao
     * @param null|float  $Nguyen_gia   Nguyên giá
     * @param null|float  $Ty_le_kh     Tỷ lệ khấu hao
     * @param null|float  $So_kh        Số khấu hao tháng
     * @param null|float  $So_kh_luy_ke Số khấu hao lũy kế
     * @param null|float  $So_kh_cn     Số khấu hao cần điều chỉnh
     * @param null|string $LUser        Người dùng
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
        ?string $Tk_cp = null,
        ?string $Tk_kh = null,
        ?float $Nguyen_gia = null,
        ?float $Ty_le_kh = null,
        ?float $So_kh = null,
        ?float $So_kh_luy_ke = null,
        ?float $So_kh_cn = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'       => $Ma_cty,
            'pStt_rec'      => $Stt_rec,
            'pMa_ct'        => $Ma_ct,
            'pSo_ct'        => $So_ct,
            'pNgay_ct'      => $Ngay_ct,
            'pNgay_lct'     => $Ngay_lct,
            'pMa_tscd'      => $Ma_tscd,
            'pDien_giai'    => $Dien_giai,
            'pTk_cp'        => $Tk_cp,
            'pTk_kh'        => $Tk_kh,
            'pNguyen_gia'   => $Nguyen_gia,
            'pTy_le_kh'     => $Ty_le_kh,
            'pSo_kh'        => $So_kh,
            'pSo_kh_luy_ke' => $So_kh_luy_ke,
            'pSo_kh_cn'     => $So_kh_cn,
            'pLUser'        => $LUser,
        ]);
    }
}
