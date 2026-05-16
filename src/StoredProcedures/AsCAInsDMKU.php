<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-05-16 09:35:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsDMKU.
 *
 * Stored procedure: asCAInsDMKU
 * Mục đích: Thêm mới danh mục khấu hao (bảng CADMKU - Cash Danh Mục Khấu Hao).
 * Procedure thực hiện insert bản ghi mới vào bảng CADMKU với thông tin danh mục khấu hao tài sản cố định.
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pMa_tscd (nvarchar(20)): Mã tài sản cố định. Bắt buộc.
 * - @pTen_tscd (nvarchar(100)): Tên tài sản cố định. Bắt buộc.
 * - @pMa_nh (nvarchar(10)): Mã nhóm tài sản. Default ''.
 * - @pMa_loai (nvarchar(10)): Mã loại tài sản. Default ''.
 * - @pNguyen_gia (decimal(19,4)): Nguyên giá tài sản. Default 0.0.
 * - @pGia_tri_ha (decimal(19,4)): Giá trị hao mòn. Default 0.0.
 * - @pTy_le_kh (decimal(19,4)): Tỷ lệ khấu hao (%). Default 0.0.
 * - @pSo_kh_thang (decimal(19,4)): Số khấu hao tháng. Default 0.0.
 * - @pNgay_mua (smalldatetime): Ngày mua tài sản. Default NULL.
 * - @pNgay_sd (smalldatetime): Ngày đưa vào sử dụng. Default NULL.
 * - @pNgay_ngung (smalldatetime): Ngày ngưng khấu hao. Default NULL.
 * - @pTk_nguyen_gia (nvarchar(20)): Tài khoản nguyên giá. Default ''.
 * - @pTk_kh (nvarchar(20)): Tài khoản khấu hao. Default ''.
 * - @pTk_cp (nvarchar(20)): Tài khoản chi phí. Default ''.
 * - @pDien_giai (nvarchar(255)): Diễn giải. Default ''.
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
 * $result = AsCAInsDMKU::call([
 *     'pMa_cty' => '001',
 *     'pMa_tscd' => 'TSCD001',
 *     'pTen_tscd' => 'Máy tính văn phòng',
 *     'pMa_nh' => 'NH01',
 *     'pMa_loai' => 'LOAI01',
 *     'pNguyen_gia' => 20000000,
 *     'pTy_le_kh' => 20,
 *     'pSo_kh_thang' => 333333.33,
 *     'pNgay_mua' => '2026-01-01',
 *     'pNgay_sd' => '2026-01-15',
 *     'pTk_nguyen_gia' => '211',
 *     'pTk_kh' => '214',
 *     'pTk_cp' => '6422',
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
 * - Procedure chỉ thực hiện insert, không kiểm tra trùng mã tài sản.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCAInsDMKU
{
    /**
     * Gọi stored procedure asCAInsDMKU.
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

        return ProcedureCaller::call('asCAInsDMKU', [
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
     * Call stored procedure asCAInsDMKU with named parameters (helper method).
     *
     * @param null|string $Ma_cty        Mã công ty
     * @param null|string $Ma_tscd       Mã tài sản cố định
     * @param null|string $Ten_tscd      Tên tài sản cố định
     * @param null|string $Ma_nh         Mã nhóm tài sản
     * @param null|string $Ma_loai       Mã loại tài sản
     * @param null|float  $Nguyen_gia    Nguyên giá
     * @param null|float  $Gia_tri_ha    Giá trị hao mòn
     * @param null|float  $Ty_le_kh      Tỷ lệ khấu hao
     * @param null|float  $So_kh_thang   Số khấu hao tháng
     * @param null|string $Ngay_mua      Ngày mua
     * @param null|string $Ngay_sd       Ngày sử dụng
     * @param null|string $Ngay_ngung    Ngày ngưng
     * @param null|string $Tk_nguyen_gia Tài khoản nguyên giá
     * @param null|string $Tk_kh         Tài khoản khấu hao
     * @param null|string $Tk_cp         Tài khoản chi phí
     * @param null|string $Dien_giai     Diễn giải
     * @param null|string $LUser         Người dùng
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Ma_tscd = null,
        ?string $Ten_tscd = null,
        ?string $Ma_nh = null,
        ?string $Ma_loai = null,
        ?float $Nguyen_gia = null,
        ?float $Gia_tri_ha = null,
        ?float $Ty_le_kh = null,
        ?float $So_kh_thang = null,
        ?string $Ngay_mua = null,
        ?string $Ngay_sd = null,
        ?string $Ngay_ngung = null,
        ?string $Tk_nguyen_gia = null,
        ?string $Tk_kh = null,
        ?string $Tk_cp = null,
        ?string $Dien_giai = null,
        ?string $LUser = null,
    ): Collection {
        return self::call([
            'pMa_cty'        => $Ma_cty,
            'pMa_tscd'       => $Ma_tscd,
            'pTen_tscd'      => $Ten_tscd,
            'pMa_nh'         => $Ma_nh,
            'pMa_loai'       => $Ma_loai,
            'pNguyen_gia'    => $Nguyen_gia,
            'pGia_tri_ha'    => $Gia_tri_ha,
            'pTy_le_kh'      => $Ty_le_kh,
            'pSo_kh_thang'   => $So_kh_thang,
            'pNgay_mua'      => $Ngay_mua,
            'pNgay_sd'       => $Ngay_sd,
            'pNgay_ngung'    => $Ngay_ngung,
            'pTk_nguyen_gia' => $Tk_nguyen_gia,
            'pTk_kh'         => $Tk_kh,
            'pTk_cp'         => $Tk_cp,
            'pDien_giai'     => $Dien_giai,
            'pLUser'         => $LUser,
        ]);
    }
}
