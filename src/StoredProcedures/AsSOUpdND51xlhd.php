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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdND51xlhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pKieu_xl' => $params['pKieu_xl'] ?? null,
            'pMa_tb' => $params['pMa_tb'] ?? null,
            'pNgay_tb' => $params['pNgay_tb'] ?? null,
            'pNoi_nhan' => $params['pNoi_nhan'] ?? null,
            'pTen_tc' => $params['pTen_tc'] ?? null,
            'pDai_dien' => $params['pDai_dien'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pGio_xl' => $params['pGio_xl'] ?? null,
            'pPhut_xl' => $params['pPhut_xl'] ?? null,
            'pNgay_xl' => $params['pNgay_xl'] ?? null,
            'pGui_cqt' => $params['pGui_cqt'] ?? null,
            'pNgay_guicqt' => $params['pNgay_guicqt'] ?? null,
            'pLdate' => $params['pLdate'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
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
