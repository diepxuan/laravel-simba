<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiExcSP
{
    /**
     * Call stored procedure asSiExcSP
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiExcSP', [
            'pStrCmd' => $paramObj->pStrCmd ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiExcSP with named parameters
     *
     * @param mixed $StrCmd
     * @return Collection
     */
    public static function callWithParams(mixed $StrCmd = null): Collection
    {
        $params = [
            'pStrCmd' => $StrCmd
        ];

        return self::call($params);
    }
}
