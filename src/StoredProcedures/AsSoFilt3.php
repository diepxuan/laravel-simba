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
use Diepxuan\Simba\Helper\ParamHelper;

class AsSoFilt3
{
    /**
     * Call stored procedure asSoFilt3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoFilt3', $params, $connection);
    }

    /**
     * Call stored procedure asSoFilt3 with named parameters
     *
     * @param string $KeyPh
     * @param string $KeyCt
     * @return Collection
     */
    public static function callWithParams(string $KeyPh = null, string $KeyCt = null): Collection
    {
        $params = [
            'pKeyPh' => $KeyPh,
            'pKeyCt' => $KeyCt
        ];

        return self::call($params);
    }
}
