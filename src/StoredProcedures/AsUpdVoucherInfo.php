<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:21
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdVoucherInfo
{
    /**
     * Call stored procedure asUpdVoucherInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdVoucherInfo', [
            'pVoucher_code' => $params['pVoucher_code'] ?? null,
            'pPh_table_name' => $params['pPh_table_name'] ?? null,
            'pCt_table_name' => $params['pCt_table_name'] ?? null,
            'pCp_table_name' => $params['pCp_table_name'] ?? null,
            'pMenuid' => $params['pMenuid'] ?? null,
            'pPh_extra_edit_cotrol_list' => $params['pPh_extra_edit_cotrol_list'] ?? null,
            'pSearch_class_name' => $params['pSearch_class_name'] ?? null,
            'pView_class_name' => $params['pView_class_name'] ?? null,
            'pPrint_class_name' => $params['pPrint_class_name'] ?? null,
            'pMa_nt_default' => $params['pMa_nt_default'] ?? null,
            'pPh_carry_field_list' => $params['pPh_carry_field_list'] ?? null,
            'pCt_carry_field_list' => $params['pCt_carry_field_list'] ?? null,
            'pPh_print_field_list' => $params['pPh_print_field_list'] ?? null,
            'pRow_per_page' => $params['pRow_per_page'] ?? null,
            'pNumber_of_copy' => $params['pNumber_of_copy'] ?? null,
            'pHas_cp' => $params['pHas_cp'] ?? null,
            'pHas_tain' => $params['pHas_tain'] ?? null,
            'pHas_taout' => $params['pHas_taout'] ?? null,
            'pCopy_enabled' => $params['pCopy_enabled'] ?? null,
            'pCopy_vaora' => $params['pCopy_vaora'] ?? null,
            'pNxt' => $params['pNxt'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdVoucherInfo with named parameters
     *
     * @param string $Voucher_code
     * @param string $Ph_table_name
     * @param string $Ct_table_name
     * @param string $Cp_table_name
     * @param string $Menuid
     * @param string $Ph_extra_edit_cotrol_list
     * @param string $Search_class_name
     * @param string $View_class_name
     * @param string $Print_class_name
     * @param string $Ma_nt_default
     * @param string $Ph_carry_field_list
     * @param string $Ct_carry_field_list
     * @param string $Ph_print_field_list
     * @param int $Row_per_page
     * @param int $Number_of_copy
     * @param bool $Has_cp
     * @param bool $Has_tain
     * @param bool $Has_taout
     * @param bool $Copy_enabled
     * @param bool $Copy_vaora
     * @param string $Nxt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Voucher_code = null, string $Ph_table_name = null, string $Ct_table_name = null, string $Cp_table_name = null, string $Menuid = null, string $Ph_extra_edit_cotrol_list = null, string $Search_class_name = null, string $View_class_name = null, string $Print_class_name = null, string $Ma_nt_default = null, string $Ph_carry_field_list = null, string $Ct_carry_field_list = null, string $Ph_print_field_list = null, int $Row_per_page = null, int $Number_of_copy = null, bool $Has_cp = null, bool $Has_tain = null, bool $Has_taout = null, bool $Copy_enabled = null, bool $Copy_vaora = null, string $Nxt = null, int $Ret = null): Collection
    {
        $params = [
            'pVoucher_code' => $Voucher_code,
            'pPh_table_name' => $Ph_table_name,
            'pCt_table_name' => $Ct_table_name,
            'pCp_table_name' => $Cp_table_name,
            'pMenuid' => $Menuid,
            'pPh_extra_edit_cotrol_list' => $Ph_extra_edit_cotrol_list,
            'pSearch_class_name' => $Search_class_name,
            'pView_class_name' => $View_class_name,
            'pPrint_class_name' => $Print_class_name,
            'pMa_nt_default' => $Ma_nt_default,
            'pPh_carry_field_list' => $Ph_carry_field_list,
            'pCt_carry_field_list' => $Ct_carry_field_list,
            'pPh_print_field_list' => $Ph_print_field_list,
            'pRow_per_page' => $Row_per_page,
            'pNumber_of_copy' => $Number_of_copy,
            'pHas_cp' => $Has_cp,
            'pHas_tain' => $Has_tain,
            'pHas_taout' => $Has_taout,
            'pCopy_enabled' => $Copy_enabled,
            'pCopy_vaora' => $Copy_vaora,
            'pNxt' => $Nxt,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
