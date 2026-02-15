<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiDelMenu
{
    /**
     * Call stored procedure asSiDelMenu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiDelMenu', [
            'pMenuid' => $params['pMenuid'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiDelMenu with named parameters
     *
     * @param mixed $Menuid
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(mixed $Menuid = null, int $Ret = null): Collection
    {
        $params = [
            'pMenuid' => $Menuid,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
