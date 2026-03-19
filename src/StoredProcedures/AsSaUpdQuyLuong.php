<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSaUpdQuyLuong
{
    /**
     * Call stored procedure asSaUpdQuyLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaUpdQuyLuong', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pTen_bp' => $paramObj->pTen_bp ?? null,
            'pQl_t_dc' => $paramObj->pQl_t_dc ?? null,
            'pQl_s_dc' => $paramObj->pQl_s_dc ?? null,
            'pTyle_dc' => $paramObj->pTyle_dc ?? null,
            'pGiatri_dc' => $paramObj->pGiatri_dc ?? null,
            'pQl_dp' => $paramObj->pQl_dp ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaUpdQuyLuong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param string $Ten_bp
     * @param float $Ql_t_dc
     * @param float $Ql_s_dc
     * @param float $Tyle_dc
     * @param float $Giatri_dc
     * @param float $Ql_dp
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, string $Ten_bp = null, float $Ql_t_dc = null, float $Ql_s_dc = null, float $Tyle_dc = null, float $Giatri_dc = null, float $Ql_dp = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pTen_bp' => $Ten_bp,
            'pQl_t_dc' => $Ql_t_dc,
            'pQl_s_dc' => $Ql_s_dc,
            'pTyle_dc' => $Tyle_dc,
            'pGiatri_dc' => $Giatri_dc,
            'pQl_dp' => $Ql_dp,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
