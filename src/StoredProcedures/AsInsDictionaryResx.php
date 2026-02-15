<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsDictionaryResx
{
    /**
     * Call stored procedure asInsDictionaryResx
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDictionaryResx', [
            'pCode_name' => $params['pCode_name'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null,
            'pFormated_col_list' => $params['pFormated_col_list'] ?? null,
            'pViewform_size' => $params['pViewform_size'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsDictionaryResx with named parameters
     *
     * @param string $Code_name
     * @param string $Language
     * @param string $Formated_col_list
     * @param string $Viewform_size
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Code_name = null, string $Language = null, string $Formated_col_list = null, string $Viewform_size = null, int $Ret = null): Collection
    {
        $params = [
            'pCode_name' => $Code_name,
            'pLanguage' => $Language,
            'pFormated_col_list' => $Formated_col_list,
            'pViewform_size' => $Viewform_size,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
