<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdateVoucherResX
{
    /**
     * Call stored procedure asUpdateVoucherResX
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdateVoucherResX', [
            'pVoucher_Code' => $params['pVoucher_Code'] ?? null,
            'plang_id' => $params['plang_id'] ?? null,
            'pformated_col_list' => $params['pformated_col_list'] ?? null,
            'pPh_Ct' => $params['pPh_Ct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdateVoucherResX with named parameters
     *
     * @param string $Voucher_Code
     * @param string $lang_id
     * @param string $formated_col_list
     * @param string $Ph_Ct
     * @return Collection
     */
    public static function callWithParams(string $Voucher_Code = null, string $lang_id = null, string $formated_col_list = null, string $Ph_Ct = null): Collection
    {
        $params = [
            'pVoucher_Code' => $Voucher_Code,
            'plang_id' => $lang_id,
            'pformated_col_list' => $formated_col_list,
            'pPh_Ct' => $Ph_Ct
        ];
        
        return self::call($params);
    }
}
