<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:13:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGetardmkh_nh
{
    /**
     * Call stored procedure asGetardmkh_nh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGetardmkh_nh', $params, $connection);
    }

    /**
     * Call stored procedure asGetardmkh_nh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kh
     * @param string $Ma_ngh
     * @param string $So_tk
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kh = null, string $Ma_ngh = null, string $So_tk = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kh' => $Ma_kh,
            'pMa_ngh' => $Ma_ngh,
            'pSo_tk' => $So_tk
        ];
        
        return self::call($params);
    }
}
