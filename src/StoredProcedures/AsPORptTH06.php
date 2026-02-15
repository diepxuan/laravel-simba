<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPORptTH06
{
    /**
     * Call stored procedure asPORptTH06
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptTH06', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_loai' => $params['pMa_loai'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_TKVT' => $params['pMa_TKVT'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptTH06 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_loai
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_hd
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_TKVT
     * @param string $Ma_NT
     * @param string $SysMsg1
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_nt
     * @param string $Ma_Hd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_loai = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_hd = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_TKVT = null, string $Ma_NT = null, string $SysMsg1 = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_nt = null, string $Ma_Hd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_loai' => $Ma_loai,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_hd' => $Ma_hd,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_TKVT' => $Ma_TKVT,
            'pMa_NT' => $Ma_NT,
            'pSysMsg1' => $SysMsg1,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_nt' => $Ma_nt,
            'pMa_Hd' => $Ma_Hd
        ];
        
        return self::call($params);
    }
}
