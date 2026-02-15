<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiGetSetupByName
{
    /**
     * Call stored procedure asSiGetSetupByName
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetSetupByName', $params, $connection);
    }

    /**
     * Call stored procedure asSiGetSetupByName with named parameters
     *
     * @param string $Ma_Cty
     * @param mixed $Ten_bien
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, mixed $Ten_bien = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pTen_bien' => $Ten_bien
        ];
        
        return self::call($params);
    }
}
