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
use Diepxuan\Simba\Helper\ParamHelper;

class AsUpdOpeningBlanceInfo
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdOpeningBlanceInfo', [
            'pCode_name' => $paramObj->pCode_name ?? null,
            'pPk' => $paramObj->pPk ?? null,
            'pCode_fname' => $paramObj->pCode_fname ?? null,
            'pMenuid' => $paramObj->pMenuid ?? null,
            'pCode_length' => $paramObj->pCode_length ?? null,
            'pName_fname' => $paramObj->pName_fname ?? null,
            'pTable_name' => $paramObj->pTable_name ?? null,
            'pLookup_when_invalid' => $paramObj->pLookup_when_invalid ?? null,
            'pAllow_merge_code' => $paramObj->pAllow_merge_code ?? null,
            'pDllname' => $paramObj->pDllname ?? null,
            'pView_class_name' => $paramObj->pView_class_name ?? null,
            'pEdit_class_name' => $paramObj->pEdit_class_name ?? null,
            'pDescription' => $paramObj->pDescription ?? null,
            'pCarry_field_list' => $paramObj->pCarry_field_list ?? null,
            'pDefault_sort' => $paramObj->pDefault_sort ?? null,
            'pCopy_vaora' => $paramObj->pCopy_vaora ?? null,
            'pPar0' => $paramObj->pPar0 ?? null,
            'pPar1' => $paramObj->pPar1 ?? null,
            'pPar2' => $paramObj->pPar2 ?? null,
            'pPar3' => $paramObj->pPar3 ?? null,
            'pPar4' => $paramObj->pPar4 ?? null,
            'pPar5' => $paramObj->pPar5 ?? null,
            'pPar6' => $paramObj->pPar6 ?? null,
            'pPar7' => $paramObj->pPar7 ?? null,
            'pPar8' => $paramObj->pPar8 ?? null,
            'pPar9' => $paramObj->pPar9 ?? null,
            'pRet' => $paramObj->pRet ?? null,
        ], $connection);
    }
}
