<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 08:32:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsCT3.
 *
 * Stored procedure: asCAInsCT3
 * Mục đích: Thêm mới dòng chi tiết thứ 3 cho phiếu thu/chi (bảng CACT3 - Cash Chi Tiết 3).
 * Procedure thực hiện insert bản ghi mới vào bảng CACT3 với thông tin chi tiết bổ sung (phân tích sâu).
 *
 * Tham số (theo định nghĩa thực tế trong SQL Server):
 * - @pMa_cty (nvarchar(3)): Mã công ty. Bắt buộc.
 * - @pStt_rec (nvarchar(20)): Số tham chiếu phiếu cha (stt_rec). Bắt buộc.
 * - @pStt_rec0 (nvarchar(20)): Số thứ tự dòng (stt_rec0). Bắt buộc.
 * - @pStt_rec00 (int): Số thứ tự dòng con (stt_rec00). Default 0.
 * - @pTk (nvarchar(20)): Tài khoản. Bắt buộc.
 * - @pPs_no (decimal(19,4)): Phát sinh nợ. Default 0.0.
 * - @pPs_co (decimal(19,4)): Phát sinh có. Default 0.0.
 * - @pPs_no_nt (decimal(19,4)): Phát sinh nợ nguyên tệ. Default 0.0.
 * - @pPs_co_nt (decimal(19,4)): Phát sinh có nguyên tệ. Default 0.0.
 * - @pDien_giai (nvarchar(255)): Diễn giải nội dung. Default ''.
 * - @pMa_kh (nvarchar(20)): Mã khách hàng. Default ''.
 * - @pMa_ku (nvarchar(20)): Mã khu vực. Default ''.
 * - @pMa_lo (nvarchar(20)): Mã lô. Default ''.
 * - @pMa_bp (nvarchar(20)): Mã bộ phận. Default ''.
 * - @pMa_hd (nvarchar(20)): Mã hợp đồng. Default ''.
 * - @pMa_phi (nvarchar(20)): Mã phí. Default ''.
 * - @pMa_spct (nvarchar(20)): Mã sản phẩm chi tiết. Default ''.
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
 * $result = AsCAInsCT3::call([
 *     'pMa_cty' => '001',
 *     'pStt_rec' => '001wCA40000000676668',
 *     'pStt_rec0' => '00001',
 *     'pStt_rec00' => 1,
 *     'pTk' => '11217',
 *     'pPs_no' => 50000000,
 *     'pPs_co' => 0,
 *     'pDien_giai' => 'Phân bổ chi tiết dòng 1',
 *     'pMa_kh' => 'CCNHUNGGOI',
 *     'pMa_bp' => 'BP001',
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
 * - Procedure chỉ thực hiện insert, không kiểm tra tính hợp lệ của tài khoản.
 * - Output parameter @pRet được xử lý tự động bởi ProcedureCaller.
 */
class AsCAInsCT3
{
    /**
     * Gọi stored procedure asCAInsCT3.
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

        return ProcedureCaller::call('asCAInsCT3', [
            'pMa_cty'    => $paramObj->pMa_cty ?? null,
            'pStt_rec'   => $paramObj->pStt_rec ?? null,
            'pStt_rec0'  => $paramObj->pStt_rec0 ?? null,
            'pStt_rec00' => $paramObj->pStt_rec00 ?? 0,
            'pTk'        => $paramObj->pTk ?? null,
            'pPs_no'     => $paramObj->pPs_no ?? 0.0,
            'pPs_co'     => $paramObj->pPs_co ?? 0.0,
            'pPs_no_nt'  => $paramObj->pPs_no_nt ?? 0.0,
            'pPs_co_nt'  => $paramObj->pPs_co_nt ?? 0.0,
            'pDien_giai' => $paramObj->pDien_giai ?? '',
            'pMa_kh'     => $paramObj->pMa_kh ?? '',
            'pMa_ku'     => $paramObj->pMa_ku ?? '',
            'pMa_lo'     => $paramObj->pMa_lo ?? '',
            'pMa_bp'     => $paramObj->pMa_bp ?? '',
            'pMa_hd'     => $paramObj->pMa_hd ?? '',
            'pMa_phi'    => $paramObj->pMa_phi ?? '',
            'pMa_spct'   => $paramObj->pMa_spct ?? '',
            'pRet'       => ['type' => 'INT', 'output' => true],
        ], $connection);
    }

    /**
     * Call stored procedure asCAInsCT3 with named parameters (helper method).
     *
     * @param null|string $Ma_cty    Mã công ty
     * @param null|string $Stt_rec   Số tham chiếu
     * @param null|string $Stt_rec0  Số thứ tự dòng
     * @param null|int    $Stt_rec00 Số thứ tự dòng con
     * @param null|string $Tk        Tài khoản
     * @param null|float  $Ps_no     Phát sinh nợ
     * @param null|float  $Ps_co     Phát sinh có
     * @param null|float  $Ps_no_nt  Phát sinh nợ nguyên tệ
     * @param null|float  $Ps_co_nt  Phát sinh có nguyên tệ
     * @param null|string $Dien_giai Diễn giải
     * @param null|string $Ma_kh     Mã khách hàng
     * @param null|string $Ma_ku     Mã khu vực
     * @param null|string $Ma_lo     Mã lô
     * @param null|string $Ma_bp     Mã bộ phận
     * @param null|string $Ma_hd     Mã hợp đồng
     * @param null|string $Ma_phi    Mã phí
     * @param null|string $Ma_spct   Mã sản phẩm chi tiết
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Stt_rec = null,
        ?string $Stt_rec0 = null,
        ?int $Stt_rec00 = null,
        ?string $Tk = null,
        ?float $Ps_no = null,
        ?float $Ps_co = null,
        ?float $Ps_no_nt = null,
        ?float $Ps_co_nt = null,
        ?string $Dien_giai = null,
        ?string $Ma_kh = null,
        ?string $Ma_ku = null,
        ?string $Ma_lo = null,
        ?string $Ma_bp = null,
        ?string $Ma_hd = null,
        ?string $Ma_phi = null,
        ?string $Ma_spct = null,
    ): Collection {
        return self::call([
            'pMa_cty'    => $Ma_cty,
            'pStt_rec'   => $Stt_rec,
            'pStt_rec0'  => $Stt_rec0,
            'pStt_rec00' => $Stt_rec00,
            'pTk'        => $Tk,
            'pPs_no'     => $Ps_no,
            'pPs_co'     => $Ps_co,
            'pPs_no_nt'  => $Ps_no_nt,
            'pPs_co_nt'  => $Ps_co_nt,
            'pDien_giai' => $Dien_giai,
            'pMa_kh'     => $Ma_kh,
            'pMa_ku'     => $Ma_ku,
            'pMa_lo'     => $Ma_lo,
            'pMa_bp'     => $Ma_bp,
            'pMa_hd'     => $Ma_hd,
            'pMa_phi'    => $Ma_phi,
            'pMa_spct'   => $Ma_spct,
        ]);
    }
}
