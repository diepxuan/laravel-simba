<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsTADELTNDN031A
{
    /**
     * Call stored procedure asTADELTNDN031A
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTADELTNDN031A', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pmau' => $params['pmau'] ?? null,
            'pma_so' => $params['pma_so'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTADELTNDN031A with named parameters
     *
     * @param string $Ma_cty
     * @param string $mau
     * @param string $ma_so
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $mau = null, string $ma_so = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pmau' => $mau,
            'pma_so' => $ma_so
        ];
        
        return self::call($params);
    }
}
