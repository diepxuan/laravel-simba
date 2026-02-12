<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsDictionaryComplexResx
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDictionaryComplexResx', [
            'pCode_name'  => $params['pCode_name'] ?? null,
            'pLanguage'  => $params['pLanguage'] ?? null,
            'pFormated_col_list'  => $params['pFormated_col_list'] ?? null,
            'pViewform_size'  => $params['pViewform_size'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}