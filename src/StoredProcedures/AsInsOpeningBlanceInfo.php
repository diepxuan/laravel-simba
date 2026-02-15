<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsOpeningBlanceInfo
{
    /**
     * Call stored procedure asInsOpeningBlanceInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsOpeningBlanceInfo', [
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
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsOpeningBlanceInfo with named parameters
     *
     * @param string $Code_name
     * @param string $Pk
     * @param string $Code_fname
     * @param string $Menuid
     * @param int $Code_length
     * @param string $Name_fname
     * @param string $Table_name
     * @param bool $Lookup_when_invalid
     * @param bool $Allow_merge_code
     * @param string $Dllname
     * @param string $View_class_name
     * @param string $Edit_class_name
     * @param string $Description
     * @param string $Carry_field_list
     * @param string $Default_sort
     * @param bool $Copy_vaora
     * @param string $Par0
     * @param string $Par1
     * @param string $Par2
     * @param string $Par3
     * @param string $Par4
     * @param string $Par5
     * @param string $Par6
     * @param string $Par7
     * @param string $Par8
     * @param string $Par9
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Code_name = null, string $Pk = null, string $Code_fname = null, string $Menuid = null, int $Code_length = null, string $Name_fname = null, string $Table_name = null, bool $Lookup_when_invalid = null, bool $Allow_merge_code = null, string $Dllname = null, string $View_class_name = null, string $Edit_class_name = null, string $Description = null, string $Carry_field_list = null, string $Default_sort = null, bool $Copy_vaora = null, string $Par0 = null, string $Par1 = null, string $Par2 = null, string $Par3 = null, string $Par4 = null, string $Par5 = null, string $Par6 = null, string $Par7 = null, string $Par8 = null, string $Par9 = null, int $Ret = null): Collection
    {
        $params = [
            'pCode_name' => $Code_name,
            'pPk' => $Pk,
            'pCode_fname' => $Code_fname,
            'pMenuid' => $Menuid,
            'pCode_length' => $Code_length,
            'pName_fname' => $Name_fname,
            'pTable_name' => $Table_name,
            'pLookup_when_invalid' => $Lookup_when_invalid,
            'pAllow_merge_code' => $Allow_merge_code,
            'pDllname' => $Dllname,
            'pView_class_name' => $View_class_name,
            'pEdit_class_name' => $Edit_class_name,
            'pDescription' => $Description,
            'pCarry_field_list' => $Carry_field_list,
            'pDefault_sort' => $Default_sort,
            'pCopy_vaora' => $Copy_vaora,
            'pPar0' => $Par0,
            'pPar1' => $Par1,
            'pPar2' => $Par2,
            'pPar3' => $Par3,
            'pPar4' => $Par4,
            'pPar5' => $Par5,
            'pPar6' => $Par6,
            'pPar7' => $Par7,
            'pPar8' => $Par8,
            'pPar9' => $Par9,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
