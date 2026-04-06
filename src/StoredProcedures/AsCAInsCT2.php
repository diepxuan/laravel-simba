<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-04-06 18:46:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\Helper\ParamHelper;
use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsCAInsCT2.
 *
 * Stored procedure: asCAInsCT2
 * Mục đích: Thêm mới dòng chi tiết cho phiếu thu/chi (bảng CACT2).
 *
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Mã công ty
 * - @pStt_rec (nvarchar(20)): Số tham chiếu phiếu
 * - @pStt_rec0 (nvarchar(3)): Số thứ tự dòng
 * - @pTk (nvarchar(20)): Tài khoản
 * - @pPs_no (decimal): Phát sinh nợ
 * - @pPs_co (decimal): Phát sinh có
 * - @pPs_no_nt (decimal): PS nợ nguyên tệ
 * - @pPs_co_nt (decimal): PS có nguyên tệ
 * - @pDien_giai (nvarchar(255)): Diễn giải
 * - @pMa_kh (nvarchar(20)): Mã khách hàng
 * - @pMa_ku (nvarchar(20)): Mã khu vực
 * - @pMa_lo (nvarchar(20)): Mã lô
 * - @pMa_bp (nvarchar(20)): Mã bộ phận
 * - @pMa_hd (nvarchar(20)): Mã hợp đồng
 * - @pMa_phi (nvarchar(20)): Mã phí
 * - @pMa_spct (nvarchar(20)): Mã sản phẩm
 * - @pRet (int, OUTPUT): Kết quả trả về
 */
class AsCAInsCT2
{
    /**
     * Gọi stored procedure asCAInsCT2.
     *
     * @param array $params Mảng tham số
     *
     * @return Collection Kết quả từ procedure
     */
    public static function call(array $params): Collection
    {
        $paramObj   = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCAInsCT2', [
            'pMa_cty'    => $paramObj->pMa_cty ?? null,
            'pStt_rec'   => $paramObj->pStt_rec ?? null,
            'pStt_rec0'  => $paramObj->pStt_rec0 ?? null,
            'pTk'        => $paramObj->pTk ?? null,
            'pPs_no'     => $paramObj->pPs_no ?? 0,
            'pPs_co'     => $paramObj->pPs_co ?? 0,
            'pPs_no_nt'  => $paramObj->pPs_no_nt ?? 0,
            'pPs_co_nt'  => $paramObj->pPs_co_nt ?? 0,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pMa_kh'     => $paramObj->pMa_kh ?? null,
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
     * Call stored procedure asCAInsCT2 with named parameters (helper method).
     *
     * @param null|string $Ma_cty    Mã công ty
     * @param null|string $Stt_rec   Số tham chiếu
     * @param null|string $Stt_rec0  Số thứ tự dòng
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
     * @param null|string $Ma_spct   Mã sản phẩm
     *
     * @return Collection Kết quả từ procedure
     */
    public static function callWithParams(
        ?string $Ma_cty = null,
        ?string $Stt_rec = null,
        ?string $Stt_rec0 = null,
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
