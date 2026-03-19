<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiGetCt4PostGL
{
    /**
     * Call stored procedure asSiGetCt4PostGL
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetCt4PostGL', [
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_ph' => $paramObj->pMa_ph ?? null,
            'pLanguageId' => $paramObj->pLanguageId ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiGetCt4PostGL with named parameters
     *
     * @param string $Ma_Cty
     * @param string $Ma_ct
     * @param string $Ma_ph
     * @param string $LanguageId
     * @param mixed $Ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $Ma_ct = null, string $Ma_ph = null, string $LanguageId = null, mixed $Ma_cty = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pMa_ct' => $Ma_ct,
            'pMa_ph' => $Ma_ph,
            'pLanguageId' => $LanguageId,
            'pMa_cty' => $Ma_cty
        ];

        return self::call($params);
    }
}
