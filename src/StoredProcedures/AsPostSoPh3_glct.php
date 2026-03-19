<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPostSoPh3_glct
{
    /**
     * Call stored procedure asPostSoPh3_glct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostSoPh3_glct', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pChi_post_giavon' => $paramObj->pChi_post_giavon ?? null,
            'pNamTC' => $paramObj->pNamTC ?? null,
            'pThangTC' => $paramObj->pThangTC ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_ks' => $paramObj->pNgay_ks ?? null,
            'pMa_nt0' => $paramObj->pMa_nt0 ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pDs_tk_kt' => $paramObj->pDs_tk_kt ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pNhom_dk' => $paramObj->pNhom_dk ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostSoPh3_glct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param bool $Chi_post_giavon
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Ma_nt0
     * @param string $Ma_nt
     * @param string $Tk_pt
     * @param string $Ds_tk_kt
     * @param string $Ma_gd
     * @param string $Nhom_dk
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, bool $Chi_post_giavon = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Ma_nt0 = null, string $Ma_nt = null, string $Tk_pt = null, string $Ds_tk_kt = null, string $Ma_gd = null, string $Nhom_dk = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pChi_post_giavon' => $Chi_post_giavon,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_nt0' => $Ma_nt0,
            'pMa_nt' => $Ma_nt,
            'pTk_pt' => $Tk_pt,
            'pDs_tk_kt' => $Ds_tk_kt,
            'pMa_gd' => $Ma_gd,
            'pNhom_dk' => $Nhom_dk
        ];

        return self::call($params);
    }
}
