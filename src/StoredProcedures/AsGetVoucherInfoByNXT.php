<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:22
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGetVoucherInfoByNXT
{
    /**
     * Call stored procedure asGetVoucherInfoByNXT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetVoucherInfoByNXT', [
            'pNxt' => $paramObj->pNxt ?? null,
            'pLanguage' => $paramObj->pLanguage ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGetVoucherInfoByNXT with named parameters
     *
     * @param string $Nxt
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Nxt = null, string $Language = null): Collection
    {
        $params = [
            'pNxt' => $Nxt,
            'pLanguage' => $Language
        ];

        return self::call($params);
    }
}
