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

class AsSIGetDMCT
{
    /**
     * Call stored procedure asSIGetDMCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pPhan_he' => $paramObj->pPhan_he ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null,
            'pStruct' => $paramObj->pStruct ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIGetDMCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $Phan_he
     * @param string $Language
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $Phan_he = null, string $Language = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pPhan_he' => $Phan_he,
            'pLanguage' => $Language,
            'pStruct' => $Struct
        ];

        return self::call($params);
    }
}
