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

class AsSORptF5BCPT03
{
    /**
     * Call stored procedure asSORptF5BCPT03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptF5BCPT03', [
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
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pKhuyen_mai' => $params['pKhuyen_mai'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptF5BCPT03 with named parameters
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
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param mixed $Khuyen_mai
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_bp = null, string $Ma_nvkd = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Hang_ban = null, bool $Tra_lai = null, string $Ma_nt = null, string $ParamDefines = null, string $Ma_Cty = null, mixed $Khuyen_mai = null): Collection
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
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pKhuyen_mai' => $Khuyen_mai
        ];
        
        return self::call($params);
    }
}
