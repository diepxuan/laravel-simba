<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptF5BCPT04
{
    /**
     * Call stored procedure asSORptF5BCPT04
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptF5BCPT04', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_Bp' => $params['pMa_Bp'] ?? null,
            'pMa_Nvkd' => $params['pMa_Nvkd'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pkhuyen_mai' => $params['pkhuyen_mai'] ?? null,
            'pTra_ck' => $params['pTra_ck'] ?? null,
            'pHang_ban' => $params['pHang_ban'] ?? null,
            'pTra_lai' => $params['pTra_lai'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptF5BCPT04 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_Bp
     * @param string $Ma_Nvkd
     * @param string $Ma_Hd
     * @param bool $khuyen_mai
     * @param bool $Tra_ck
     * @param bool $Hang_ban
     * @param bool $Tra_lai
     * @param string $Ngay1
     * @param string $Ngay2
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_Bp = null, string $Ma_Nvkd = null, string $Ma_Hd = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Hang_ban = null, bool $Tra_lai = null, string $Ngay1 = null, string $Ngay2 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_Bp' => $Ma_Bp,
            'pMa_Nvkd' => $Ma_Nvkd,
            'pMa_Hd' => $Ma_Hd,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pHang_ban' => $Hang_ban,
            'pTra_lai' => $Tra_lai,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2
        ];
        
        return self::call($params);
    }
}
