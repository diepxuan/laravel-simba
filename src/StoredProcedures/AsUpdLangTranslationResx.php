<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdLangTranslationResx
{
    /**
     * Call stored procedure asUpdLangTranslationResx
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdLangTranslationResx', [
            'pDllFullName' => $params['pDllFullName'] ?? null,
            'pUserControlName' => $params['pUserControlName'] ?? null,
            'pControlName' => $params['pControlName'] ?? null,
            'pPropertyName' => $params['pPropertyName'] ?? null,
            'pFormula' => $params['pFormula'] ?? null,
            'pdefaultValue' => $params['pdefaultValue'] ?? null,
            'pValue' => $params['pValue'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdLangTranslationResx with named parameters
     *
     * @param string $DllFullName
     * @param string $UserControlName
     * @param string $ControlName
     * @param string $PropertyName
     * @param string $Formula
     * @param string $defaultValue
     * @param string $Value
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $DllFullName = null, string $UserControlName = null, string $ControlName = null, string $PropertyName = null, string $Formula = null, string $defaultValue = null, string $Value = null, string $Language = null): Collection
    {
        $params = [
            'pDllFullName' => $DllFullName,
            'pUserControlName' => $UserControlName,
            'pControlName' => $ControlName,
            'pPropertyName' => $PropertyName,
            'pFormula' => $Formula,
            'pdefaultValue' => $defaultValue,
            'pValue' => $Value,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
