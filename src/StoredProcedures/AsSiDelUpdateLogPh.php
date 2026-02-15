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

class AsSiDelUpdateLogPh
{
    /**
     * Call stored procedure asSiDelUpdateLogPh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiDelUpdateLogPh', [
            'pId' => $params['pId'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiDelUpdateLogPh with named parameters
     *
     * @param int $Id
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(int $Id = null, int $Ret = null): Collection
    {
        $params = [
            'pId' => $Id,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
