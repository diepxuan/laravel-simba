<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptBK02
{
    /**
     * Call stored procedure asSORptBK02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBK02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pMa_TT' => $params['pMa_TT'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nvkd' => $params['pMa_nvkd'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pGroupType' => $params['pGroupType'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptBK02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_ct
     * @param string $Trang_thai
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_lo
     * @param string $Ma_httt
     * @param string $Ma_TT
     * @param string $Ma_bp
     * @param string $Ma_nvkd
     * @param string $Ma_spct
     * @param string $Ma_nt
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $GroupType
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_ct = null, string $Trang_thai = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_lo = null, string $Ma_httt = null, string $Ma_TT = null, string $Ma_bp = null, string $Ma_nvkd = null, string $Ma_spct = null, string $Ma_nt = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Soct1 = null, string $Soct2 = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $GroupType = null, string $ParamDefines = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_ct' => $Ma_ct,
            'pTrang_thai' => $Trang_thai,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo' => $Ma_lo,
            'pMa_httt' => $Ma_httt,
            'pMa_TT' => $Ma_TT,
            'pMa_bp' => $Ma_bp,
            'pMa_nvkd' => $Ma_nvkd,
            'pMa_spct' => $Ma_spct,
            'pMa_nt' => $Ma_nt,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pGroupType' => $GroupType,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
