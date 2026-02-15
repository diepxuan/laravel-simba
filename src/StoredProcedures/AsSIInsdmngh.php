<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIInsdmngh
{
    /**
     * Call stored procedure asSIInsdmngh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIInsdmngh', $params, $connection);
    }

    /**
     * Call stored procedure asSIInsdmngh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ngh
     * @param string $Ten_ngh
     * @param string $Ghi_chu
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ngh = null, string $Ten_ngh = null, string $Ghi_chu = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ngh' => $Ma_ngh,
            'pTen_ngh' => $Ten_ngh,
            'pGhi_chu' => $Ghi_chu,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
