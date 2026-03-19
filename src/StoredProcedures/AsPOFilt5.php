<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:29
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOFilt5
{
    /**
     * Call stored procedure asPOFilt5
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOFilt5', $params, $connection);
    }

    /**
     * Call stored procedure asPOFilt5 with named parameters
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
