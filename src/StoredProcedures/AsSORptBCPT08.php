<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:08
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptBCPT08
{
    /**
     * Call stored procedure asSORptBCPT08
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT08', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pma_nhhd' => $params['pma_nhhd'] ?? null,
            'pMa_Bp' => $params['pMa_Bp'] ?? null,
            'pMa_Nvkd' => $params['pMa_Nvkd'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pngay1' => $params['pngay1'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nvkd' => $params['pMa_nvkd'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptBCPT08 with named parameters
     *
     * @param string $Ma_Cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_Hd
     * @param string $ma_nhhd
     * @param string $Ma_Bp
     * @param string $Ma_Nvkd
     * @param string $Ma_Nt
     * @param string $Group
     * @param mixed $ngay1
     * @param string $ParamDefines
     * @param string $Ma_nt
     * @param string $Ma_bp
     * @param string $Ma_nvkd
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_Hd = null, string $ma_nhhd = null, string $Ma_Bp = null, string $Ma_Nvkd = null, string $Ma_Nt = null, string $Group = null, mixed $ngay1 = null, string $ParamDefines = null, string $Ma_nt = null, string $Ma_bp = null, string $Ma_nvkd = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_Hd' => $Ma_Hd,
            'pma_nhhd' => $ma_nhhd,
            'pMa_Bp' => $Ma_Bp,
            'pMa_Nvkd' => $Ma_Nvkd,
            'pMa_Nt' => $Ma_Nt,
            'pGroup' => $Group,
            'pngay1' => $ngay1,
            'ParamDefines' => $ParamDefines,
            'pMa_nt' => $Ma_nt,
            'pMa_bp' => $Ma_bp,
            'pMa_nvkd' => $Ma_nvkd
        ];
        
        return self::call($params);
    }
}
