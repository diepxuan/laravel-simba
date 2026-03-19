<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPostPoPh6_GlCt
{
    /**
     * Call stored procedure asPostPoPh6_GlCt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostPoPh6_GlCt', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pNamTC' => $paramObj->pNamTC ?? null,
            'pThangTC' => $paramObj->pThangTC ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_ks' => $paramObj->pNgay_ks ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pDs_tk_kt' => $paramObj->pDs_tk_kt ?? null,
            'pMa_Nt0' => $paramObj->pMa_Nt0 ?? null,
            'pMa_Nt' => $paramObj->pMa_Nt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostPoPh6_GlCt with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Tk_pt
     * @param string $Ds_tk_kt
     * @param string $Ma_Nt0
     * @param string $Ma_Nt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Tk_pt = null, string $Ds_tk_kt = null, string $Ma_Nt0 = null, string $Ma_Nt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pTk_pt' => $Tk_pt,
            'pDs_tk_kt' => $Ds_tk_kt,
            'pMa_Nt0' => $Ma_Nt0,
            'pMa_Nt' => $Ma_Nt
        ];

        return self::call($params);
    }
}
