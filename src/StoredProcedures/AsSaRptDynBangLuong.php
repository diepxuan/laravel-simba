<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:08
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSaRptDynBangLuong
{
    /**
     * Call stored procedure asSaRptDynBangLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaRptDynBangLuong', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pLuyKe' => $paramObj->pLuyKe ?? null,
            'pSelectStr' => $paramObj->pSelectStr ?? null,
            'pSumStr' => $paramObj->pSumStr ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaRptDynBangLuong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param bool $LuyKe
     * @param string $SelectStr
     * @param string $SumStr
     * @param string $ParamDefines
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, bool $LuyKe = null, string $SelectStr = null, string $SumStr = null, string $ParamDefines = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pLuyKe' => $LuyKe,
            'pSelectStr' => $SelectStr,
            'pSumStr' => $SumStr,
            'ParamDefines' => $ParamDefines
        ];

        return self::call($params);
    }
}
