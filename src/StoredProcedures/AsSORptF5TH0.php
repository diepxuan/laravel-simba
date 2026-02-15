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

class AsSORptF5TH0
{
    /**
     * Call stored procedure asSORptF5TH0
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptF5TH0', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1' => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pMa_plkh3'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pMa_plvt1' => $params['pMa_plvt1'] ?? null,
            'pMa_plvt2' => $params['pMa_plvt2'] ?? null,
            'pMa_plvt3' => $params['pMa_plvt3'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_Bp' => $params['pMa_Bp'] ?? null,
            'pMa_Nvkd' => $params['pMa_Nvkd'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pMa_Httt' => $params['pMa_Httt'] ?? null,
            'pHang_ban' => $params['pHang_ban'] ?? null,
            'pkhuyen_mai' => $params['pkhuyen_mai'] ?? null,
            'pTra_ck' => $params['pTra_ck'] ?? null,
            'pTra_lai' => $params['pTra_lai'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pMa_tt' => $params['pMa_tt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptF5TH0 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_plkh1
     * @param string $Ma_plkh2
     * @param string $Ma_plkh3
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Tk_vt
     * @param string $Ma_plvt1
     * @param string $Ma_plvt2
     * @param string $Ma_plvt3
     * @param string $Ma_kho
     * @param string $Ma_Bp
     * @param string $Ma_Nvkd
     * @param string $Ma_Hd
     * @param string $Ma_nhhd
     * @param string $Ma_Httt
     * @param bool $Hang_ban
     * @param bool $khuyen_mai
     * @param bool $Tra_ck
     * @param bool $Tra_lai
     * @param string $Ma_nt
     * @param string $Dvt
     * @param string $Ma_tt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_ct = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_plkh1 = null, string $Ma_plkh2 = null, string $Ma_plkh3 = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Tk_vt = null, string $Ma_plvt1 = null, string $Ma_plvt2 = null, string $Ma_plvt3 = null, string $Ma_kho = null, string $Ma_Bp = null, string $Ma_Nvkd = null, string $Ma_Hd = null, string $Ma_nhhd = null, string $Ma_Httt = null, bool $Hang_ban = null, bool $khuyen_mai = null, bool $Tra_ck = null, bool $Tra_lai = null, string $Ma_nt = null, string $Dvt = null, string $Ma_tt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_plkh1' => $Ma_plkh1,
            'pMa_plkh2' => $Ma_plkh2,
            'pMa_plkh3' => $Ma_plkh3,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pTk_vt' => $Tk_vt,
            'pMa_plvt1' => $Ma_plvt1,
            'pMa_plvt2' => $Ma_plvt2,
            'pMa_plvt3' => $Ma_plvt3,
            'pMa_kho' => $Ma_kho,
            'pMa_Bp' => $Ma_Bp,
            'pMa_Nvkd' => $Ma_Nvkd,
            'pMa_Hd' => $Ma_Hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pMa_Httt' => $Ma_Httt,
            'pHang_ban' => $Hang_ban,
            'pkhuyen_mai' => $khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pTra_lai' => $Tra_lai,
            'pMa_nt' => $Ma_nt,
            'pDvt' => $Dvt,
            'pMa_tt' => $Ma_tt
        ];
        
        return self::call($params);
    }
}
