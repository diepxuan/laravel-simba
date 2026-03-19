<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsUpdateLookupResX
{
    /**
     * Call stored procedure asUpdateLookupResX
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdateLookupResX', [
            'pcode_name' => $paramObj->pcode_name ?? null,
            'plang_id' => $paramObj->plang_id ?? null,
            'pformated_col_list' => $paramObj->pformated_col_list ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdateLookupResX with named parameters
     *
     * @param string $code_name
     * @param string $lang_id
     * @param string $formated_col_list
     * @return Collection
     */
    public static function callWithParams(string $code_name = null, string $lang_id = null, string $formated_col_list = null): Collection
    {
        $params = [
            'pcode_name' => $code_name,
            'plang_id' => $lang_id,
            'pformated_col_list' => $formated_col_list
        ];

        return self::call($params);
    }
}
