<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPostSoPh5_taOut
{
    /**
     * Call stored procedure asPostSoPh5_taOut
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostSoPh5_taOut', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pThangTC' => $paramObj->pThangTC ?? null,
            'pNamTC' => $paramObj->pNamTC ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_ks' => $paramObj->pNgay_ks ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pLen_tenVT' => $paramObj->pLen_tenVT ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostSoPh5_taOut with named parameters
     *
     * @param string $Ma_Cty
     * @param string $Stt_rec
     * @param int $ThangTC
     * @param int $NamTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param mixed $Ma_cty
     * @param mixed $Len_tenVT
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $Stt_rec = null, int $ThangTC = null, int $NamTC = null, string $Ngay_ct = null, string $Ngay_ks = null, mixed $Ma_cty = null, mixed $Len_tenVT = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pStt_rec' => $Stt_rec,
            'pThangTC' => $ThangTC,
            'pNamTC' => $NamTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_cty' => $Ma_cty,
            'pLen_tenVT' => $Len_tenVT
        ];

        return self::call($params);
    }
}
