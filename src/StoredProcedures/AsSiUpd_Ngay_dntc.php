<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiUpd_Ngay_dntc
{
    /**
     * Call stored procedure asSiUpd_Ngay_dntc
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiUpd_Ngay_dntc', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_dntc' => $params['pNgay_dntc'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiUpd_Ngay_dntc with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_dntc
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_dntc = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_dntc' => $Ngay_dntc
        ];
        
        return self::call($params);
    }
}
