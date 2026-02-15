<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostPoPh3_GlCt
{
    /**
     * Call stored procedure asPostPoPh3_GlCt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostPoPh3_GlCt', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pMa_gd' => $params['pMa_gd'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_nt0' => $params['pMa_nt0'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pDs_tk_kt' => $params['pDs_tk_kt'] ?? null,
            'pluser' => $params['pluser'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
            'pPO3' => $params['pPO3'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_Nt0' => $params['pMa_Nt0'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostPoPh3_GlCt with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Ma_gd
     * @param string $Ma_nt
     * @param string $Ma_nt0
     * @param string $Tk_pt
     * @param string $Ds_tk_kt
     * @param string $luser
     * @param mixed $Ma_Nt
     * @param mixed $PO3
     * @param mixed $Ma_ct
     * @param mixed $Ma_Nt0
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Ma_gd = null, string $Ma_nt = null, string $Ma_nt0 = null, string $Tk_pt = null, string $Ds_tk_kt = null, string $luser = null, mixed $Ma_Nt = null, mixed $PO3 = null, mixed $Ma_ct = null, mixed $Ma_Nt0 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_gd' => $Ma_gd,
            'pMa_nt' => $Ma_nt,
            'pMa_nt0' => $Ma_nt0,
            'pTk_pt' => $Tk_pt,
            'pDs_tk_kt' => $Ds_tk_kt,
            'pluser' => $luser,
            'pMa_Nt' => $Ma_Nt,
            'pPO3' => $PO3,
            'pMa_ct' => $Ma_ct,
            'pMa_Nt0' => $Ma_Nt0
        ];
        
        return self::call($params);
    }
}
