<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetVoucherPhOptFieldInfo
{
    /**
     * Call stored procedure asGetVoucherPhOptFieldInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetVoucherPhOptFieldInfo', [
            'pVoucher_Code' => $params['pVoucher_Code'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGetVoucherPhOptFieldInfo with named parameters
     *
     * @param string $Voucher_Code
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Voucher_Code = null, string $Language = null): Collection
    {
        $params = [
            'pVoucher_Code' => $Voucher_Code,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
