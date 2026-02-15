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

class AsSORptTH01
{
    /**
     * Call stored procedure asSORptTH01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptTH01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pHang_ban' => $params['pHang_ban'] ?? null,
            'pkhuyen_mai' => $params['pkhuyen_mai'] ?? null,
            'pTra_ck' => $params['pTra_ck'] ?? null,
            'pTra_lai' => $params['pTra_lai'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pMa_TT' => $params['pMa_TT'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nvkd' => $params['pMa_nvkd'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptTH01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Ma_kho
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param bool $Hang_ban
     * @param bool $khuyen_mai
     * @param bool $Tra_ck
     * @param bool $Tra_lai
     * @param string $Ma_NT
     * @param string $Ma_ct
     * @param string $Trang_thai
     * @param string $Ma_lo
     * @param string $Ma_vitri
     * @param string $Ma_httt
     * @param string $Ma_TT
     * @param string $Ma_bp
     * @param string $Ma_nvkd
     * @param string $Ma_spct
     * @param string $SysMsg1
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_nt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Ma_kho = null, string $Ma_vt = null, string $Ma_nhvt = null, bool $Hang_ban = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Tra_lai = null, string $Ma_NT = null, string $Ma_ct = null, string $Trang_thai = null, string $Ma_lo = null, string $Ma_vitri = null, string $Ma_httt = null, string $Ma_TT = null, string $Ma_bp = null, string $Ma_nvkd = null, string $Ma_spct = null, string $SysMsg1 = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_nt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_kho' => $Ma_kho,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pHang_ban' => $Hang_ban,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pTra_lai' => $Tra_lai,
            'pMa_NT' => $Ma_NT,
            'pMa_ct' => $Ma_ct,
            'pTrang_thai' => $Trang_thai,
            'pMa_lo' => $Ma_lo,
            'pMa_vitri' => $Ma_vitri,
            'pMa_httt' => $Ma_httt,
            'pMa_TT' => $Ma_TT,
            'pMa_bp' => $Ma_bp,
            'pMa_nvkd' => $Ma_nvkd,
            'pMa_spct' => $Ma_spct,
            'pSysMsg1' => $SysMsg1,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_nt' => $Ma_nt
        ];
        
        return self::call($params);
    }
}
