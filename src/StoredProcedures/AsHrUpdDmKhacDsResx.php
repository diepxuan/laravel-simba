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

class AsHrUpdDmKhacDsResx
{
    /**
     * Call stored procedure asHrUpdDmKhacDsResx
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmKhacDsResx', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pCode_name' => $paramObj->pCode_name ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null,
            'pName' => $paramObj->pName ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmKhacDsResx with named parameters
     *
     * @param string $Ma_cty
     * @param string $Code_name
     * @param string $Language
     * @param string $Name
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Code_name = null, string $Language = null, string $Name = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCode_name' => $Code_name,
            'pLanguage' => $Language,
            'pName' => $Name,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
