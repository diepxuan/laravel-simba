<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOUpdND51xlhd
{
    /**
     * Call stored procedure asSOUpdND51xlhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdND51xlhd', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pKieu_xl' => $paramObj->pKieu_xl ?? null,
            'pMa_tb' => $paramObj->pMa_tb ?? null,
            'pNgay_tb' => $paramObj->pNgay_tb ?? null,
            'pNoi_nhan' => $paramObj->pNoi_nhan ?? null,
            'pTen_tc' => $paramObj->pTen_tc ?? null,
            'pDai_dien' => $paramObj->pDai_dien ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pMa_thue' => $paramObj->pMa_thue ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pGio_xl' => $paramObj->pGio_xl ?? null,
            'pPhut_xl' => $paramObj->pPhut_xl ?? null,
            'pNgay_xl' => $paramObj->pNgay_xl ?? null,
            'pGui_cqt' => $paramObj->pGui_cqt ?? null,
            'pNgay_guicqt' => $paramObj->pNgay_guicqt ?? null,
            'pLdate' => $paramObj->pLdate ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdND51xlhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Kieu_xl
     * @param string $Ma_tb
     * @param string $Ngay_tb
     * @param string $Noi_nhan
     * @param string $Ten_tc
     * @param string $Dai_dien
     * @param string $Dia_chi
     * @param string $Ma_thue
     * @param string $Ghi_chu
     * @param string $Gio_xl
     * @param string $Phut_xl
     * @param string $Ngay_xl
     * @param bool $Gui_cqt
     * @param string $Ngay_guicqt
     * @param string $Ldate
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Kieu_xl = null, string $Ma_tb = null, string $Ngay_tb = null, string $Noi_nhan = null, string $Ten_tc = null, string $Dai_dien = null, string $Dia_chi = null, string $Ma_thue = null, string $Ghi_chu = null, string $Gio_xl = null, string $Phut_xl = null, string $Ngay_xl = null, bool $Gui_cqt = null, string $Ngay_guicqt = null, string $Ldate = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pKieu_xl' => $Kieu_xl,
            'pMa_tb' => $Ma_tb,
            'pNgay_tb' => $Ngay_tb,
            'pNoi_nhan' => $Noi_nhan,
            'pTen_tc' => $Ten_tc,
            'pDai_dien' => $Dai_dien,
            'pDia_chi' => $Dia_chi,
            'pMa_thue' => $Ma_thue,
            'pGhi_chu' => $Ghi_chu,
            'pGio_xl' => $Gio_xl,
            'pPhut_xl' => $Phut_xl,
            'pNgay_xl' => $Ngay_xl,
            'pGui_cqt' => $Gui_cqt,
            'pNgay_guicqt' => $Ngay_guicqt,
            'pLdate' => $Ldate,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
