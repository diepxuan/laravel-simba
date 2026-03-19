<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSaRptTongQuyLuong
{
    /**
     * Call stored procedure asSaRptTongQuyLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaRptTongQuyLuong', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_cv' => $paramObj->pMa_cv ?? null,
            'pBHXH' => $paramObj->pBHXH ?? null,
            'pMa_mau' => $paramObj->pMa_mau ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaRptTongQuyLuong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param string $Ma_cv
     * @param string $BHXH
     * @param string $Ma_mau
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, string $Ma_cv = null, string $BHXH = null, string $Ma_mau = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pMa_cv' => $Ma_cv,
            'pBHXH' => $BHXH,
            'pMa_mau' => $Ma_mau,
            'pMa_Cty' => $Ma_Cty
        ];

        return self::call($params);
    }
}
