<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiReOrderVoucherNumber
{
    /**
     * Call stored procedure asSiReOrderVoucherNumber
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiReOrderVoucherNumber', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'ph' => $paramObj->ph ?? null,
            'prefix' => $paramObj->prefix ?? null,
            'pattern' => $paramObj->pattern ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pWidth' => $paramObj->pWidth ?? null,
            'pma_cty' => $paramObj->pma_cty ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiReOrderVoucherNumber with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $So_ct
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $User
     * @param mixed $h
     * @param string $refix
     * @param string $attern
     * @param string $ParamDefines
     * @param string $Width
     * @param mixed $ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $So_ct = null, string $Ngay1 = null, string $Ngay2 = null, string $User = null, mixed $h = null, string $refix = null, string $attern = null, string $ParamDefines = null, string $Width = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pSo_ct' => $So_ct,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pUser' => $User,
            'ph' => $h,
            'prefix' => $refix,
            'pattern' => $attern,
            'ParamDefines' => $ParamDefines,
            'pWidth' => $Width,
            'pma_cty' => $ma_cty
        ];

        return self::call($params);
    }
}
