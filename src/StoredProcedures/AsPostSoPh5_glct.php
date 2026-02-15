<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostSoPh5_glct
{
    /**
     * Call stored procedure asPostSoPh5_glct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostSoPh5_glct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pDs_tk_kt' => $params['pDs_tk_kt'] ?? null,
            'pMa_Nt0' => $params['pMa_Nt0'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_nt0' => $params['pMa_nt0'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostSoPh5_glct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param int $ThangTC
     * @param int $NamTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Tk_pt
     * @param string $Ds_tk_kt
     * @param string $Ma_Nt0
     * @param string $Ma_Nt
     * @param mixed $Ma_nt
     * @param mixed $Ma_nt0
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, int $ThangTC = null, int $NamTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Tk_pt = null, string $Ds_tk_kt = null, string $Ma_Nt0 = null, string $Ma_Nt = null, mixed $Ma_nt = null, mixed $Ma_nt0 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pThangTC' => $ThangTC,
            'pNamTC' => $NamTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pTk_pt' => $Tk_pt,
            'pDs_tk_kt' => $Ds_tk_kt,
            'pMa_Nt0' => $Ma_Nt0,
            'pMa_Nt' => $Ma_Nt,
            'pMa_nt' => $Ma_nt,
            'pMa_nt0' => $Ma_nt0
        ];
        
        return self::call($params);
    }
}
