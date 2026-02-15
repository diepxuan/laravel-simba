<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptBCPT03
{
    /**
     * Call stored procedure asSORptBCPT03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT03', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nvkd' => $params['pMa_nvkd'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pkhuyen_mai' => $params['pkhuyen_mai'] ?? null,
            'pTra_ck' => $params['pTra_ck'] ?? null,
            'pHang_ban' => $params['pHang_ban'] ?? null,
            'pTra_lai' => $params['pTra_lai'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTkCP_BH' => $params['pTkCP_BH'] ?? null,
            'pTkCP_QL' => $params['pTkCP_QL'] ?? null,
            'pPsNc_BH' => $params['pPsNc_BH'] ?? null,
            'pPsNc_QL' => $params['pPsNc_QL'] ?? null,
            'pTKCP_BH_DU' => $params['pTKCP_BH_DU'] ?? null,
            'pTKCP_QL_DU' => $params['pTKCP_QL_DU'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pKhuyen_mai' => $params['pKhuyen_mai'] ?? null,
            'pTong_Dt' => $params['pTong_Dt'] ?? null,
            'p641' => $params['p641'] ?? null,
            'p642' => $params['p642'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptBCPT03 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_bp
     * @param string $Ma_nvkd
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param bool $khuyen_mai
     * @param bool $Tra_ck
     * @param bool $Hang_ban
     * @param bool $Tra_lai
     * @param string $Ma_nt
     * @param string $TkCP_BH
     * @param string $TkCP_QL
     * @param bool $PsNc_BH
     * @param bool $PsNc_QL
     * @param string $TKCP_BH_DU
     * @param string $TKCP_QL_DU
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param mixed $Ma_Cty
     * @param string $ParamDefines
     * @param mixed $Khuyen_mai
     * @param float $Tong_Dt
     * @param float $641
     * @param float $642
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_bp = null, string $Ma_nvkd = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Hang_ban = null, bool $Tra_lai = null, string $Ma_nt = null, string $TkCP_BH = null, string $TkCP_QL = null, bool $PsNc_BH = null, bool $PsNc_QL = null, string $TKCP_BH_DU = null, string $TKCP_QL_DU = null, string $SysMsg1 = null, string $SysMsg2 = null, mixed $Ma_Cty = null, string $ParamDefines = null, mixed $Khuyen_mai = null, float $Tong_Dt = null, float $641 = null, float $642 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_bp' => $Ma_bp,
            'pMa_nvkd' => $Ma_nvkd,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pHang_ban' => $Hang_ban,
            'pTra_lai' => $Tra_lai,
            'pMa_nt' => $Ma_nt,
            'pTkCP_BH' => $TkCP_BH,
            'pTkCP_QL' => $TkCP_QL,
            'pPsNc_BH' => $PsNc_BH,
            'pPsNc_QL' => $PsNc_QL,
            'pTKCP_BH_DU' => $TKCP_BH_DU,
            'pTKCP_QL_DU' => $TKCP_QL_DU,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pMa_Cty' => $Ma_Cty,
            'ParamDefines' => $ParamDefines,
            'pKhuyen_mai' => $Khuyen_mai,
            'pTong_Dt' => $Tong_Dt,
            'p641' => $641,
            'p642' => $642
        ];
        
        return self::call($params);
    }
}
