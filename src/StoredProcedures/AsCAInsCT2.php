<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-19 13:44:47
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
}
