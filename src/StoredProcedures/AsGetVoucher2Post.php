<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGetVoucher2Post
{
    /**
     * Call stored procedure asGetVoucher2Post
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetVoucher2Post', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pSo_ct1' => $paramObj->pSo_ct1 ?? null,
            'pSo_ct2' => $paramObj->pSo_ct2 ?? null,
            'pMa_CtLst' => $paramObj->pMa_CtLst ?? null,
            'pPost2gl' => $paramObj->pPost2gl ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGetVoucher2Post with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $So_ct1
     * @param string $So_ct2
     * @param string $Ma_CtLst
     * @param string $Post2gl
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $So_ct1 = null, string $So_ct2 = null, string $Ma_CtLst = null, string $Post2gl = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pSo_ct1' => $So_ct1,
            'pSo_ct2' => $So_ct2,
            'pMa_CtLst' => $Ma_CtLst,
            'pPost2gl' => $Post2gl,
            'pMa_Cty' => $Ma_Cty
        ];

        return self::call($params);
    }
}
