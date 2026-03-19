<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSODeldmgiavantai
{
    /**
     * Call stored procedure asSODeldmgiavantai
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSODeldmgiavantai', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_td' => $paramObj->pMa_td ?? null,
            'pMa_pt' => $paramObj->pMa_pt ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSODeldmgiavantai with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_td
     * @param string $Ma_pt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_td = null, string $Ma_pt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_td' => $Ma_td,
            'pMa_pt' => $Ma_pt,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
