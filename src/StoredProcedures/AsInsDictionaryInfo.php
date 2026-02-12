<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:10:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsDictionaryInfo
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDictionaryInfo', [
            'pCode_name'            => $params['pCode_name'] ?? null,
            'pPk'                   => $params['pPk'] ?? null,
            'pCode_fname'           => $params['pCode_fname'] ?? null,
            'pMenuid'               => $params['pMenuid'] ?? null,
            'pCode_length'          => $params['pCode_length'] ?? null,
            'pName_fname'           => $params['pName_fname'] ?? null,
            'pTable_name'           => $params['pTable_name'] ?? null,
            'pLookup_when_invalid'  => $params['pLookup_when_invalid'] ?? null,
            'pAllow_merge_code'     => $params['pAllow_merge_code'] ?? null,
            'pDllname'              => $params['pDllname'] ?? null,
            'pView_class_name'      => $params['pView_class_name'] ?? null,
            'pEdit_class_name'      => $params['pEdit_class_name'] ?? null,
            'pDescription'          => $params['pDescription'] ?? null,
            'pCarry_field_list'     => $params['pCarry_field_list'] ?? null,
            'pDefault_sort'         => $params['pDefault_sort'] ?? null,
            'pCopy_vaora'           => $params['pCopy_vaora'] ?? null,
        ], $connection);
    }
}
