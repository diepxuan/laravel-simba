<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINFilt6
{
    /**
     * Call stored procedure asINFilt6
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINFilt6', $params, $connection);
    }

    /**
     * Call stored procedure asINFilt6 with named parameters
     *
     * @param string $KeyPh
     * @param string $KeyCtM
     * @param string $KeyCtD
     * @return Collection
     */
    public static function callWithParams(string $KeyPh = null, string $KeyCtM = null, string $KeyCtD = null): Collection
    {
        $params = [
            'pKeyPh' => $KeyPh,
            'pKeyCtM' => $KeyCtM,
            'pKeyCtD' => $KeyCtD
        ];
        
        return self::call($params);
    }
}
