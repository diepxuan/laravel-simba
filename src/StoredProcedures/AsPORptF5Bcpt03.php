<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPORptF5Bcpt03
{
    /**
     * Call stored procedure asPORptF5Bcpt03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptF5Bcpt03', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_Group' => $params['pMa_Group'] ?? null,
            'pMa_Detail' => $params['pMa_Detail'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pDetail' => $params['pDetail'] ?? null,
            'pTra_lai' => $params['pTra_lai'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptF5Bcpt03 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ma_Group
     * @param string $Ma_Detail
     * @param string $Group
     * @param string $Detail
     * @param bool $Tra_lai
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_phi = null, string $Ma_spct = null, string $Ma_Group = null, string $Ma_Detail = null, string $Group = null, string $Detail = null, bool $Tra_lai = null, string $ParamDefines = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pMa_Group' => $Ma_Group,
            'pMa_Detail' => $Ma_Detail,
            'pGroup' => $Group,
            'pDetail' => $Detail,
            'pTra_lai' => $Tra_lai,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
