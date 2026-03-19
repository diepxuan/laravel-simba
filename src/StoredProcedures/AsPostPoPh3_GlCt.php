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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostPoPh3_GlCt', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pNamTC' => $paramObj->pNamTC ?? null,
            'pThangTC' => $paramObj->pThangTC ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_ks' => $paramObj->pNgay_ks ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_nt0' => $paramObj->pMa_nt0 ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pDs_tk_kt' => $paramObj->pDs_tk_kt ?? null,
            'pluser' => $paramObj->pluser ?? null,
            'pMa_Nt' => $paramObj->pMa_Nt ?? null,
            'pPO3' => $paramObj->pPO3 ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_Nt0' => $paramObj->pMa_Nt0 ?? null
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
