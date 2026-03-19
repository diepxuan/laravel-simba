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

class AsPostInPh6TD_GlCt
{
    /**
     * Call stored procedure asPostInPh6TD_GlCt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostInPh6TD_GlCt', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pNamTC' => $paramObj->pNamTC ?? null,
            'pThangTC' => $paramObj->pThangTC ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_ks' => $paramObj->pNgay_ks ?? null,
            'pMa_nt0' => $paramObj->pMa_nt0 ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_Nt' => $paramObj->pMa_Nt ?? null,
            'pMa_Nt0' => $paramObj->pMa_Nt0 ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostInPh6TD_GlCt with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Ma_nt0
     * @param string $Ma_nt
     * @param mixed $Ma_Nt
     * @param mixed $Ma_Nt0
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Ma_nt0 = null, string $Ma_nt = null, mixed $Ma_Nt = null, mixed $Ma_Nt0 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_nt0' => $Ma_nt0,
            'pMa_nt' => $Ma_nt,
            'pMa_Nt' => $Ma_Nt,
            'pMa_Nt0' => $Ma_Nt0
        ];

        return self::call($params);
    }
}
