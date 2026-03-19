<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGetVoucherCtOptFieldInfo
{
    /**
     * Call stored procedure asGetVoucherCtOptFieldInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetVoucherCtOptFieldInfo', [
            'pVoucher_Code' => $paramObj->pVoucher_Code ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGetVoucherCtOptFieldInfo with named parameters
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
