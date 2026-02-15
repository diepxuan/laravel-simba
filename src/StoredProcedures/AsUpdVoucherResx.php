<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdVoucherResx
{
    /**
     * Call stored procedure asUpdVoucherResx
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdVoucherResx', [
            'pKey_Voucher_code' => $params['pKey_Voucher_code'] ?? null,
            'pKey_Language' => $params['pKey_Language'] ?? null,
            'pVoucher_code' => $params['pVoucher_code'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null,
            'pPh_formated_col_list' => $params['pPh_formated_col_list'] ?? null,
            'pCt_formated_col_list' => $params['pCt_formated_col_list'] ?? null,
            'pDescription' => $params['pDescription'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdVoucherResx with named parameters
     *
     * @param string $Key_Voucher_code
     * @param string $Key_Language
     * @param string $Voucher_code
     * @param string $Language
     * @param string $Ph_formated_col_list
     * @param string $Ct_formated_col_list
     * @param string $Description
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Key_Voucher_code = null, string $Key_Language = null, string $Voucher_code = null, string $Language = null, string $Ph_formated_col_list = null, string $Ct_formated_col_list = null, string $Description = null, int $Ret = null): Collection
    {
        $params = [
            'pKey_Voucher_code' => $Key_Voucher_code,
            'pKey_Language' => $Key_Language,
            'pVoucher_code' => $Voucher_code,
            'pLanguage' => $Language,
            'pPh_formated_col_list' => $Ph_formated_col_list,
            'pCt_formated_col_list' => $Ct_formated_col_list,
            'pDescription' => $Description,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
