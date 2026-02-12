<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdOpeningBlanceInfo
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdOpeningBlanceInfo', [
            'pCode_name' => $params['pCode_name'] ?? null,
            'pPk' => $params['pPk'] ?? null,
            'pCode_fname' => $params['pCode_fname'] ?? null,
            'pMenuid' => $params['pMenuid'] ?? null,
            'pCode_length' => $params['pCode_length'] ?? null,
            'pName_fname' => $params['pName_fname'] ?? null,
            'pTable_name' => $params['pTable_name'] ?? null,
            'pLookup_when_invalid' => $params['pLookup_when_invalid'] ?? null,
            'pAllow_merge_code' => $params['pAllow_merge_code'] ?? null,
            'pDllname' => $params['pDllname'] ?? null,
            'pView_class_name' => $params['pView_class_name'] ?? null,
            'pEdit_class_name' => $params['pEdit_class_name'] ?? null,
            'pDescription' => $params['pDescription'] ?? null,
            'pCarry_field_list' => $params['pCarry_field_list'] ?? null,
            'pDefault_sort' => $params['pDefault_sort'] ?? null,
            'pCopy_vaora' => $params['pCopy_vaora'] ?? null,
            'pPar0' => $params['pPar0'] ?? null,
            'pPar1' => $params['pPar1'] ?? null,
            'pPar2' => $params['pPar2'] ?? null,
            'pPar3' => $params['pPar3'] ?? null,
            'pPar4' => $params['pPar4'] ?? null,
            'pPar5' => $params['pPar5'] ?? null,
            'pPar6' => $params['pPar6'] ?? null,
            'pPar7' => $params['pPar7'] ?? null,
            'pPar8' => $params['pPar8'] ?? null,
            'pPar9' => $params['pPar9'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
