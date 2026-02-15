<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPORptBK05
{
    /**
     * Call stored procedure asPORptBK05
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptBK05', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_Phi' => $params['pMa_Phi'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptBK05 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_Phi
     * @param string $Ma_bp
     * @param string $Ma_nt
     * @param string $Ma_hd
     * @param string $Ma_spct
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_Hd
     * @param string $Ma_phi
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_Phi = null, string $Ma_bp = null, string $Ma_nt = null, string $Ma_hd = null, string $Ma_spct = null, string $Soct1 = null, string $Soct2 = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_Hd = null, string $Ma_phi = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_Phi' => $Ma_Phi,
            'pMa_bp' => $Ma_bp,
            'pMa_nt' => $Ma_nt,
            'pMa_hd' => $Ma_hd,
            'pMa_spct' => $Ma_spct,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_Hd' => $Ma_Hd,
            'pMa_phi' => $Ma_phi
        ];
        
        return self::call($params);
    }
}
