<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOUpdDMKM
{
    /**
     * Call stored procedure asSOUpdDMKM
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdDMKM', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_km' => $paramObj->pMa_km ?? null,
            'pTen_km' => $paramObj->pTen_km ?? null,
            'pTu_ngay' => $paramObj->pTu_ngay ?? null,
            'pDen_ngay' => $paramObj->pDen_ngay ?? null,
            'pTk_cpkm' => $paramObj->pTk_cpkm ?? null,
            'pMo_ta' => $paramObj->pMo_ta ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdDMKM with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_km
     * @param string $Ten_km
     * @param string $Tu_ngay
     * @param string $Den_ngay
     * @param string $Tk_cpkm
     * @param string $Mo_ta
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_km = null, string $Ten_km = null, string $Tu_ngay = null, string $Den_ngay = null, string $Tk_cpkm = null, string $Mo_ta = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_km' => $Ma_km,
            'pTen_km' => $Ten_km,
            'pTu_ngay' => $Tu_ngay,
            'pDen_ngay' => $Den_ngay,
            'pTk_cpkm' => $Tk_cpkm,
            'pMo_ta' => $Mo_ta,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
