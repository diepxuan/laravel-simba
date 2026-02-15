<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdDictionaryInfo
{
    /**
     * Call stored procedure asUpdDictionaryInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDictionaryInfo', [
            'pCode_name' => $params['pCode_name'] ?? null,
            'pKey_Code_name' => $params['pKey_Code_name'] ?? null,
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
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDictionaryInfo with named parameters
     *
     * @param string $Code_name
     * @param string $Key_Code_name
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
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Code_name = null, string $Key_Code_name = null, string $Pk = null, string $Code_fname = null, string $Menuid = null, int $Code_length = null, string $Name_fname = null, string $Table_name = null, bool $Lookup_when_invalid = null, bool $Allow_merge_code = null, string $Dllname = null, string $View_class_name = null, string $Edit_class_name = null, string $Description = null, string $Carry_field_list = null, string $Default_sort = null, bool $Copy_vaora = null, int $Ret = null): Collection
    {
        $params = [
            'pCode_name' => $Code_name,
            'pKey_Code_name' => $Key_Code_name,
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
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
