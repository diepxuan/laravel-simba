<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSaChkExistQuyLuong
{
    /**
     * Call stored procedure asSaChkExistQuyLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSaChkExistQuyLuong', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pRet' => $paramObj->pRet ?? null,
            'pMa_Bp' => $paramObj->pMa_Bp ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSaChkExistQuyLuong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Thang
     * @param int $Nam
     * @param string $Ma_bp
     * @param int $Ret
     * @param mixed $Ma_Bp
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Thang = null, int $Nam = null, string $Ma_bp = null, int $Ret = null, mixed $Ma_Bp = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pMa_bp' => $Ma_bp,
            'pRet' => $Ret,
            'pMa_Bp' => $Ma_Bp
        ];

        return self::call($params);
    }
}
