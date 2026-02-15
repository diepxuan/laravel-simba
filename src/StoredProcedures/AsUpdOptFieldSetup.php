<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdOptFieldSetup
{
    /**
     * Call stored procedure asUpdOptFieldSetup
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdOptFieldSetup', [
            'pVoucher_code' => $params['pVoucher_code'] ?? null,
            'pField' => $params['pField'] ?? null,
            'pMaster' => $params['pMaster'] ?? null,
            'pDetail' => $params['pDetail'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdOptFieldSetup with named parameters
     *
     * @param string $Voucher_code
     * @param string $Field
     * @param bool $Master
     * @param bool $Detail
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Voucher_code = null, string $Field = null, bool $Master = null, bool $Detail = null, int $Ret = null): Collection
    {
        $params = [
            'pVoucher_code' => $Voucher_code,
            'pField' => $Field,
            'pMaster' => $Master,
            'pDetail' => $Detail,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
